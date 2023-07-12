using System.ComponentModel.DataAnnotations;

namespace CvBuilderAPI.Models
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        public string SkillName { get; set; }

        public List<ResumeSkill?> Resumes { get; set; } = new List<ResumeSkill?>();
    }
}
