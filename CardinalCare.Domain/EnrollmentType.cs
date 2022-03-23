using System.ComponentModel.DataAnnotations;

namespace CardinalCare.Domain
{
    public class EnrollmentType
    {
        [Key]
        public int EnrollmentTypeId { get; set; }
        [StringLength(100, ErrorMessage = "Please keep Type under 100 characters.")]
        public string Title { get; set; }
        [DataType(DataType.Currency)]
        public double BillAmount { get; set; }
    }
}