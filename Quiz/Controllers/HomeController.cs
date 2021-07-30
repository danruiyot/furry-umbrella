using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

using MyQuiz.Data;

using MyQuiz.Helpers;
using MyQuiz.Models;

using static MyQuiz.Helpers.QuizRepository;

namespace MyQuiz.Controllers
{
    public class HomeController : Controller
    {
        private readonly QuestionsContext _context;

        public HomeController(QuestionsContext context)
        {
            _context = context;
        }

        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
            
        // }

        private void LoadQuizData()
        {
            var quizRepo            = new QuizRepository();
            var quiz                = quizRepo.CreateQuiz((int)TopicList.GeneralKnowledge);
            var questions           = quiz.Questions;
            var questionViewModel   = new List<QuestionViewModel>();
            int srNo                = 0;

            foreach (var question in questions)
            {
                srNo += 1;

                questionViewModel.Add(
                new QuestionViewModel
                {
                    SerialNumber    = srNo,
                    Id              = question.Id,
                    Description     = question.Description,
                    Option1         = question.Option1,
                    Option2         = question.Option2,
                    Option3         = question.Option3,
                    Option4         = question.Option4,
                    SelectedOption  = "",
                    Answer          = question.Answer
                });
            }

            var quizVewModel  = new QuizVewModel
            {
                PageIndex   = 1,
                Questions   = questionViewModel,
                TotalPages  = questionViewModel.Count
            };

            SessionHelper.SetObjectAsJson(HttpContext.Session, "quiz", quizVewModel);
        }

       
        public IActionResult Index(int pageNumber = 1)
        {
            return View(this.GetQuizViewModel(pageNumber));
        }

        public IActionResult PastResults()
        {
            return View();
        }



        private QuizVewModel GetQuizViewModel(int currentPage)
        {
            int pageSize = 1;

            var quizViewModel = SessionHelper.GetObjectFromJson<QuizVewModel>(HttpContext.Session, "quiz");

            if (quizViewModel == null)
            {
                LoadQuizData();
                quizViewModel = SessionHelper.GetObjectFromJson<QuizVewModel>(HttpContext.Session, "quiz");
            }

            var count = quizViewModel.Questions.Count;

            quizViewModel.Questions = quizViewModel.Questions
                                        .Skip((currentPage - 1) * pageSize)
                                        .Take(pageSize).ToList();

            quizViewModel.TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            quizViewModel.PageIndex = currentPage;

            return quizViewModel;
        }

        [HttpPost]
        public IActionResult Answers(IFormCollection collection)
        {
            
            int question_id = Int32.Parse(collection["question_id"]);
            string answer = collection["answer"];
            string correct_answer = collection["correctANser"];
            int next = Int32.Parse(collection["next"]);
            Console.WriteLine("the question_id value " +collection["question_id"]);
            bool is_correct = false;
            if (answer == correct_answer) 
            {
                is_correct = true;
                
            }
            string storeValue = question_id+" "+is_correct;

            HttpContext.Session.SetString("question_id"+question_id,storeValue);

            // var fileAttachmentList = new List<FileAttachement>();


            // var fileAttachement = new FileAttachement {Title = "My title", FileName = "My Name"};
            if (next >10) 
            {
                 return RedirectToAction("Submit");
                
            }
            
            return RedirectToAction("Index", new {pageNumber= next});
        }



        public IActionResult Submit()
        {
            int correct = 0;

            var requiredKeys = HttpContext.Session.Keys.Where(x=>x.StartsWith("question_id"));
            foreach (var key in requiredKeys)
            {
                string sessData = HttpContext.Session.GetString(key);
                
                char[] whitespace = new char[] { ' ', '\t' };
                string[] results = sessData.Split(whitespace);
                if (results[1] == "True") 
                {
                    correct ++;
                    
                }


                // Console.WriteLine(results[0]);
                // Console.WriteLine(correct);
                // Console.WriteLine(results[1]);
            } 
            string corrects = correct+"/10";

            Results res = new Results();
            res.result = corrects;
            res.dateTimes = DateTime.Now.ToString("MM/dd/yyyy H:mm");
            string message = "Unfortunately you did not pass the test. Please try again later";
            if (correct >= 8) 
            {
                message = "You have successfully passed the test";
                                
            }
            HttpContext.Session.SetString("message",message);

            HttpContext.Session.SetString("correct_answers",corrects);

            _context.Add(res);
            _context.SaveChanges();
            
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
