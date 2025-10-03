using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("DistributorItemControl")]
    public class DistributorItemControl
    {
        [Key]
        public int ID { get; set; }
        public string Account_ID { get; set; }
        public string ItemName { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}