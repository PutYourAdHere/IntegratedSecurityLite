using Domain.CrossCutting.DataAccess;

namespace DataAccess.CrossCutting.DbContext
{
    public interface IUnitOfWorkContext : IUnitOfWork
    {

        Microsoft.EntityFrameworkCore.DbContext DataContext { get; }
    }
}
