using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CvBuilderAPI.Models
{
    public class Certificate
    {
        [Key]
        public int CertificateId { get; set; }
        public string CertificateName { get; set; }
        public string IssuingOrganization { get; set; }
        public DateTime IssueDate { get; set; }
        [ForeignKey("Resume")]
        public int ResumeId { get; set; }
    }
}
