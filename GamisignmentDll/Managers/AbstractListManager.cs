using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamisignmentDll.Entities;

namespace GamisignmentDll.Managers
{
    internal abstract class AbstractListManager<T> : IManager<T> where T : AbstractEntity
    {
        private static int _id = 1;

        private static readonly List<T> Types = new List<T>();
        public List<T> Read()
        {
            return Types;
        }

        public T Read(int id)
        {
            return Types.FirstOrDefault(x => x.Id == id);
        }

        public T Create(T t)
        {
            t.Id = _id++;
            Types.Add(t);
            return t;
        }

        public T Update(T newObject)
        {
            var oldObject = Read(newObject.Id);
            Update(newObject, oldObject);
            return oldObject;
        }

        public abstract void Update(T updatedT, T toUpdateT);

        public bool Delete(int id)
        {
            Types.RemoveAll(x => x.Id == id);
            return Types.FirstOrDefault(x => x.Id == id) == null;
        }
    }
}
