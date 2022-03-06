using System;
using System.ComponentModel.DataAnnotations;

namespace CardinalCare.Model
{
    public class Guardian
    {
        [Key]
        public int GuardianId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        public Address Address { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public Workplace Workplace { get; set; }
    }
}
