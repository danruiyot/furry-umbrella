using Microsoft.EntityFrameworkCore;
using MyQuiz.Models;

namespace MyQuiz.Data
{
    public class QuestionsContext : DbContext
    {
        public QuestionsContext (DbContextOptions<QuestionsContext> options)
            : base(options)
        {
        }

        // public DbSet<Question> Question { get; set; }
        // public DbSet<Answers> Answers { get; set; }

        public DbSet<MyQuiz.Models.Question> Question { get; set; }
        public DbSet<MyQuiz.Models.Results> Results { get; set; }
        // dotnet aspnet-codegenerator controller -name QuestionsController -m Question -dc QuestionsContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

    }
}