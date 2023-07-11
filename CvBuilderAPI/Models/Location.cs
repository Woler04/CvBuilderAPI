using System.ComponentModel.DataAnnotations;

namespace CvBuilderAPI.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public ICollection<Resume?> Resumes { get; set; }

        public Location()
        {
            Resumes = new List<Resume?>();
        }
    }
}
