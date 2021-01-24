using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interface
{
    public interface IGenericRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T GetById (object id);
        void Insert(T entity);
        void Delete(object id);
        void Update(T entity);
    }
}