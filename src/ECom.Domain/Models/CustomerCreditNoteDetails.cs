using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("CustomerCreditNoteDetails")]
    public class CustomerCreditNoteDetails
    {
        [Key]
        [StringLength(100)]
        public string InvoiceDetailID { get; set; }
        public int? InvoiceNumber { get; set; }
        [StringLength(50)]
        public string ItemName { get; set; }
        public string Pack { get; set; }
        public double? QTY { get; set; }
        public int? TotalUnits { get; set; }
        public string Batch { get; set; }
        public decimal? MRP { get; set; }
        public DateTime? EXPDate { get; set; }
        public decimal? Discount { get; set; }
        public decimal? VAT { get; set; }
        public decimal? Amount { get; set; }
    }
}