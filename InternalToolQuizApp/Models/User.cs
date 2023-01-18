using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternalToolQuizApp.Models
{
    public class User
    {
        //primary key constraints
        [Key]
        //The unique id to identify the user
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        //This Host flag to identify whether the user can host a quiz
        public int Host { get; set; }

        public string mobile { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime RegisteredAt { get; set; }

        //It can be used to identify the last login of the user
        public DateTime LastLogin { get; set; }

        public string intro { get; set; }

        public string profile { get; set; }

        //foriegn key constraints relation with Role class primary variable[id].
        public int RoleId { get; set; }
        [ForeignKey("Id")]
        public virtual Role Roles { get; set; }

    }
}
