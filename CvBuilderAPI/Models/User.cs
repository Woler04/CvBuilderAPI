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

        public virtual List<Resume?> Resumes { get; set; } = new List<Resume?>();
    }
}