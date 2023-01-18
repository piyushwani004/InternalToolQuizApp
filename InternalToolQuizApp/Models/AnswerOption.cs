using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternalToolQuizApp.Models
{
    public class AnswerOption
    {

        //primary key constraints
        [Key]
        //The unique id to identify the quiz answer
        public int Id { get; set; }

        public string AnswerText { get; set; }

        //Flag to identify whether the answer is correct
        public bool IsAnswerCorrect { get; set; }

        //Flag to identify whether the answer is active
        public int Active { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }


        //foriegn key constraints relation with Question class primary variable[id].
        //The question id to identify the parent question
        public int QuestionId { get; set; }
        [ForeignKey("Id")]
        public virtual Question Questions { get; set; }


        //foriegn key constraints relation with Quiz class primary variable[id].
        //The quiz id to identify the parent test/quiz
        public int QuizId { get; set; }
        [ForeignKey("Id")]
        public virtual Quiz Quizes { get; set; }

    }
}
