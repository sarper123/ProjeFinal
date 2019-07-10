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
    public partial class HRP_2019 : Form
    {
        public HRP_2019()
        {
            InitializeComponent();
        }
        void FormKontrol(Form form)
        {
            this.Width = form.Width + 22;
            this.Height = form.Height + 68;
            bool flag = false;

            foreach (Form item in this.MdiChildren)
            {
                if (item.Text == form.Text)
                {
                    form.Activate();
                    flag = true;
                }
                else item.Close();
                
            }
            if (flag==false)
            {
                form.MdiParent = this;
                flag = true;
                form.Show();
            }
        }
        private void personelKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Personel_Kayit = new Form1();
            FormKontrol(Personel_Kayit);
        }

        private void departmanKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departman_Kayıt departman_Kayıt = new Departman_Kayıt();
            FormKontrol(departman_Kayıt);
        }

        private void personelAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personel_Bul personel_Bul = new Personel_Bul();
            FormKontrol(personel_Bul);
        }
    }
}
