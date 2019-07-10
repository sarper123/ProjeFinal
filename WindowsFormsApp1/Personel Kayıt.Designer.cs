namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAdi = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.lblTc = new System.Windows.Forms.Label();
            this.mtxtTc = new System.Windows.Forms.MaskedTextBox();
            this.mtxtYas = new System.Windows.Forms.MaskedTextBox();
            this.lblYas = new System.Windows.Forms.Label();
            this.mtxtMaas = new System.Windows.Forms.MaskedTextBox();
            this.lblMaas = new System.Windows.Forms.Label();
            this.lblDepartmanAdi = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.cbDepartmanAdi = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblAdi.ForeColor = System.Drawing.Color.White;
            this.lblAdi.Location = new System.Drawing.Point(47, 152);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(48, 24);
            this.lblAdi.TabIndex = 3;
            this.lblAdi.Text = "Adı :";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(47, 179);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(246, 29);
            this.txtAdi.TabIndex = 2;
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.BackColor = System.Drawing.Color.Transparent;
            this.lblTc.ForeColor = System.Drawing.Color.White;
            this.lblTc.Location = new System.Drawing.Point(326, 90);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(42, 24);
            this.lblTc.TabIndex = 5;
            this.lblTc.Text = "Tc :";
            // 
            // mtxtTc
            // 
            this.mtxtTc.Location = new System.Drawing.Point(337, 117);
            this.mtxtTc.Mask = "00000000000";
            this.mtxtTc.Name = "mtxtTc";
            this.mtxtTc.Size = new System.Drawing.Size(246, 29);
            this.mtxtTc.TabIndex = 6;
            // 
            // mtxtYas
            // 
            this.mtxtYas.Location = new System.Drawing.Point(337, 176);
            this.mtxtYas.Mask = "00000";
            this.mtxtYas.Name = "mtxtYas";
            this.mtxtYas.Size = new System.Drawing.Size(246, 29);
            this.mtxtYas.TabIndex = 8;
            this.mtxtYas.ValidatingType = typeof(int);
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.BackColor = System.Drawing.Color.Transparent;
            this.lblYas.ForeColor = System.Drawing.Color.White;
            this.lblYas.Location = new System.Drawing.Point(326, 149);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(41, 24);
            this.lblYas.TabIndex = 7;
            this.lblYas.Text = "Yaş";
            // 
            // mtxtMaas
            // 
            this.mtxtMaas.Location = new System.Drawing.Point(337, 235);
            this.mtxtMaas.Mask = "000000";
            this.mtxtMaas.Name = "mtxtMaas";
            this.mtxtMaas.Size = new System.Drawing.Size(246, 29);
            this.mtxtMaas.TabIndex = 10;
            this.mtxtMaas.ValidatingType = typeof(int);
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.BackColor = System.Drawing.Color.Transparent;
            this.lblMaas.ForeColor = System.Drawing.Color.White;
            this.lblMaas.Location = new System.Drawing.Point(326, 208);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(55, 24);
            this.lblMaas.TabIndex = 9;
            this.lblMaas.Text = "Maaş";
            // 
            // lblDepartmanAdi
            // 
            this.lblDepartmanAdi.AutoSize = true;
            this.lblDepartmanAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmanAdi.ForeColor = System.Drawing.Color.White;
            this.lblDepartmanAdi.Location = new System.Drawing.Point(47, 90);
            this.lblDepartmanAdi.Name = "lblDepartmanAdi";
            this.lblDepartmanAdi.Size = new System.Drawing.Size(145, 24);
            this.lblDepartmanAdi.TabIndex = 11;
            this.lblDepartmanAdi.Text = "Departman Adı :";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyadi.ForeColor = System.Drawing.Color.White;
            this.lblSoyadi.Location = new System.Drawing.Point(47, 211);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(77, 24);
            this.lblSoyadi.TabIndex = 16;
            this.lblSoyadi.Text = "Soyadı :";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(47, 238);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(246, 29);
            this.txtSoyadi.TabIndex = 15;
            // 
            // cbDepartmanAdi
            // 
            this.cbDepartmanAdi.FormattingEnabled = true;
            this.cbDepartmanAdi.Location = new System.Drawing.Point(51, 117);
            this.cbDepartmanAdi.Name = "cbDepartmanAdi";
            this.cbDepartmanAdi.Size = new System.Drawing.Size(246, 32);
            this.cbDepartmanAdi.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(968, 204);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Koufi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(362, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 43);
            this.label1.TabIndex = 25;
            this.label1.Text = "PERSONEL KAYIT";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Gold;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = global::WindowsFormsApp1.Properties.Resources.silme;
            this.btnSil.Location = new System.Drawing.Point(770, 120);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(110, 149);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Image = global::WindowsFormsApp1.Properties.Resources.güncelle;
            this.btnGuncelle.Location = new System.Drawing.Point(907, 120);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(108, 149);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.YellowGreen;
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.ForeColor = System.Drawing.Color.Black;
            this.btnKayit.Image = global::WindowsFormsApp1.Properties.Resources.personelİcon;
            this.btnKayit.Location = new System.Drawing.Point(633, 120);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(109, 149);
            this.btnKayit.TabIndex = 19;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.LinearGradientBrush_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1051, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbDepartmanAdi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.lblDepartmanAdi);
            this.Controls.Add(this.mtxtMaas);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.mtxtYas);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.mtxtTc);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.txtAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Personel Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.Label lblDepartmanAdi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.MaskedTextBox mtxtTc;
        private System.Windows.Forms.MaskedTextBox mtxtYas;
        private System.Windows.Forms.MaskedTextBox mtxtMaas;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.ComboBox cbDepartmanAdi;
    }
}

