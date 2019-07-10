using HR_AppDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_App_BLL
{
    public class DbInstance
    {
        private static ProjeContext _instance;

        public static ProjeContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProjeContext();
                }
                return _instance;
            }
            
        }

    }
}
