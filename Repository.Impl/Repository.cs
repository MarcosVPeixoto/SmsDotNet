using Microsoft.EntityFrameworkCore;
using SmsDotNet.Data;
using SmsDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SmsDotNet.Repositories.Impl
{
    public abstract class Repository<T> : IRepository<T> where T : BaseModel
    {
        protected DataContext _context;
        protected DbSet<T> _models;

        public Repository(DataContext context)
        {
            _context = context;
            _models = context.Set<T>();
        }
        public BaseModel Add(BaseModel _model)
        {
            throw new NotImplementedException();
        }

        public T Add(T model)
        {
            throw new NotImplementedException();
        }

        public Task<BaseModel> AddAsync(BaseModel model)
        {
            throw new NotImplementedException();
        }

        public Task<T> AddAsync(T model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BaseModel> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BaseModel> FindBy(Expression<Func<BaseModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate, bool eager = false)
        {
            throw new NotImplementedException();
        }

        public void UnDelete(int Id)
        {
            throw new NotImplementedException();
        }

        public BaseModel Update(BaseModel Model)
        {
            throw new NotImplementedException();
        }

        public T Update(T model)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IRepository<T>.FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
