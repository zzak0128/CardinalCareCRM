using System;
namespace CardinalCare.Model
{
    public class Child
    {
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string DietRestrictions { get; set; }
        public string Allergies { get; set; }

        public Child()
        {
        }
    }
}
