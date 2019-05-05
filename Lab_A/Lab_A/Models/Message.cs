using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab_A.Models
{
    public class Message
    {
        [Required]
        public string Data { get; set; }

        public string Confirmation { get; set; }
    }
}
