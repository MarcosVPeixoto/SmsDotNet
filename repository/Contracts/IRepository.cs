

using SmsDotNet.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SmsDotNet.repository
{
    public interface IRepository <T> where T : BaseModel

    {
        T Add(T model);
        Task<T> AddAsync(T model);
        T Update(T model);
        void Delete(int id);
        void Undelete(int id);
        IEnumerable<T> FindAll();
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
       
    }
}
