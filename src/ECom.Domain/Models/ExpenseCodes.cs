using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("ExpenseCodes")]
    public class ExpenseCodes
    {
        [Key]
        [StringLength(255)]
        public string Expense { get; set; }
        public string Description { get; set; }
        public decimal? Rate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}