namespace HastaneBilgiSistemi
{
    partial class doctorMuayeneForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSikayet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ila = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtilaclar = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGridHastalar = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbDurum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSikayet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ila);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.txtilaclar);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.dataGridHastalar);
            this.groupBox1.Location = new System.Drawing.Point(38, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hastalarım";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Durum :";
            // 
            // cmbDurum
            // 
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "MuayeneEdildi",
            "SevkEdildi"});
            this.cmbDurum.Location = new System.Drawing.Point(85, 289);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(135, 21);
            this.cmbDurum.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şikayet : ";
            // 
            // txtSikayet
            // 
            this.txtSikayet.Location = new System.Drawing.Point(85, 201);
            this.txtSikayet.Multiline = true;
            this.txtSikayet.Name = "txtSikayet";
            this.txtSikayet.Size = new System.Drawing.Size(135, 59);
            this.txtSikayet.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Açıklama :";
            // 
            // ila
            // 
            this.ila.AutoSize = true;
            this.ila.Location = new System.Drawing.Point(256, 208);
            this.ila.Name = "ila";
            this.ila.Size = new System.Drawing.Size(41, 13);
            this.ila.TabIndex = 4;
            this.ila.Text = "İlaçlar :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(575, 204);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(154, 56);
            this.txtAciklama.TabIndex = 3;
            // 
            // txtilaclar
            // 
            this.txtilaclar.Location = new System.Drawing.Point(320, 201);
            this.txtilaclar.Multiline = true;
            this.txtilaclar.Name = "txtilaclar";
            this.txtilaclar.Size = new System.Drawing.Size(135, 59);
            this.txtilaclar.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(320, 289);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 34);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Muayene Güncelle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridHastalar
            // 
            this.dataGridHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHastalar.Location = new System.Drawing.Point(16, 31);
            this.dataGridHastalar.Name = "dataGridHastalar";
            this.dataGridHastalar.Size = new System.Drawing.Size(840, 142);
            this.dataGridHastalar.TabIndex = 0;
            // 
            // doctorMuayeneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "doctorMuayeneForm";
            this.Text = "Doctor Muayene Form";
            this.Load += new System.EventHandler(this.doctorMuayeneForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHastalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ila;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtilaclar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataGridHastalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSikayet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDurum;
    }
}