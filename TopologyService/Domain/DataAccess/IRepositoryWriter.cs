using System;
using System.Collections.Generic;
using Domain.CrossCutting.Model;

namespace Domain.CrossCutting.DataAccess
{
    public interface IRepositoryWriter<T> : IRepositoryReader<T>, IRepositoryReaderAsync<T>, IDisposable where T : BaseEntity
    {

        void Insert(T entity);
        void Insert(IEnumerable<T> entities);
        
        void Update(T entity);
        void Update(IEnumerable<T> entities);
        
        void Delete(T entity);
        void Delete(Guid id);
        void Delete(IEnumerable<T> entities);
    }
}
