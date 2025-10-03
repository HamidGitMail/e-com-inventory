using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("CustomerItemControl")]
    public class CustomerItemControl
    {
        [Key]
        public int ID { get; set; }
        public string Account_ID { get; set; }
        public string ItemName { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}