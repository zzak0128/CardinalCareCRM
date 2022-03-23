using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CardinalCare.Domain.Interfaces;

namespace CardinalCare.Domain
{
    public class Guardian: IMultiListSelectable
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

        [NotMapped]
        public string Title { get; set; }

        public Guardian()
        {
            Title = $"{FirstName} {LastName}";
        }
    }
}
