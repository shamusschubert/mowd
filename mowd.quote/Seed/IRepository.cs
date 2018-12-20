using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mowd.quote.Seed
{
    public interface IRepository<T, TKey> : IDisposable where T : class 
    {
        Task<IEnumerable<T>> Get();

        Task<T> Get(TKey key);

        Task<bool> Add(T item);
    }
}
