using System;
using System.Collections.Generic;
using System.Linq;

using MyQuiz.Models;

namespace MyQuiz.Helpers
{
    public class QuizRepository
    {
        //private List<Topic> _topics;
        private IEnumerable<QuestionPool> _questionPool;

        private const int _NumberOfQuestions = 10;


        public enum TopicList
        {
            GeneralKnowledge = 1,
            History = 2,
            Maths = 3,
            Science = 4
        }

        public QuizRepository()
        {
            LoadQuestionPool();
        }


        private void LoadQuestionPool()
        {
            _questionPool = new List<QuestionPool>
            {
                new QuestionPool
                {
                    TopicId = (int) TopicList.GeneralKnowledge,
                    Questions = new List<Question>
                    {
                        new Question
                        {
                            Id          = 1,
                            Description = "Which of the following is a reserved keyword in C#?",
                            Option1     = "abstract",
                            Option2     = "as",
                            Option3     = "foreach",
                            Option4     = "All of the above",
                            Answer      = "All of the above"
                        },
                        new Question
                        {
                            Id          = 2,
                            Description = "Which of the following converts a type to a 32-bit integer in C#?",
                            Option1     = "ToDecimal",
                            Option2     = "ToDouble",
                            Option3     = "ToInt16",
                            Option4     = "ToInt32",
                            Answer      = "ToInt32"
                        },
                        new Question
                        {
                            Id          = 3,
                            Description = "Which of the following operator determines whether an object is of a certain type in C#?",
                            Option1     = "?",
                            Option2     = "is",
                            Option3     = "as",
                            Option4     = "*",
                            Answer      = "*"
                        },
                        new Question
                        {
                            Id = 4,
                            Description = "Which of the following access specifier in C# allows a child class to access the member variables and member functions of its base class?",
                            Option1 = "Public",
                            Option2 = "Private",
                            Option3 = "Protected",
                            Option4 = "Internal",
                            Answer = "Protected"
                        },
                        new Question
                        {
                            Id = 5,
                            Description = "Which of the following property of Array class in C# gets the rank (number of dimensions) of the Array?",
                            Option1 = "Rank",
                            Option2 = "LongLength",
                            Option3 = "Length",
                            Option4 = "None of the above.",
                            Answer = "Rank"
                        },
                        new Question
                        {
                            Id = 6,
                            Description = "Which of the following preprocessor directive allows generating an error from a specific location in your code in C#?",
                            Option1 = "define",
                            Option2 = "region",
                            Option3 = "line",
                            Option4 = "error",
                            Answer = "error"
                        },
                        new Question
                        {
                            Id = 7,
                            Description = "Which of the following preprocessor directive allows generating a level one warning from a specific location in your code in C#?",
                            Option1 = "warning",
                            Option2 = "region",
                            Option3 = "line",
                            Option4 = "error",
                            Answer = "warning"
                        },
                        new Question
                        {
                            Id = 8,
                            Description = "CLR is the .Net equivalent of?",
                            Option1 = "Java Virtual machine",
                            Option2 = "Common Language Runtime",
                            Option3 = "Common Type System",
                            Option4 = "Common Language Specification",
                            Answer = "Java Virtual machine"
                        },
                        new Question
                        {
                            Id = 9,
                            Description = "Abstract class contains _____?",
                            Option1 = "Abstract methods",
                            Option2 = "Non Abstract methods",
                            Option3 = "Both",
                            Option4 = "None",
                            Answer = "Both"
                        },
                        new Question
                        {
                            Id = 10,
                            Description = "The default scope for the members of an interface is _____.",
                            Option1 = "private",
                            Option2 = "public",
                            Option3 = "protected",
                            Option4 = "internal",
                            Answer = "public"
                        },
                        new Question
                        {
                            Id = 11,
                            Description = "Which of the following statements is incorrect about delegate?",
                            Option1 = "Delegates are reference types",
                            Option2 = "Delegates are object-oriented",
                            Option3 = "Delegates are type-safe",
                            Option4 = "Only one can be called using a delegate",
                            Answer = "Only one can be called using a delegate"
                        },
                        new Question
                        {
                            Id = 12,
                            Description = "The space required for structure variables is allocated on the stack.",
                            Option1 = "True",
                            Option2 = "False",
                            Option3 = "Maybe",
                            Option4 = "Can’t say",
                            Answer = "True"
                        },
                        new Question
                        {
                            Id = 13,
                            Description = "The data members of a class by default are?",
                            Option1 = "protected, public",
                            Option2 = "private, public",
                            Option3 = "private",
                            Option4 = "public",
                            Answer = "private"
                        },
                        new Question
                        {
                            Id = 14,
                            Description = "Struct’s data members are ___ by default.",
                            Option1 = "Protected",
                            Option2 = "Public",
                            Option3 = "Private",
                            Option4 = "Default",
                            Answer = "Private"
                        },
                        new Question
                        {
                            Id = 15,
                            Description = "The point at which an exception is thrown is called the _____.",
                            Option1 = "Default point",
                            Option2 = "Invoking point",
                            Option3 = "Calling point",
                            Option4 = "Throw point",
                            Answer = "Throw point"
                        },
                        new Question
                        {
                            Id = 16,
                            Description = "Which of the following keywords is used to refer base class constructor to subclass constructor?",
                            Option1 = "this",
                            Option2 = "static",
                            Option3 = "base",
                            Option4 = "extend",
                            Answer = "base"
                        },
                        new Question
                        {
                            Id = 17,
                            Description = "What is the value returned by function compareTo( ) if the invoking string is less than the string compared?",
                            Option1 = "Zero",
                            Option2 = "A value of less than zero",
                            Option3 = "A value greater than zero",
                            Option4 = "None of the mentioned",
                            Answer = "A value of less than zero"
                        },
                        new Question
                        {
                            Id = 18,
                            Description = "Select the two types of threads mentioned in the concept of multithreading?",
                            Option1 = "Foreground",
                            Option2 = "Background",
                            Option3 = "Only foreground",
                            Option4 = "Both foreground and background",
                            Answer = "Both foreground and background"
                        },
                        new Question
                        {
                            Id = 19,
                            Description = "Which of the following operator can be used to access the member function of a class?",
                            Option1 = ":",
                            Option2 = "::",
                            Option3 = ".",
                            Option4 = "#",
                            Answer = "."
                        },
                        new Question
                        {
                            Id = 20,
                            Description = "Which of the following can be used to define the member of a class externally?",
                            Option1 = ":",
                            Option2 = "::",
                            Option3 = "#",
                            Option4 = "none of the above.",
                            Answer = "::"
                        }
                    }
                },
                new QuestionPool
                {
                    TopicId = (int) TopicList.History,
                    Questions = new List<Question>
                    {
                        new Question
                        {
                            Id = 21,
                            Description = "Qustion 21",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 22,
                            Description = "Qustion 22",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 23,
                            Description = "Qustion 23",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 24,
                            Description = "Qustion 24",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 25,
                            Description = "Qustion 25",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 26,
                            Description = "Qustion 26",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 27,
                            Description = "Qustion 27",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 28,
                            Description = "Qustion 28",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 29,
                            Description = "Qustion 29",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 30,
                            Description = "Qustion 30",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 31,
                            Description = "Qustion 31",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 32,
                            Description = "Qustion 32",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 33,
                            Description = "Qustion 33",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 34,
                            Description = "Qustion 34",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 35,
                            Description = "Qustion 35",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 36,
                            Description = "Qustion 36",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 37,
                            Description = "Qustion 37",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 38,
                            Description = "Qustion 38",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 39,
                            Description = "Qustion 39",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 40,
                            Description = "Qustion 40",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        }
                    }
                },
                new QuestionPool
                {
                    TopicId = (int) TopicList.Maths,
                    Questions = new List<Question>
                    {
                        new Question
                        {
                            Id = 1,
                            Description = "Qustion 1",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 2,
                            Description = "Qustion 2",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 3,
                            Description = "Qustion 3",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 4,
                            Description = "Qustion 4",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 5,
                            Description = "Qustion 5",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 6,
                            Description = "Qustion 6",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 7,
                            Description = "Qustion 7",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 8,
                            Description = "Qustion 8",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 9,
                            Description = "Qustion 9",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 10,
                            Description = "Qustion 10",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 11,
                            Description = "Qustion 11",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 12,
                            Description = "Qustion 12",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 13,
                            Description = "Qustion 13",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 14,
                            Description = "Qustion 14",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 15,
                            Description = "Qustion 15",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 16,
                            Description = "Qustion 16",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 17,
                            Description = "Qustion 17",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 18,
                            Description = "Qustion 18",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 19,
                            Description = "Qustion 19",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 20,
                            Description = "Qustion 20",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        }
                    }
                },
                new QuestionPool
                {
                    TopicId = (int) TopicList.Science,
                    Questions = new List<Question>
                    {
                        new Question
                        {
                            Id = 1,
                            Description = "Qustion 1",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 2,
                            Description = "Qustion 2",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 3,
                            Description = "Qustion 3",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 4,
                            Description = "Qustion 4",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 5,
                            Description = "Qustion 5",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 6,
                            Description = "Qustion 6",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 7,
                            Description = "Qustion 7",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 8,
                            Description = "Qustion 8",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 9,
                            Description = "Qustion 9",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 10,
                            Description = "Qustion 10",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 11,
                            Description = "Qustion 11",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 12,
                            Description = "Qustion 12",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 13,
                            Description = "Qustion 13",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 14,
                            Description = "Qustion 14",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 15,
                            Description = "Qustion 15",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 16,
                            Description = "Qustion 16",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 17,
                            Description = "Qustion 17",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 18,
                            Description = "Qustion 18",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 19,
                            Description = "Qustion 19",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        },
                        new Question
                        {
                            Id = 20,
                            Description = "Qustion 20",
                            Option1 = "Option 1",
                            Option2 = "Option 1",
                            Option3 = "Option 1",
                            Option4 = "Option 1",
                            Answer = "Option 1"
                        }
                    }
                }
            };
        }


        public Quiz CreateQuiz(int topicId)
        {
            var quiz = new Quiz
            {
                TopicId = topicId,
                Questions = GetQuestions(topicId),
                Score = 0
            };

            return quiz;
        }


        public List<Question> GetQuestions(int topicId)
        {
            Random rnd = new();

            var questionPool = _questionPool.FirstOrDefault(t => t.TopicId == topicId);

            var availableQuestions = questionPool.Questions.ToList();
            var selectedQuestions = new List<Question>();

            var minVal = availableQuestions.Select(i => i.Id).Min();
            var maxVal = availableQuestions.Select(i => i.Id).Max();

            if (availableQuestions.Count < _NumberOfQuestions)
            {
                return null;    // There should be minimum 10 questions available
            }

            while (selectedQuestions.Count < _NumberOfQuestions)
            {
                int randomId = rnd.Next(minVal, maxVal);

                var question = availableQuestions.FirstOrDefault(q => q.Id == randomId);

                if (question != null)
                {
                    var tmpQuestion = selectedQuestions.FirstOrDefault(t => t.Id == question.Id);


                    if (tmpQuestion == null)
                    {
                        selectedQuestions.Add(question);
                    }
                }
            }

            return selectedQuestions.ToList();
        }

        public List<Topic> GetTopics()
        {
            var topics = new List<Topic>
            {
                new Topic
                {
                    Id = 1,
                    Name = "General Knowledge"
                },
                new Topic
                {
                    Id = 2,
                    Name = "History"
                },
                new Topic
                {
                    Id = 3,
                    Name = "Maths"
                },
                new Topic
                {
                    Id = 4,
                    Name = "Science"
                }
            };

            return topics;
        }


        public Topic GetTopicById(int topicId)
        {
            var topics = GetTopics();

            return topics.Find(t => t.Id == topicId);
        }
    }
}
