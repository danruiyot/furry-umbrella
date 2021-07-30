using System;
using System.ComponentModel.DataAnnotations;

namespace MyQuiz.Models
{
    public class Results
    {
        public int Id { get; set; }
        public string result { get; set; }
        public string dateTimes { get; set; }
    }
}
