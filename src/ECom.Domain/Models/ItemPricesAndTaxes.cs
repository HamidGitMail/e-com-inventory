using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("ItemPricesAndTaxes")]
    public class ItemPricesAndTaxes
    {
        [Key]
        public int ID { get; set; }

        [StringLength(255)]
        public string ItemName { get; set; }

        public decimal? Price { get; set; }

        public decimal? TaxRate { get; set; }

        public DateTime? EffectiveDate { get; set; }
    }
}