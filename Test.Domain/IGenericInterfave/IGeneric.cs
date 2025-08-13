using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.IGenericInterfave
{
    public interface IGeneric<T> where T: class
    {
        Task<List<T>> GetAll();
        Task<T> GetById(Guid id);
        Task<T> addData(T entity);
        Task<T> updateData(T entity);
        Task<T> deleteById(T entity);
    }
}
