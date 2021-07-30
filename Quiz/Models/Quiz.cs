using System.Collections.Generic;

namespace MyQuiz.Models
{
    public class Quiz
    {
        //public int Id { get; set; }
        public int TopicId { get; set; }
        public IEnumerable<Question> Questions { get; set; }
        public int Score { get; set; }
    }
}
