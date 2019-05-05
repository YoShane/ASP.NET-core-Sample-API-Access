using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab_A.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace Lab_A.Controllers
{
    public class MessageController : Controller
    {
        private string baseUri = "https://localhost:5050/api/values"; //API位置

        public IActionResult Index()
        {
            return View();
        }

        //POST: Message/Send
        // Bind是一種防止過度發佈的方式
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Index([Bind("Data")]Message msg)
        {
            if (ModelState.IsValid) {

                using (var client = new HttpClient()) {
                    Message message = new Message();

                    try {
                        var myContent = JsonConvert.SerializeObject(msg);
                        var stringContent = new StringContent(myContent, UnicodeEncoding.UTF8, "application/json");
                        HttpResponseMessage response = await client.PostAsync(baseUri, stringContent);

                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();
                        message.Confirmation = responseBody;
                    }
                    catch{
                        message.Data = msg.Data;
                        message.Confirmation = "Error!";
                    }
                        
                    return View(message);
                }
            }
            return View(msg);
        }

    }
}