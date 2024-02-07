using Microsoft.EntityFrameworkCore.Storage;

namespace papara_firstweek_hwApp.API.Models.UnitOfWorks
{
    public interface IUnitOfWork
    {
        int Commit();
        Task<int> CommitAsync();

        IDbContextTransaction BeginTransaction();
    }
}
