using SmsDotNet.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmsDotNet.Services
{
    public interface IGeneralService <T> where T : BaseModel
    {
        Task <T> Add(T model);
        Task <IEnumerable <T>> GetAll();
        void Delete (int id);
        void UnDelete (int id);
        T Update (T updatedModel);

    }
}
