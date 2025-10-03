using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("QuickBills")]
    public class QuickBills
    {
        [Key]
        public int QuickBill_ID { get; set; }

        [StringLength(50)]
        public string Account_ID { get; set; }

        public decimal? TotalAmount { get; set; }

        public DateTime? BillDate { get; set; }
    }
}