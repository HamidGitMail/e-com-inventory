using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("Filters")]
    public class Filters
    {
        [Key]
        public int ID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public int? FilterType_ID { get; set; }

        public string Value { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? LastUpdated { get; set; }
    }
}