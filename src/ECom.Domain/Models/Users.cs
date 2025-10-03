using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        [StringLength(100)]
        public string User_ID { get; set; }

        [StringLength(255)]
        public string Username { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? LastUpdated { get; set; }
    }
}