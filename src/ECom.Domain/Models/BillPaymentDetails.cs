using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("BillPaymentDetails")]
    public class BillPaymentDetails
    {
        [Key]
        public int BillPaymentDetail_ID { get; set; }
        public int? BillPayment_ID { get; set; }
        public string BillNumber { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? BillBalance { get; set; }
    }
}