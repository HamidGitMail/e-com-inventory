using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("CustomLists")]
    public class CustomLists
    {
        [Key]
        [StringLength(100)]
        public string ListName { get; set; }
        [Key]
        [StringLength(100)]
        public string Value { get; set; }
    }
}