using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("Payments")]
    public class Payments
    {
        [Key]
        public int Payment_ID { get; set; }

        [StringLength(50)]
        public string Payee_ID { get; set; }

        public decimal? Amount { get; set; }

        public int? PayMethod { get; set; }

        public DateTime? PaymentDate { get; set; }

        [StringLength(100)]
        public string ReceiptNo { get; set; }

        public DateTime? LastUpdated { get; set; }
    }
}