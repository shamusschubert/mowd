using mowd.quote.Models;
using mowd.quote.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mowd.quote.Domain.RequestAggregate
{
    public interface IRequestRepository : IRepository<Request, Guid>
    {
    }
}
