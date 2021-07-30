using System;
using System.ComponentModel.DataAnnotations;

namespace MyQuiz.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Answer { get; set; }
    }
}
