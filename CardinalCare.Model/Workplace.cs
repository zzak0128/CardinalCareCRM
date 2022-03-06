using System;
using System.ComponentModel.DataAnnotations;

namespace CardinalCare.Model
{
    public class Workplace
    {
        [Key]
        public int WorkplaceId { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(150)]
        public string City { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
