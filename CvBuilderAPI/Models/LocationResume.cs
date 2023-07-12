using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CvBuilderAPI.Models
{
    public class LocationResume
    {
        [ForeignKey("Location")]
        public int? LocationId { get; set; }
        public Location? Location { get; set; }

        [ForeignKey("Resume")]
        public int? ResumeId { get; set; }
        public Resume? Resume { get; set; }


    }
}
