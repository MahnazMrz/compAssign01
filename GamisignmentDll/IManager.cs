using System.Collections.Generic;
using GamisignmentDll.Entities;

namespace GamisignmentDll
{
    public interface IManager<T> where T : AbstractEntity
    {
        List<T> Read();
        T Read(int id);
        T Create(T t);
        T Update(T t);
        bool Delete(int id);
    }
}
