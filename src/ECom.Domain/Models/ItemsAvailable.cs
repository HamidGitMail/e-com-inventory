using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("ItemsAvailable")]
    public class ItemsAvailable
    {
        [Key]
        public int ID { get; set; }

        [StringLength(255)]
        public string ItemName { get; set; }

        public int? TotalUnits { get; set; }

        public int? AvailableUnits { get; set; }

        public string Batch { get; set; }

        public DateTime? EXPDate { get; set; }

        public decimal? MRP { get; set; }
    }
}