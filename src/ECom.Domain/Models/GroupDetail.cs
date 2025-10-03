using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("GroupDetail")]
    public class GroupDetail
    {
        [Key]
        public int ID { get; set; }

        public int? Group_ID { get; set; }

        [StringLength(255)]
        public string Account_ID { get; set; }

        [StringLength(255)]
        public string Role { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}