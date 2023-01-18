using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternalToolQuizApp.Models
{
    public class QuizMeta
    {
        //primary key constraints
        [Key]
        //The unique id to identify the quiz meta.
        public int Id { get; set; }

        //The key identifying the meta
        public string Key { get; set; }

        public string content { get; set; }

        //foriegn key constraints relation with Quiz class primary variable[id].
        //The quiz id to identify the parent test/quiz
        public int quizId { get; set; }
        [ForeignKey("Id")]
        public virtual Quiz Quizes { get; set; }

    }
}
