using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("ExpenseLog")]
    public class ExpenseLog
    {
        [Key]
        public int ID { get; set; }
        public string Expense { get; set; }
        public string Description { get; set; }
        public DateTime? EntryDate { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Markup { get; set; }
        public decimal? Rate { get; set; }
        public double? QTY { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? Lastupdated { get; set; }
    }
}