using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyQuiz.Models
{
    public class QuestionViewModel
    {
        public int Id { get; set; }
        public int SerialNumber { get; set; }

        public string Description { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string SelectedOption { get; set; }

        public string Answer { get; set; }



    }
}
