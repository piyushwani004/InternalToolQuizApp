using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternalToolQuizApp.Models
{
    public class Question
    {
        //primary key constraints
        [Key]
        public int Id { get; set; }

        public string QuestionText { get; set; }

        //The type of question. The type can be a single choice(Yes/No), multiple-choice or select.
        public string Type { get; set; }

        //Flag to identify whether the question is active
        public int Active { get; set; }

        //The level of the question to identify whether it's easy, medium, or difficult
        public string Level { get; set; }

        //The score of an individual question
        public int Score { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public int QuizId { get; set; }
        [ForeignKey("Id")]
        public virtual Quiz Quizes { get; set; }
    }
}
