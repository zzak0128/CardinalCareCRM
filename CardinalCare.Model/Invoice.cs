using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CardinalCare.Domain
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        [DataType(DataType.Currency)]
        public double AmountDue { get; set; }
        [DataType(DataType.Currency)]
        public double AmountPaid { get; set; }
        public bool IsPaidInFull { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime DatePaid { get; set; }

        public List<Child> Children { get; set; }
        public List<Guardian> Guardians { get; set; }
    }
}
