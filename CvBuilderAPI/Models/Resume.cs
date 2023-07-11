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
        public ICollection<Skill?> Skills { get; set; }
        public ICollection<Location?> Locations { get; set; }
        public ICollection<Certificate?> Certificates { get; set; }
        public ICollection<Education?> Educations { get; set; }
        public ICollection<Language?> Languages { get; set; }
        public ICollection<Template?> Templates { get; set; }



        public Resume()
        {
            Skills = new List<Skill?>();
            Locations = new List<Location?>();
            Certificates = new List<Certificate?>();
            Educations = new List<Education?>();
            Languages = new List<Language?>();
            Templates = new List<Template?>();
        }

    }
}
