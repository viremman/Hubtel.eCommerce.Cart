using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Hubtel.eCommerce.Cart.Api.Data.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        T GetById(object id);
        Task<T> GetByIdAsync(object id);
        void Insert(T obj);
        Task InsertAsync(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
        Task SaveAsync();
    }
}
