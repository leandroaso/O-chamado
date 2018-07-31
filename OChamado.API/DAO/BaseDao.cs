using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OChamado.API.DAO
{
    public interface BaseDao<T>
    {
        void Save(T t);
        void SaveAll(IEnumerable<T> t);
        IEnumerable<T> List();
        T Get(params object[] id);
        void Delete(int id);
        void Updade(T obj);        
    }
}
