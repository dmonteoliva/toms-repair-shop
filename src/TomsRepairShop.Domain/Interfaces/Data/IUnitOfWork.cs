using System;

namespace TomsRepairShop.Domain.Interfaces.Data
{
    public interface IUnitOfWork : IDisposable
    {
        dynamic OpenConnection();

        void BeginTransaction();

        void Commit();

        void Rollback();

        void CloseConnection();
    }
}