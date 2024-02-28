using Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public interface IGenericRepository<T> where T : BaseModel
    {
        List<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        void SaveChanges();
    }
}
