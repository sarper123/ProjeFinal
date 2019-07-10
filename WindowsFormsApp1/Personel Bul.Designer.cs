namespace WindowsFormsApp1
{
    partial class Personel_Bul
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBul = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc Kimlik Numarası :";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(12, 102);
            this.txtTc.Mask = "00000000000";
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(181, 29);
            this.txtTc.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(199, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 171);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnBul
            // 
            this.btnBul.ForeColor = System.Drawing.Color.Black;
            this.btnBul.Image = global::WindowsFormsApp1.Properties.Resources.find_icon__1_;
            this.btnBul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBul.Location = new System.Drawing.Point(12, 170);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(181, 53);
            this.btnBul.TabIndex = 7;
            this.btnBul.Text = "Personel Bul";
            this.btnBul.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(354, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "PERSONEL BULMA";
            // 
            // Personel_Bul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.LinearGradientBrush_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(967, 332);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Personel_Bul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Personel_Bul";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtTc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label label5;
    }
}