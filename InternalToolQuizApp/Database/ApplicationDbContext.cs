using InternalToolQuizApp.Models;
using Microsoft.EntityFrameworkCore;

namespace InternalToolQuizApp.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<AnswerOption> answerOptions { get; set; }

        public DbSet<Question> questions { get; set; }

        public DbSet<Quiz> quizzes { get; set; }

        public DbSet<QuizMeta> quizMetas { get; set; }

        public DbSet<QuizPerformance> quizPerformances { get; set; }

        public DbSet<Role> roles { get; set; }

        public DbSet<User> users { get; set; }

        public DbSet<UserAnswer> userAnswers { get; set; }

    }
}
