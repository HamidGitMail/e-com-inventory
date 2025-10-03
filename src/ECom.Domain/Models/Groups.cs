using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("Groups")]
    public class Groups
    {
        [Key]
        public int ID { get; set; }

        [StringLength(255)]
        public string GroupName { get; set; }

        public string Description { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}