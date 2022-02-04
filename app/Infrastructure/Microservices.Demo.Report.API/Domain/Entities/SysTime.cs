using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.Infrastructure.Data.Entities
{
    public class SysTime
    {
        public static Func<DateTime> CurrentTimeProvider { get; set; } = () => DateTime.Now;
        public static DateTime CurrentTime => CurrentTimeProvider();
    }
}
