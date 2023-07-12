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
        public ICollection<Skill?> Skills { get; set; } = new List<Skill>();
        public ICollection<LocationResume?> Locations { get; set; } = new List<LocationResume>();
        public ICollection<Certificate?> Certificates { get; set; } = new List<Certificate>();
        public ICollection<Education?> Educations { get; set; } = new List<Education>();
        public ICollection<LanguageResume?> Languages { get; set; } = new List<LanguageResume>();
        public ICollection<ResumeTemplate?> Templates { get; set; } = new List<ResumeTemplate>();

    }
}
