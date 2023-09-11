using System.Threading.Tasks;

namespace DataAccess.CrossCutting.DbContext
{
    public class UnitOfWork : IUnitOfWorkContext
    {
        public Microsoft.EntityFrameworkCore.DbContext DataContext { get; }

        public UnitOfWork(Microsoft.EntityFrameworkCore.DbContext dataContext)
        {
            DataContext = dataContext;
        }

        public int Commit()
        {
            return DataContext.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return DataContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            DataContext.Dispose();
        }
    }
}
