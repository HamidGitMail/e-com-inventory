using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("Settings")]
    public class Settings
    {
        [Key]
        public int ID { get; set; }

        [StringLength(255)]
        public string Key { get; set; }

        public string Value { get; set; }

        public string Description { get; set; }
    }
}