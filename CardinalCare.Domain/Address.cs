﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CardinalCare.Domain.Attributes;
using CardinalCare.Domain.Interfaces;

namespace CardinalCare.Domain
{
    public class Address : IMultiListSelectable, ISingleSelect
    {
        [Key]
        public int AddressId { get; set; }
        [StringLength(250)]
        [Column("Street1")]
        public string Title { get; set; }
        [StringLength(100)]
        public string Street2 { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(2, ErrorMessage = "State should have 2 characters")]
        public string State { get; set; }
        [StringLength(10,ErrorMessage = "Zip Code should have 10 characters or less")]
        public string ZipCode { get; set; }

        public int GetId()
        {
            return AddressId;
        }
    }
}