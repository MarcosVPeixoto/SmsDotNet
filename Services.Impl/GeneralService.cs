using SmsDotNet.Entities;
using SmsDotNet.Repositories;
using SmsDotNet.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmsDotNet.Services.Impl
{
    public abstract class GeneralService<T> : IGeneralService<T> where T : BaseModel
    {
        private readonly IRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public virtual async Task<T> Add(T model)
        {
            return await _repository.AddAsync(model);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var models = await _repository.FindAllAsync();
            if (models.Count() == 0 || models == null)
            {
                models = null;
            }
            return models;
        }

        public void UnDelete(int id)
        {
            _repository.UnDelete(id);
        }

        public T Update(T updatedModel)
        {
            _repository.Update(updatedModel);
            return updatedModel;
        }
    }
}
