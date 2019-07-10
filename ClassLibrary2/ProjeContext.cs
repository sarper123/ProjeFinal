using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_AppDAL
{
    public class ProjeContext:DbContext
    {
        public ProjeContext()
        {
            Database.Connection.ConnectionString = @"server=DESKTOP-HCF992J; database = HR;uid=sa ;pwd=123456";
            Database.SetInitializer<ProjeContext>(new CreateDatabaseIfNotExists<ProjeContext>());
            Database.SetInitializer<ProjeContext>(new DropCreateDatabaseIfModelChanges<ProjeContext>());

        }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Departman> Departmanlar { get; set; }
    }
}
