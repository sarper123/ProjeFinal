using HR_App_BLL;
using HR_AppDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Personel_Bul : Form
    {
        Repo<Personel> PersonelDepo = Repo<Personel>.Instance;
        List<Personel> Tablo = new List<Personel>();
        public Personel_Bul()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Tablo.Clear();
            Tablo.Add(PersonelDepo.Find(txtTc.Text));
            dataGridView1.DataSource= Tablo;
            dataGridView1.Refresh();
        }
    }
}
