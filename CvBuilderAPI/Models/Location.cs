using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace CvBuilderAPI.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public ICollection<LocationResume?> Resumes { get; set; } = new List<LocationResume>();
    }
}
