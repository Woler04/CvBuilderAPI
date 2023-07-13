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
        public List<ResumeSkill?> Skills { get; set; } = new List<ResumeSkill>();
        public List<LocationResume?> Locations { get; set; } = new List<LocationResume>();
        public List<Certificate?> Certificates { get; set; } = new List<Certificate>();
        public List<Education?> Educations { get; set; } = new List<Education>();
        public List<LanguageResume?> Languages { get; set; } = new List<LanguageResume>();
        public List<ResumeTemplate?> Templates { get; set; } = new List<ResumeTemplate>();

    }
}
