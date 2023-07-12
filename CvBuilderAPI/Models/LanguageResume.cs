using System.ComponentModel.DataAnnotations.Schema;

namespace CvBuilderAPI.Models
{
    public class LanguageResume
    {
        [ForeignKey("Language")]
        public int? LanguageId { get; set; }
        public Language? Language { get; set; }

        [ForeignKey("Resume")]
        public int? ResumeId { get; set; }
        public Resume? Resume { get; set; }
    }
}
