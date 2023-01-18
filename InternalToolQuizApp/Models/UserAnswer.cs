using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternalToolQuizApp.Models
{
    public class UserAnswer
    {
        //primary key constraints
        [Key]
        public int Id { get; set; }

        //Flag to identify whether the answer is active
        public int Active { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string UserAnswerText { get; set; }

        //foriegn key constraints relation with QuizPerformance class primary variable[id].
        //The Quiz Performance Id to identify the quiz attempt.
        public int QuizPerformanceId { get; set; }
        [ForeignKey("Id")]
        public virtual QuizPerformance QuizPerformances { get; set; }

        //foriegn key constraints relation with Question class primary variable[id].
        public int QuestionId { get; set; }
        [ForeignKey("Id")]
        public virtual Question Questions { get; set; }

        //foriegn key constraints relation with AnswerOption class primary variable[id].
        //The answer id to identify the quiz answer
        public int AnswerId { get; set; }
        [ForeignKey("Id")]
        public virtual AnswerOption AnswerOptions { get; set; }

    }
}
