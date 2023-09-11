using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Domain.CrossCutting.Model;

namespace Domain.CrossCutting.DataAccess
{
    public interface IRepositoryReader<T> : IDisposable where T : BaseEntity
    {
        T Get(Guid id);
        IEnumerable<T> Get();
        IEnumerable<T> Get(Expression<Func<T, bool>> expression);
    }
}
