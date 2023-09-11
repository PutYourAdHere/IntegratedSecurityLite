using System;
using System.Threading.Tasks;

namespace Domain.CrossCutting.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();

        Task<int> CommitAsync();
    }
}
