using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll(); // hepsini getir
        Task<T> GetByIdAsync(int id);
        IQueryable<T> where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression); //varmı yokmu
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities); //birden fazla kaydetme
        void Update(T entity); //update ve remove'un asenkron metodu yok o yüzden void
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities); // çoklu silme
    }
}
