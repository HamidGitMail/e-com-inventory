using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("PaymentDetails")]
    public class PaymentDetails
    {
        [Key]
        public int ID { get; set; }

        public int? Payment_ID { get; set; }

        [StringLength(255)]
        public string Method { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(10)]
        public string Currency { get; set; }

        public DateTime? PaymentDate { get; set; }
    }
}