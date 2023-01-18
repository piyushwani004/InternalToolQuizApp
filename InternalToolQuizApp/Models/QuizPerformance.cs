using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternalToolQuizApp.Models
{
    public class QuizPerformance
    {
        //primary key constraints
        [Key]
        public int Id { get; set; }

        //It can be enrolled, started, paused, finished, declared
        public string Status { get; set; }

        //The total score obtained by the user
        public decimal Score { get; set; }

        public int Published { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime StartedAt { get; set; }

        public DateTime FinishedAt { get; set; }

        public string Content { get; set; }

        //foriegn key constraints relation with User class primary variable[id].
        public int UserId { get; set; }
        [ForeignKey("Id")]
        public virtual User Users { get; set; }

        //foriegn key constraints relation with Quiz class primary variable[id].
        public int QuizId { get; set; }
        [ForeignKey("Id")]
        public virtual Quiz Quizes { get; set; }

    }
}
