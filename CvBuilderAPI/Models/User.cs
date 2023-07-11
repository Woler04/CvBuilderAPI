using System.ComponentModel.DataAnnotations;

namespace CvBuilderAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Resume?> Resumes { get; set; }

        public User()
        {
            Resumes = new List<Resume>();
        }
    }
}