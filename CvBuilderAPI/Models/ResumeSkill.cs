using System.ComponentModel.DataAnnotations.Schema;

namespace CvBuilderAPI.Models
{
    public class ResumeSkill
    {
        [ForeignKey("Language")]
        public int? SkillId { get; set; }
        public Skill? Skill { get; set; }

        [ForeignKey("Resume")]
        public int? ResumeId { get; set; }
        public Resume? Resume { get; set; }
    }
}
