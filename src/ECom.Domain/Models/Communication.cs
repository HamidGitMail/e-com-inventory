using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("Communication")]
    public class Communication
    {
        [Key]
        public int Communication_ID { get; set; }
        public int Address_ID { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Home { get; set; }
        public string WorkContact { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Skype { get; set; }
        public string Facebook { get; set; }
        public string Web { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}