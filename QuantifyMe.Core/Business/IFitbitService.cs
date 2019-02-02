using QuantifyMe.Core.Domain;
using System;
using System.Threading.Tasks;

namespace QuantifyMe.Core.Business
{
    public interface IFitbitService
    {
        Task<Series> GetHeartbeatAsync(DateTimeOffset start, DateTimeOffset end);
    }
}
