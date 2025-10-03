using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("BillPayments")]
    public class BillPayments
    {
        [Key]
        public int BillPayment_ID { get; set; }
        public string Payee_ID { get; set; }
        public decimal? Amount { get; set; }
        public int? PayMethod { get; set; }
        public bool? Credit { get; set; }
        public decimal? CreditAmount { get; set; }
        public string PaymentMemo { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string ReceiptNo { get; set; }
        public string LastUpdated { get; set; }
    }
}