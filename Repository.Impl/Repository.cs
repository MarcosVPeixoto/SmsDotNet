using Microsoft.EntityFrameworkCore;
using SmsDotNet.Data;
using SmsDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public T Add(T model)
        {
            _models.Add(model);
            return model;
        }

        public async Task<T> AddAsync(T model)
        {
            await _models.AddAsync(model);
            return model;
        }

        public void Delete(int id)
        {
            var model = _models.AsQueryable().FirstOrDefault(e => e.Id == id);
            model.IsDeleted = true;
            _context.SaveChanges();
        }

        public IEnumerable<T> FindAll()
        {
            var query = _models.AsQueryable();
            query = query.Select(e => e);
            return query.ToList();
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            var query = _models.AsQueryable();
            query = query.Select(e => e);
            return await query.ToListAsync();
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            var query = _models.AsQueryable();
            query = query.Where(predicate);
            return query.ToList();
        }

        public async Task<IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> predicate)
        {
            var query = _models.AsQueryable();
            query = query.Where(predicate);
            return await query.ToListAsync();
        }

        public void UnDelete(int id)
        {
            var model = _models.AsQueryable().FirstOrDefault(e => e.Id == id);
            model.IsDeleted = false;
            _context.SaveChanges();
        }

        public T Update(T model)
        {
            _models.Attach(model).State = EntityState.Modified;
            _context.SaveChanges();
            return model;
        }

        IEnumerable<T> IRepository<T>.FindBy(Expression<Func<T, bool>> predicate)
        {
            var query = _models.AsQueryable();
            query = query.Where(predicate);
            return query.ToList();
        }
    }
}
        