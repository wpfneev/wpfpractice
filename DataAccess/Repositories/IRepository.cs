using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    internal interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        IEnumerable<T> GetAll();
        T Get(string id);
    }
}
