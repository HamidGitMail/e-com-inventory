using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("InvoiceDetails")]
    public class InvoiceDetails
    {
        [Key]
        [StringLength(100)]
        public string InvoiceDetailID { get; set; }

        public int? InvoiceNumber { get; set; }

        [StringLength(255)]
        public string ItemName { get; set; }

        public string Pack { get; set; }

        public double? QTY { get; set; }

        public decimal? MRP { get; set; }

        public DateTime? EXPDate { get; set; }

        public decimal? Rate { get; set; }

        public decimal? Discount { get; set; }

        public decimal? VAT { get; set; }

        public decimal? Amount { get; set; }
    }
}