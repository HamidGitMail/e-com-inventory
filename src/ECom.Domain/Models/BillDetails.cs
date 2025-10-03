using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("BillDetails")]
    public class BillDetails
    {
        [Key]
        [StringLength(100)]
        public string BillDetailID { get; set; }
        [StringLength(50)]
        public string BillNumber { get; set; }
        [StringLength(50)]
        public string itemName { get; set; }
        public string Pack { get; set; }
        public double? QTY { get; set; }
        public int? TotalUnits { get; set; }
        public string Batch { get; set; }
        public decimal? MRP { get; set; }
        public DateTime? EXPDate { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Discount { get; set; }
        public decimal? VAT { get; set; }
        public decimal? Amount { get; set; }
        public int? Free { get; set; }
        public string HSNCODE { get; set; }
    }
}