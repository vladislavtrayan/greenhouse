using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IRepository<T>
    {
        int Add(T obj);
        void Update(T obj);
        void Remove(int id);
        T Find(int id);
        List<T> GetAll();
    }
}
