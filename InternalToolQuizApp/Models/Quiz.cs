using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternalToolQuizApp.Models
{
    public class Quiz
    {
        //primary key constraints
        [Key]
        //The unique id to identify the quiz
        public int Id { get; set; }

        public string Title { get; set; }

        //The meta title to be used for browser title and SEO
        public string MetaTitle { get; set; }

        //The slug to form the URL
        public string Slug { get; set; }

        public string Summary { get; set; }

        //The type to distinguish between the test and the quiz
        public int Type { get; set; }

        //The total score of the quiz.
        public int Score { get; set; }

        //It can be used to identify whether the test/quiz is publicly available
        public int Published { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime PublishedAt { get; set; }

        public DateTime StartsAt { get; set; }

        public DateTime EndsAt { get; set; }

        public string Content { get; set; }

        //foriegn key constraints relation with User class primary variable[id].
        //The host id to identify the quiz host.
        public int HostId { get; set; }
        [ForeignKey("Host")]
        public virtual User Users { get; set; }

    }
}
