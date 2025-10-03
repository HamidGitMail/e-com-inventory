using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("DistributorCreditNote")]
    public class DistributorCreditNote
    {
        [Key]
        [StringLength(50)]
        public string BillNumber { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? VATAmount { get; set; }
        public decimal? BillAmount { get; set; }
        public string Account_ID { get; set; }
        public decimal? Balance { get; set; }
        public bool? Paid { get; set; }
        public DateTime? BillDate { get; set; }
        public string BillMemo { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}