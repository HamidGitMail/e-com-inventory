using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("CustomerCreditNote")]
    public class CustomerCreditNote
    {
        [Key]
        public int InvoiceNumber { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? VATAmount { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public decimal? Balance { get; set; }
        public bool? Paid { get; set; }
        [StringLength(50)]
        public string Account_ID { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string Client { get; set; }
        public string InvMemo { get; set; }
        public DateTime? Lastupdated { get; set; }
    }
}