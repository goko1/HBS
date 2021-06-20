namespace HastaneBilgiSistemi
{
    partial class doctorForm
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
            this.ila = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtİlaçlar = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilaclar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ila);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.txtİlaçlar);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(38, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hastalarım";
            // 
            // ila
            // 
            this.ila.AutoSize = true;
            this.ila.Location = new System.Drawing.Point(40, 219);
            this.ila.Name = "ila";
            this.ila.Size = new System.Drawing.Size(41, 13);
            this.ila.TabIndex = 4;
            this.ila.Text = "İlaçlar :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(422, 215);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(204, 56);
            this.txtAciklama.TabIndex = 3;
            // 
            // txtİlaçlar
            // 
            this.txtİlaçlar.Location = new System.Drawing.Point(104, 212);
            this.txtİlaçlar.Multiline = true;
            this.txtİlaçlar.Name = "txtİlaçlar";
            this.txtİlaçlar.Size = new System.Drawing.Size(185, 59);
            this.txtİlaçlar.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(306, 300);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 34);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Muayene Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ad,
            this.Soyad,
            this.TCNo,
            this.DogumTarihi,
            this.Durumu,
            this.ilaclar,
            this.Aciklama});
            this.dataGridView1.Location = new System.Drawing.Point(16, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 142);
            this.dataGridView1.TabIndex = 0;
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
            this.TCNo.HeaderText = "TC No";
            this.TCNo.Name = "TCNo";
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.HeaderText = "DogumTarihi";
            this.DogumTarihi.Name = "DogumTarihi";
            // 
            // Durumu
            // 
            this.Durumu.HeaderText = "Durumu";
            this.Durumu.Name = "Durumu";
            // 
            // ilaclar
            // 
            this.ilaclar.HeaderText = "İlaçlar";
            this.ilaclar.Name = "ilaclar";
            // 
            // Aciklama
            // 
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.Name = "Aciklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Açıklama :";
            // 
            // doctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "doctorForm";
            this.Text = "Doctor Girişi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ila;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtİlaçlar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durumu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilaclar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.Label label1;
    }
}