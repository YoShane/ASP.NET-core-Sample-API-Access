using System;
using System.IO;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Threading.Tasks;
using Lab_B.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Lab_B.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private string connectionString = "Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=";

        // POST api/values
        [HttpPost]
        public async Task<string> Post([FromBody]  Message message)
        {
            MyObject objReturn = new MyObject(message.Data);  
            var dbPath = Directory.GetParent(Environment.CurrentDirectory).FullName;
            connectionString += (dbPath + "\\record.accdb");

            using (OdbcConnection connection = new OdbcConnection(connectionString)) {
                string addQuery = $"INSERT INTO recordData (Data) Values ('{message.Data}')";

                try {
                    await connection.OpenAsync();
                    OdbcCommand command = new OdbcCommand(addQuery, connection);
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                    objReturn.State = "Success";
                }
                catch(Exception ex){
                    objReturn.State = "Fail";
                    objReturn.Msg = ex.ToString();
                }

                var jsonSetting = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
                return JsonConvert.SerializeObject(objReturn, Formatting.Indented, jsonSetting);
            }

        }


    }
}