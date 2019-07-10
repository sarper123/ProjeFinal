using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_AppDAL
{
    public class Departman
    {
        [Key]
        public int DepartmanID { get; set; }
        [MaxLength(20)]
        public string Adi { get; set; }

        [MaxLength(50)]
        public string Aciklama { get; set; }


        public Departman(string ADI, string ACIKLAMA)
        {
            
            Adi = ADI;
            Aciklama = ACIKLAMA;
        }
        public Departman()
        {
            
        }
    }
}
