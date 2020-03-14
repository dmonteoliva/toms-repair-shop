using System.Threading.Tasks;

namespace TomsRepairShop.Domain.Interfaces.Repositories.Write
{
    public interface IWriteRepositoryBase<T>
    {
        Task<T> Insert(T entity);

        Task<T> Update(T entity);

        Task Delete(int id);
    }
}