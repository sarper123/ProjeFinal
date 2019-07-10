namespace WindowsFormsApp1
{
    partial class Departman_Kayıt
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
            this.lblDepartmanAdi = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dgvDepartmanlar = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepartmanAdi
            // 
            this.lblDepartmanAdi.AllowDrop = true;
            this.lblDepartmanAdi.AutoSize = true;
            this.lblDepartmanAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmanAdi.ForeColor = System.Drawing.Color.White;
            this.lblDepartmanAdi.Location = new System.Drawing.Point(36, 261);
            this.lblDepartmanAdi.Name = "lblDepartmanAdi";
            this.lblDepartmanAdi.Size = new System.Drawing.Size(145, 24);
            this.lblDepartmanAdi.TabIndex = 2;
            this.lblDepartmanAdi.Text = "Departman Adı :";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AllowDrop = true;
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.BackColor = System.Drawing.Color.Transparent;
            this.lblAciklama.ForeColor = System.Drawing.Color.White;
            this.lblAciklama.Location = new System.Drawing.Point(36, 349);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(96, 24);
            this.lblAciklama.TabIndex = 3;
            this.lblAciklama.Text = "Açıklama :";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(40, 302);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(257, 29);
            this.txtAdi.TabIndex = 4;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(40, 376);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(257, 105);
            this.txtAciklama.TabIndex = 5;
            // 
            // dgvDepartmanlar
            // 
            this.dgvDepartmanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDepartmanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartmanlar.Location = new System.Drawing.Point(40, 68);
            this.dgvDepartmanlar.Name = "dgvDepartmanlar";
            this.dgvDepartmanlar.Size = new System.Drawing.Size(586, 178);
            this.dgvDepartmanlar.TabIndex = 6;
            this.dgvDepartmanlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartmanlar_CellClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Image = global::WindowsFormsApp1.Properties.Resources.SİLL;
            this.btnSil.Location = new System.Drawing.Point(364, 390);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(108, 105);
            this.btnSil.TabIndex = 9;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Image = global::WindowsFormsApp1.Properties.Resources.icon_for_update_28;
            this.btnGuncelle.Location = new System.Drawing.Point(498, 325);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(108, 112);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Image = global::WindowsFormsApp1.Properties.Resources.EKLE;
            this.btnEkle.Location = new System.Drawing.Point(358, 261);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(114, 112);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "DEPARTMAN KAYDI";
            // 
            // Departman_Kayıt
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.LinearGradientBrush_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvDepartmanlar);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblDepartmanAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Departman_Kayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Departman_Kayıt";
            this.Load += new System.EventHandler(this.Departman_Kayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmanlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDepartmanAdi;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DataGridView dgvDepartmanlar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label1;
    }
}