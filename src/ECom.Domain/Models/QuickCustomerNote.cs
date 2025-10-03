using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("QuickCustomerNote")]
    public class QuickCustomerNote
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        public string Account_ID { get; set; }

        public string Note { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}