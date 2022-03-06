using System;
namespace CardinalCare.Model
{
    public class Guardian
    {
        public int GuardianId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }

        public Workplace Workplace { get; set; }
    }
}
