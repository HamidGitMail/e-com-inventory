using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("StoreReconcilation")]
    public class StoreReconcilation
    {
        [Key]
        public int ID { get; set; }

        public int? StoreID { get; set; }

        public DateTime? ReconDate { get; set; }

        public decimal? Expected { get; set; }

        public decimal? Actual { get; set; }

        public decimal? Difference { get; set; }
    }
}