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
    public partial class Form1 : Form
    {
        Repo<Personel> PersonelDepo = Repo<Personel>.Instance;
        Repo<Departman> DepartmanDepo = Repo<Departman>.Instance;
        public Form1()
        {
            InitializeComponent();
        }


        
        private void btnKayit_Click(object sender, EventArgs e)
        {
            //Nesne Oluşturma
            Personel personel = new Personel(txtAdi.Text, txtSoyadi.Text, mtxtTc.Text, Convert.ToInt32(mtxtYas.Text), Convert.ToInt32(mtxtMaas.Text), cbDepartmanAdi.SelectedIndex+1);
            PersonelDepo.Add(personel);
            dataGridView1.DataSource = PersonelDepo.SelectAll();

            //Textboxları temizleme
            txtAdi.Clear();
            txtSoyadi.Clear();
            mtxtTc.Clear();
            mtxtYas.Clear();
            mtxtMaas.Clear();
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            Personel personel=PersonelDepo.SelectById(id);
            personel.Adi = txtAdi.Text;
            personel.Soyadi = txtSoyadi.Text;
            personel.Tc = mtxtTc.Text;
            personel.Maas = Convert.ToInt32(mtxtMaas.Text);
            personel.Yas = Convert.ToInt32(mtxtYas.Text);
            personel.DepartmanId = cbDepartmanAdi.SelectedIndex;
            PersonelDepo.Update(personel);
            dataGridView1.DataSource = PersonelDepo.SelectAll();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mtxtTc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mtxtYas.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            mtxtMaas.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            PersonelDepo.Delete(id);
            dataGridView1.DataSource = PersonelDepo.SelectAll();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> DpListe = new List<string>();
            foreach (var item in DepartmanDepo.SelectAll())
            {
                DpListe.Add(item.Adi);
            }

            if (DpListe.Count == 0)
            {
                cbDepartmanAdi.DataSource = null;
            }
            else
            {
                cbDepartmanAdi.DataSource = DpListe;
            }
            

            dataGridView1.DataSource= PersonelDepo.SelectAll();
        }
        
    }
}
