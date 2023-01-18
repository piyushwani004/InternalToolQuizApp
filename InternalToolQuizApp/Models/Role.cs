using System.ComponentModel.DataAnnotations;

namespace InternalToolQuizApp.Models
{
    public class Role
    {
        //primary key constraints
        [Key]
        public int Id { get; set; }

        public string RoleName { get; set; }

    }
}
