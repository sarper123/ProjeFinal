using HR_AppDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_App_BLL
{
    public interface IRepo<T> where T:class
    {
        void Add(T xasdads);
        void Delete(int id);
        void Update(T entity);
        T SelectById(int id);
        List<T> SelectAll();
        Personel Find(string Tc);

    }
}
