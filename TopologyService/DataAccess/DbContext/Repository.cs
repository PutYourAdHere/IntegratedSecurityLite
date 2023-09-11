using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Domain.CrossCutting.DataAccess;
using Domain.CrossCutting.Model;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.CrossCutting.DbContext
{
    public class Repository<T> : IRepositoryWriter<T> where T : BaseEntity
    {
        private readonly IUnitOfWorkContext _unitOfWork;

        public Repository(IUnitOfWorkContext unitOfWork) => _unitOfWork = unitOfWork;

        public T Get(Guid id) => _unitOfWork.DataContext.Set<T>().Find(id);

        public IEnumerable<T> Get() => _unitOfWork.DataContext.Set<T>().AsEnumerable();

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate) => _unitOfWork.DataContext.Set<T>().Where(predicate).AsEnumerable();

        public void Insert(T entity) => _unitOfWork.DataContext.Set<T>().Add(entity);

        public void Insert(IEnumerable<T> entities)
        {
            _unitOfWork.DataContext.Set<T>().AddRange(entities);
        }

        public void Update(T entity)
        {
            _unitOfWork.DataContext.Entry(entity).State = EntityState.Modified;
            _unitOfWork.DataContext.Set<T>().Attach(entity);
        }

        public void Update(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
                Update(entity);
        }

        public void Delete(T entity)
        {
            if (entity != null) Delete(entity.Id);
        }

        public void Delete(Guid id)
        {
            var existing = _unitOfWork.DataContext.Set<T>().Find(id);
            if (existing != null) _unitOfWork.DataContext.Set<T>().Remove(existing);
        }

        public void Delete(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
                Delete(entity.Id);
        }

        public void Dispose() => _unitOfWork?.Dispose();

        public ValueTask<T> GetAsync(Guid id) => _unitOfWork.DataContext.Set<T>().FindAsync(id);

        public IAsyncEnumerable<T> GetAsync() => _unitOfWork.DataContext.Set<T>().AsAsyncEnumerable();

        public IAsyncEnumerable<T> GetAsync(Expression<Func<T, bool>> expression) => _unitOfWork.DataContext.Set<T>().Where(expression).AsAsyncEnumerable();

    }
}
