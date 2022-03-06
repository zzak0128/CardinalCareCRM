using System;
namespace CardinalCare.Model
{
    public class EnrollmentStatus
    {
        public int EnrollmentId { get; set; }
        public Child Child { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public EnrollmentType EnrollmentType { get; set; }
    }
}
