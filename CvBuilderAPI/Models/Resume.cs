using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CvBuilderAPI.Models
{
    public class Resume
    {
        [Key]
        public int ResumeId { get; set; }
        public string Title { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastModifiedTime { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }
        public virtual User? User { get; set; }
        public ICollection<Skill> Skills { get; set; }

        public Resume()
        {
            Skills = new List<Skill>();
        }

    }
}
