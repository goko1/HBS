namespace HastaneBilgiSistemi
{
    partial class personelHastaKayitForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtSikayet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Kaydet = new System.Windows.Forms.Button();
            this.cmbDoktorlar = new System.Windows.Forms.ComboBox();
            this.cmbHastaneBolumLeri = new System.Windows.Forms.ComboBox();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeDogumTarihi);
            this.groupBox1.Controls.Add(this.txtSikayet);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Kaydet);
            this.groupBox1.Controls.Add(this.cmbDoktorlar);
            this.groupBox1.Controls.Add(this.cmbHastaneBolumLeri);
            this.groupBox1.Controls.Add(this.txtTCNo);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtHastaAdi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Kayıt Ekranı";
            // 
            // dateTimeDogumTarihi
            // 
            this.dateTimeDogumTarihi.Location = new System.Drawing.Point(127, 119);
            this.dateTimeDogumTarihi.Name = "dateTimeDogumTarihi";
            this.dateTimeDogumTarihi.Size = new System.Drawing.Size(171, 20);
            this.dateTimeDogumTarihi.TabIndex = 14;
            // 
            // txtSikayet
            // 
            this.txtSikayet.Location = new System.Drawing.Point(368, 41);
            this.txtSikayet.Multiline = true;
            this.txtSikayet.Name = "txtSikayet";
            this.txtSikayet.Size = new System.Drawing.Size(128, 72);
            this.txtSikayet.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Şikayet :";
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(330, 224);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(75, 23);
            this.Kaydet.TabIndex = 1;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // cmbDoktorlar
            // 
            this.cmbDoktorlar.FormattingEnabled = true;
            this.cmbDoktorlar.Location = new System.Drawing.Point(124, 172);
            this.cmbDoktorlar.Name = "cmbDoktorlar";
            this.cmbDoktorlar.Size = new System.Drawing.Size(121, 21);
            this.cmbDoktorlar.TabIndex = 11;
            // 
            // cmbHastaneBolumLeri
            // 
            this.cmbHastaneBolumLeri.FormattingEnabled = true;
            this.cmbHastaneBolumLeri.Location = new System.Drawing.Point(124, 145);
            this.cmbHastaneBolumLeri.Name = "cmbHastaneBolumLeri";
            this.cmbHastaneBolumLeri.Size = new System.Drawing.Size(121, 21);
            this.cmbHastaneBolumLeri.TabIndex = 10;
            this.cmbHastaneBolumLeri.SelectedValueChanged += new System.EventHandler(this.cmbHastaneBolumLeri_SelectedValueChanged);
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(124, 93);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(121, 20);
            this.txtTCNo.TabIndex = 8;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(124, 67);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtSoyad.TabIndex = 7;
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(124, 41);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(121, 20);
            this.txtHastaAdi.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Doctor :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bolum :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dogum Tarihi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // personelHastaKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 367);
            this.Controls.Add(this.groupBox1);
            this.Name = "personelHastaKayitForm";
            this.Text = "Personel Form";
            this.Load += new System.EventHandler(this.personelHastaKayitForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSikayet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.ComboBox cmbDoktorlar;
        private System.Windows.Forms.ComboBox cmbHastaneBolumLeri;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeDogumTarihi;
    }
}