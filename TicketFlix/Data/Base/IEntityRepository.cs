using System.Linq.Expressions;

namespace TicketFlix.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByIdAsync(int id);
        Task<T> GetByIdAsync(int id, params Expression<Func<T, object>>[] includeProperties);
        //method to add data to database 
        Task AddAsync(T entity);

        //functionalties to update data in database
        Task UpdateAsync(int id, T entity);

        //Delete Method
        Task DeleteAsync(int id);
    }
}