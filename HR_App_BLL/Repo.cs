using HR_AppDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_App_BLL
{
    public class Repo<T> : IRepo<T> where T : class
    {
        ProjeContext db = DbInstance.Instance;
        public void Add(T Entity)
        {
            db.Set<T>().Add(Entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var Entity=db.Set<T>().Find(id);
            db.Set<T>().Remove(Entity);
            db.SaveChanges();
        }

        public List<T> SelectAll()
        {
            return db.Set<T>().Cast<T>().ToList();
        }

        public T SelectById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            var Entity = db.Entry(entity);
            //var Entity = db.Set<DbEntityEntry<T>>().Find(id);
            Entity.State = EntityState.Modified;
            db.SaveChanges();
        }

        public Personel Find(string Tc)
        {
            var nesne = from p in db.Personeller
                        where p.Tc == Tc
                        select p;
            return nesne.ToList()[0];
            
        }

        private static Repo<T> _instance;

        public static Repo<T> Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Repo<T>();
                }
                return _instance;
            }
            
        }

    }
}
