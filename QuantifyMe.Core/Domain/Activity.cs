using System;

namespace QuantifyMe.Core.Domain
{
    public class Activity
    {
        public string Description { get; set; }
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset End { get; set; }
    }
}
