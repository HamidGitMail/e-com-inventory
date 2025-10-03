using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("FilterType")]
    public class FilterType
    {
        [Key]
        public int ID { get; set; }

        [StringLength(255)]
        public string TypeName { get; set; }

        public string Description { get; set; }
    }
}