namespace HastaneBilgiSistemi
{
    partial class adminForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDoctorKaydet = new System.Windows.Forms.Button();
            this.txtDoctorAd = new System.Windows.Forms.TextBox();
            this.txtdoctorTCNo = new System.Windows.Forms.TextBox();
            this.txtDoctorSoyad = new System.Windows.Forms.TextBox();
            this.cmbDoctorBolum = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.txtPersonelTC = new System.Windows.Forms.TextBox();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.btnPersonelKaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimeDoctor = new System.Windows.Forms.DateTimePicker();
            this.dateTimePersonel = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeDoctor);
            this.groupBox1.Controls.Add(this.cmbDoctorBolum);
            this.groupBox1.Controls.Add(this.txtDoctorSoyad);
            this.groupBox1.Controls.Add(this.txtdoctorTCNo);
            this.groupBox1.Controls.Add(this.txtDoctorAd);
            this.groupBox1.Controls.Add(this.btnDoctorKaydet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Ekleme";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePersonel);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.txtPersonelSoyad);
            this.groupBox2.Controls.Add(this.txtPersonelTC);
            this.groupBox2.Controls.Add(this.txtPersonelAd);
            this.groupBox2.Controls.Add(this.btnPersonelKaydet);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(329, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Ekleme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bölüm :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dogum Tarihi :";
            // 
            // btnDoctorKaydet
            // 
            this.btnDoctorKaydet.Location = new System.Drawing.Point(131, 188);
            this.btnDoctorKaydet.Name = "btnDoctorKaydet";
            this.btnDoctorKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnDoctorKaydet.TabIndex = 5;
            this.btnDoctorKaydet.Text = "Kaydet";
            this.btnDoctorKaydet.UseVisualStyleBackColor = true;
            // 
            // txtDoctorAd
            // 
            this.txtDoctorAd.Location = new System.Drawing.Point(90, 29);
            this.txtDoctorAd.Name = "txtDoctorAd";
            this.txtDoctorAd.Size = new System.Drawing.Size(100, 20);
            this.txtDoctorAd.TabIndex = 7;
            // 
            // txtdoctorTCNo
            // 
            this.txtdoctorTCNo.Location = new System.Drawing.Point(90, 83);
            this.txtdoctorTCNo.Name = "txtdoctorTCNo";
            this.txtdoctorTCNo.Size = new System.Drawing.Size(100, 20);
            this.txtdoctorTCNo.TabIndex = 8;
            // 
            // txtDoctorSoyad
            // 
            this.txtDoctorSoyad.Location = new System.Drawing.Point(90, 57);
            this.txtDoctorSoyad.Name = "txtDoctorSoyad";
            this.txtDoctorSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtDoctorSoyad.TabIndex = 9;
            // 
            // cmbDoctorBolum
            // 
            this.cmbDoctorBolum.FormattingEnabled = true;
            this.cmbDoctorBolum.Location = new System.Drawing.Point(90, 135);
            this.cmbDoctorBolum.Name = "cmbDoctorBolum";
            this.cmbDoctorBolum.Size = new System.Drawing.Size(164, 21);
            this.cmbDoctorBolum.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Location = new System.Drawing.Point(101, 51);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelSoyad.TabIndex = 21;
            // 
            // txtPersonelTC
            // 
            this.txtPersonelTC.Location = new System.Drawing.Point(101, 77);
            this.txtPersonelTC.Name = "txtPersonelTC";
            this.txtPersonelTC.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelTC.TabIndex = 20;
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(101, 23);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelAd.TabIndex = 19;
            // 
            // btnPersonelKaydet
            // 
            this.btnPersonelKaydet.Location = new System.Drawing.Point(142, 182);
            this.btnPersonelKaydet.Name = "btnPersonelKaydet";
            this.btnPersonelKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnPersonelKaydet.TabIndex = 18;
            this.btnPersonelKaydet.Text = "Kaydet";
            this.btnPersonelKaydet.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Dogum Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Soyad :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "TC No :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Bölüm :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ad :";
            // 
            // dateTimeDoctor
            // 
            this.dateTimeDoctor.Location = new System.Drawing.Point(90, 109);
            this.dateTimeDoctor.Name = "dateTimeDoctor";
            this.dateTimeDoctor.Size = new System.Drawing.Size(199, 20);
            this.dateTimeDoctor.TabIndex = 2;
            // 
            // dateTimePersonel
            // 
            this.dateTimePersonel.Location = new System.Drawing.Point(101, 103);
            this.dateTimePersonel.Name = "dateTimePersonel";
            this.dateTimePersonel.Size = new System.Drawing.Size(200, 20);
            this.dateTimePersonel.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ad,
            this.Soyad,
            this.TCNo,
            this.DogumTarihi,
            this.Bolum});
            this.dataGridView1.Location = new System.Drawing.Point(24, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(606, 165);
            this.dataGridView1.TabIndex = 2;
            // 
            // Ad
            // 
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.Name = "Soyad";
            // 
            // TCNo
            // 
            this.TCNo.HeaderText = "TCNo";
            this.TCNo.Name = "TCNo";
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.HeaderText = "DogumTarihi";
            this.DogumTarihi.Name = "DogumTarihi";
            // 
            // Bolum
            // 
            this.Bolum.HeaderText = "Bölüm";
            this.Bolum.Name = "Bolum";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(517, 466);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 551);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "adminForm";
            this.Text = "Admin Form";
            this.Load += new System.EventHandler(this.adminForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimeDoctor;
        private System.Windows.Forms.ComboBox cmbDoctorBolum;
        private System.Windows.Forms.TextBox txtDoctorSoyad;
        private System.Windows.Forms.TextBox txtdoctorTCNo;
        private System.Windows.Forms.TextBox txtDoctorAd;
        private System.Windows.Forms.Button btnDoctorKaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePersonel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
        private System.Windows.Forms.TextBox txtPersonelTC;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.Button btnPersonelKaydet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bolum;
        private System.Windows.Forms.Button btnSil;
    }
}