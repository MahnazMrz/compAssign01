using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamisignmentDll.Context;
using GamisignmentDll.Entities;

namespace GamisignmentDll.Managers
{
    internal class RepeatManager : IManager<Repeat>
    {
        public List<Repeat> Read()
        {
            using (var db = new GamisignmentContext())
            {
                return db.Repeats.ToList();
            }
        }

        public Repeat Read(int id)
        {
            using (var db = new GamisignmentContext())
            {
                return db.Repeats.FirstOrDefault(x => x.Id == id);
            }
        }

        public Repeat Create(Repeat t)
        {
            using (var db = new GamisignmentContext())
            {
                db.Repeats.Add(t);
                db.SaveChanges();
                return t;
            }
        }

        public Repeat Update(Repeat t)
        {
            using (var db = new GamisignmentContext())
            {
                //3. Mark entity as modified
                db.Entry(t).State = System.Data.Entity.EntityState.Modified;

                //4. call SaveChanges
                db.SaveChanges();
                return t;
            }
        }

        public bool Delete(int id)
        {
            using (var db = new GamisignmentContext())
            {
                var delete = db.Repeats.FirstOrDefault(x => x.Id == id);
                db.Entry(delete).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                return db.Repeats.FirstOrDefault(x => x.Id == id) == null;
            }
        }
    }
}
