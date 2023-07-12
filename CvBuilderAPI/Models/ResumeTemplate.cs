using System.ComponentModel.DataAnnotations.Schema;

namespace CvBuilderAPI.Models
{
    public class ResumeTemplate
    {
        [ForeignKey("Template")]
        public int? TemplateId { get; set; }
        public Template? Template { get; set; }

        [ForeignKey("Resume")]
        public int? ResumeId { get; set; }
        public Resume? Resume { get; set; }
    }
}
