using SmsDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SmsDotNet.Repositories
{
    public interface IRepository <T> where T : BaseModel

    {
        T Add(T model);
        T Update(T model);
        void Delete(int id);
        void UnDelete(int id);
        IEnumerable<T> FindAll();
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        Task<T> AddAsync(T model);
        Task <IEnumerable<T>> FindAllAsync();
        Task <IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> predicate);
    }
}
