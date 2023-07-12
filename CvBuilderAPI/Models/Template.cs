using System.ComponentModel.DataAnnotations;

namespace CvBuilderAPI.Models
{
    public class Template
    {
        [Key]
        public int TemplateId { get; set; }
        public string TemplateName { get; set; }
        public string TemplateFilePath { get; set; }

        public ICollection<LanguageResume?> Resumes { get; set; } = new List<LanguageResume?>();
    }
}
