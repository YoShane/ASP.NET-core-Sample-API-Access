using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_B.Models
{
    public class MyObject
    {
        public string State { get; set; }
        public string Data { get;}
        public string Msg { get; set; }

        public MyObject(string msg)
        {
            Data = msg;
            Msg = null;
        }

    }
}
