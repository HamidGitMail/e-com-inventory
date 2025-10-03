using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("Accounts")]
    public class Accounts
    {
        [Key]
        [StringLength(50)]
        public string Account_ID { get; set; }
        [StringLength(255)]
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Parent { get; set; }
        [StringLength(255)]
        public string GroupID { get; set; }
        public bool? IsCustomer { get; set; }
        [StringLength(255)]
        public string Website { get; set; }
        public string AccountMemo { get; set; }
        public decimal? RetainerAvailable { get; set; }
        public decimal? CreditAvailable { get; set; }
        public bool? LockStatus { get; set; }
        public DateTime? LockDate { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdated { get; set; }
        [StringLength(255)]
        public string LicenseNumber { get; set; }
        [StringLength(255)]
        public string GSTTINNumber { get; set; }
        [StringLength(255)]
        public string CSTNumber { get; set; }
        public decimal? Balance { get; set; }
    }
}