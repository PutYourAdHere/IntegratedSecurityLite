using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Domain.CrossCutting.Model;

namespace Domain.CrossCutting.DataAccess
{
    public interface IRepositoryReaderAsync<T> : IDisposable where T : BaseEntity
    {
        ValueTask<T> GetAsync(Guid id);
        IAsyncEnumerable<T> GetAsync();
        IAsyncEnumerable<T> GetAsync(Expression<Func<T, bool>> expression);

    }
}
