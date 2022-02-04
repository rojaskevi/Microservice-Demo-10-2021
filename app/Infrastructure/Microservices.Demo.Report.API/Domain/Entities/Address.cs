using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.Infrastructure.Data.Entities
{
    public partial class Address
    {
        public Address(string country, string zipCode, string city, string street)
        {
            Country = country;
            ZipCode = zipCode;
            City = city;
            Street = street;
        }
    }
}
