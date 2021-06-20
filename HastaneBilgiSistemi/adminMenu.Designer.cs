
namespace HastaneBilgiSistemi
{
    partial class adminMenu
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
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.btnDoctorBransEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Location = new System.Drawing.Point(80, 81);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(104, 52);
            this.btnKullaniciEkle.TabIndex = 0;
            this.btnKullaniciEkle.Text = "Personel Ekleme";
            this.btnKullaniciEkle.UseVisualStyleBackColor = true;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // btnDoctorBransEkle
            // 
            this.btnDoctorBransEkle.Location = new System.Drawing.Point(80, 152);
            this.btnDoctorBransEkle.Name = "btnDoctorBransEkle";
            this.btnDoctorBransEkle.Size = new System.Drawing.Size(104, 52);
            this.btnDoctorBransEkle.TabIndex = 2;
            this.btnDoctorBransEkle.Text = "Doktor Atama";
            this.btnDoctorBransEkle.UseVisualStyleBackColor = true;
            this.btnDoctorBransEkle.Click += new System.EventHandler(this.btnDoctorBransEkle_Click);
            // 
            // adminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 330);
            this.Controls.Add(this.btnDoctorBransEkle);
            this.Controls.Add(this.btnKullaniciEkle);
            this.Name = "adminMenu";
            this.Text = "Admin Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.Button btnDoctorBransEkle;
    }
}