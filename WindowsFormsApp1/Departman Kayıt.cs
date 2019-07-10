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
    public partial class Departman_Kayıt : Form
    {
        Repo<Departman> DepartmanDepo = Repo<Departman>.Instance;
        public Departman_Kayıt()
        {
            InitializeComponent();
        }

        private void Departman_Kayıt_Load(object sender, EventArgs e)
        {
            dgvDepartmanlar.DataSource = DepartmanDepo.SelectAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Departman departman = new Departman(txtAdi.Text,txtAciklama.Text);
            DepartmanDepo.Add(departman);
            dgvDepartmanlar.DataSource = DepartmanDepo.SelectAll();

            txtAdi.Text = null;
            txtAciklama.Text = null;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = (int)dgvDepartmanlar.CurrentRow.Cells[0].Value;
            var departman=DepartmanDepo.SelectById(id);
            departman.Adi = txtAdi.Text;
            departman.Aciklama = txtAciklama.Text;
            DepartmanDepo.Update(departman);
            dgvDepartmanlar.DataSource = DepartmanDepo.SelectAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            int id = (int)dgvDepartmanlar.CurrentRow.Cells[0].Value;
            DepartmanDepo.Delete(id);
            dgvDepartmanlar.DataSource= DepartmanDepo.SelectAll();
        }

        private void dgvDepartmanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtAdi.Text = dgvDepartmanlar.CurrentRow.Cells[1].Value.ToString();
            txtAciklama.Text = dgvDepartmanlar.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
