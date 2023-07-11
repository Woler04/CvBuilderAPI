using System.ComponentModel.DataAnnotations;

namespace CvBuilderAPI.Models
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public string Level { get; set; }


        public ICollection<Resume?> Resumes { get; set; }

        public Language()
        {
            Resumes = new List<Resume?>();
        }
    }
}
