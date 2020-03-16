using System.Data;
using TomsRepairShop.Domain.Interfaces.Data;

namespace TomsRepairShop.Data.Write
{
    public abstract class BaseWriteRepository
    {
        private readonly IUnitOfWork uow;

        public BaseWriteRepository(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        protected IDbConnection Connection
        {
            get
            {
                return uow.OpenConnection();
            }
        }
    }
}