﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Microservices.Demo.Report.API.Infrastructure.Data.Entities
{
    public partial class Address
    {
        public Address()
        {
            PolicyHolders = new HashSet<PolicyHolder>();
        }

        public int AddressId { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

        public virtual ICollection<PolicyHolder> PolicyHolders { get; set; }
    }
}