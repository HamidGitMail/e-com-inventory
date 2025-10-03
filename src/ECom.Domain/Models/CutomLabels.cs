using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("CutomLabels")]
    public class CutomLabels
    {
        [Key]
        [StringLength(255)]
        public string LabelKey { get; set; }
        public string LabelValue { get; set; }
    }
}