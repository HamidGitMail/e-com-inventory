using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Domain.Models
{
    [Table("AddressTemplate")]
    public class AddressTemplate
    {
        [Key]
        [StringLength(255)]
        public string AddressName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [StringLength(255)]
        public string Country { get; set; }
        [StringLength(255)]
        public string Zip { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
    }
}