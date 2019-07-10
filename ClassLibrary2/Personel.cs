using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_AppDAL
{
    public class Personel
    {
        
        [Key]
        public int PersonelId { get; set; }
        [MaxLength(20)]
        public string Adi { get; set; }
        [MaxLength(20)]
        public string Soyadi { get; set; }
        [MaxLength(11)]
        public string Tc { get; set; }
        
        public int Yas { get; set; }

        
        public int Maas { get; set; }
        
        public int DepartmanId { get; set; }

        public Personel(string ADI, string SOYADI, string TC, int YAS, int MAAS, int DEPARTMANID)
        {

            Adi = ADI;
            Soyadi = SOYADI;
            Tc = TC;
            Yas = YAS;
            Maas = MAAS;
            DepartmanId = DEPARTMANID;
        }
        public Personel()
        {

        }
    }
}
