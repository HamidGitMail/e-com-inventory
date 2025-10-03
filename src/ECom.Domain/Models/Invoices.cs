using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("Invoices")]
    public class Invoices
    {
        [Key]
        public int InvoiceNumber { get; set; }

        [StringLength(50)]
        public string Account_ID { get; set; }

        public decimal? TotalAmount { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? VATAmount { get; set; }

        public decimal? InvoiceAmount { get; set; }

        public decimal? Balance { get; set; }

        public bool? Paid { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public string InvMemo { get; set; }

        public DateTime? LastUpdated { get; set; }
    }
}