using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CardinalCare.Domain.Interfaces;

namespace CardinalCare.Domain
{
    public class Workplace : ISingleSelect
    {
        [Key]
        public int WorkplaceId { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(150)]
        public string City { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [NotMapped]
        public string Title { get; set; }

        public int GetId()
        {
            return WorkplaceId;
        }

        //public Workplace()
        //{
        //    Title = $"{Name} @ {City}";
        //}
    }
}
