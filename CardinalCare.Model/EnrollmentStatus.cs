using System;
using System.ComponentModel.DataAnnotations;

namespace CardinalCare.Model
{
    public class EnrollmentStatus
    {
        [Key]
        public int EnrollmentId { get; set; }
        public Child Child { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public EnrollmentType EnrollmentType { get; set; }
    }
}
