using System;
using System.Collections.Generic;

namespace CardinalCare.Model
{
    public class Invoice
    { 
        public int InvoiceId { get; set; }
        public double AmountDue { get; set; }
        public double AmountPaid { get; set; }
        public bool IsPaidInFull { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime DatePaid { get; set; }

        public List<Child> Children { get; set; }
        public List<Guardian> Guardians { get; set; }
    }
}
