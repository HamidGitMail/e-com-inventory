using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("Bills")]
    public class Bills
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string BillNumber { get; set; }
        [Key]
        [Column(Order = 1)]
        public string Account_ID { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? VATAmount { get; set; }
        public decimal? BillAmount { get; set; }
        public int? BillType { get; set; }
        public decimal? Balance { get; set; }
        public bool? Paid { get; set; }
        public DateTime? BillDate { get; set; }
        public string BillMemo { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}