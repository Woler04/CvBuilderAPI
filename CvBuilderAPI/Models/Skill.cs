using System.ComponentModel.DataAnnotations;

namespace CvBuilderAPI.Models
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        public string SkillName { get; set; }

        public ICollection<Resume> Resumes { get; set; }

        public Skill()
        {
            Resumes = new List<Resume>();
        }
    }
}

//Update-Database "20230711082803_skills"
