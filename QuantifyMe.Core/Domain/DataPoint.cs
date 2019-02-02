using System;

namespace QuantifyMe.Core.Domain
{
    public class DataPoint
    {
        public DateTimeOffset DateTime { get; set; }

        public decimal  Value { get; set; }
    }
}
