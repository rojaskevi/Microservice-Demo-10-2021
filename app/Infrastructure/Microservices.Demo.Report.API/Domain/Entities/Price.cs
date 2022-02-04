using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.Domain.Entities
{
    public class Price
    {
        public Dictionary<string, decimal> CoverPrices;        

        public Price(Dictionary<string, decimal> coverPrices)
        {
            CoverPrices = coverPrices;
        }
    }
}
