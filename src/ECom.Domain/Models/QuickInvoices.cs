using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("QuickInvoices")]
    public class QuickInvoices
    {
        [Key]
        public int QuickInvoice_ID { get; set; }

        [StringLength(50)]
        public string Account_ID { get; set; }

        public decimal? TotalAmount { get; set; }

        public DateTime? InvoiceDate { get; set; }
    }
}