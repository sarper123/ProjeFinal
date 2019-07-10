namespace WindowsFormsApp1
{
    partial class HRP_2019
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personelKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmanKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelKayıtToolStripMenuItem,
            this.departmanKayıtToolStripMenuItem,
            this.personelAraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(955, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personelKayıtToolStripMenuItem
            // 
            this.personelKayıtToolStripMenuItem.Name = "personelKayıtToolStripMenuItem";
            this.personelKayıtToolStripMenuItem.Size = new System.Drawing.Size(93, 19);
            this.personelKayıtToolStripMenuItem.Text = "Personel Kayıt";
            this.personelKayıtToolStripMenuItem.Click += new System.EventHandler(this.personelKayıtToolStripMenuItem_Click);
            // 
            // departmanKayıtToolStripMenuItem
            // 
            this.departmanKayıtToolStripMenuItem.Name = "departmanKayıtToolStripMenuItem";
            this.departmanKayıtToolStripMenuItem.Size = new System.Drawing.Size(107, 19);
            this.departmanKayıtToolStripMenuItem.Text = "Departman Kayıt";
            this.departmanKayıtToolStripMenuItem.Click += new System.EventHandler(this.departmanKayıtToolStripMenuItem_Click);
            // 
            // personelAraToolStripMenuItem
            // 
            this.personelAraToolStripMenuItem.Name = "personelAraToolStripMenuItem";
            this.personelAraToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.personelAraToolStripMenuItem.Text = "Personel Ara";
            this.personelAraToolStripMenuItem.Click += new System.EventHandler(this.personelAraToolStripMenuItem_Click);
            // 
            // HRP_2019
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Kaynaklar;
            this.ClientSize = new System.Drawing.Size(955, 502);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "HRP_2019";
            this.Text = "HRP_2019";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personelKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmanKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelAraToolStripMenuItem;
    }
}