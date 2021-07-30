using System.Collections.Generic;

namespace MyQuiz.Models
{
    public class QuestionPool
    {
        public int TopicId { get; set; }

        public IEnumerable<Question> Questions { get; set; }
    }
}
