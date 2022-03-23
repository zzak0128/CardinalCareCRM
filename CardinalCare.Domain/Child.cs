using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CardinalCare.Domain
{
    public class Child
    {
        [Key]
        public int ChildId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string MidName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        [StringLength(999)]
        public string DietRestrictions { get; set; }
        [StringLength(999)]
        public string Allergies { get; set; }
        public VaccinationFile VacinationFile { get; set; }
        public Address Address { get; set; }

        
        public List<Guardian> Guardians { get; set; }
    }
}
