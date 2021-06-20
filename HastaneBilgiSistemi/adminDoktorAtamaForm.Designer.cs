
namespace HastaneBilgiSistemi
{
    partial class adminDoktorAtamaForm
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
            this.cmbHastaneBolumleri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDoktorlar = new System.Windows.Forms.ComboBox();
            this.btnDoktorKaydet = new System.Windows.Forms.Button();
            this.dataGridHastaneBolumleriVeDoktorlar = new System.Windows.Forms.DataGridView();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHastaneBolumleriVeDoktorlar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbHastaneBolumleri
            // 
            this.cmbHastaneBolumleri.FormattingEnabled = true;
            this.cmbHastaneBolumleri.Location = new System.Drawing.Point(144, 44);
            this.cmbHastaneBolumleri.Name = "cmbHastaneBolumleri";
            this.cmbHastaneBolumleri.Size = new System.Drawing.Size(121, 21);
            this.cmbHastaneBolumleri.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hastane Bölümleri : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doktorlar :";
            // 
            // cmbDoktorlar
            // 
            this.cmbDoktorlar.FormattingEnabled = true;
            this.cmbDoktorlar.Location = new System.Drawing.Point(144, 82);
            this.cmbDoktorlar.Name = "cmbDoktorlar";
            this.cmbDoktorlar.Size = new System.Drawing.Size(121, 21);
            this.cmbDoktorlar.TabIndex = 3;
            // 
            // btnDoktorKaydet
            // 
            this.btnDoktorKaydet.Location = new System.Drawing.Point(176, 135);
            this.btnDoktorKaydet.Name = "btnDoktorKaydet";
            this.btnDoktorKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnDoktorKaydet.TabIndex = 4;
            this.btnDoktorKaydet.Text = "Kaydet";
            this.btnDoktorKaydet.UseVisualStyleBackColor = true;
            this.btnDoktorKaydet.Click += new System.EventHandler(this.btnDoktorKaydet_Click);
            // 
            // dataGridHastaneBolumleriVeDoktorlar
            // 
            this.dataGridHastaneBolumleriVeDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHastaneBolumleriVeDoktorlar.Location = new System.Drawing.Point(40, 231);
            this.dataGridHastaneBolumleriVeDoktorlar.Name = "dataGridHastaneBolumleriVeDoktorlar";
            this.dataGridHastaneBolumleriVeDoktorlar.Size = new System.Drawing.Size(415, 150);
            this.dataGridHastaneBolumleriVeDoktorlar.TabIndex = 5;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(278, 403);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(380, 403);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // adminDoktorAtamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridHastaneBolumleriVeDoktorlar);
            this.Controls.Add(this.btnDoktorKaydet);
            this.Controls.Add(this.cmbDoktorlar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHastaneBolumleri);
            this.Name = "adminDoktorAtamaForm";
            this.Text = "Doktor Atama Form";
            this.Load += new System.EventHandler(this.adminDoktorAtamaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHastaneBolumleriVeDoktorlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHastaneBolumleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDoktorlar;
        private System.Windows.Forms.Button btnDoktorKaydet;
        private System.Windows.Forms.DataGridView dataGridHastaneBolumleriVeDoktorlar;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnSil;
    }
}