using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("ItemList")]
    public class ItemList
    {
        [Key]
        public int ID { get; set; }

        [StringLength(255)]
        public string ItemName { get; set; }

        [StringLength(100)]
        public string SKU { get; set; }

        public string Description { get; set; }

        public decimal? MRP { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}