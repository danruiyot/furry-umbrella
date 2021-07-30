using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyQuiz.Models
{
    public class QuizVewModel
    {
        public List<QuestionViewModel> Questions { get; set; }
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }
    }
}
