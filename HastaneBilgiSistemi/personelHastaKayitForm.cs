using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneBilgiSistemi
{
    public partial class personelHastaKayitForm : Form
    {
        public static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB\HastaneBilgiSistemiDB.accdb";

        public personelHastaKayitForm()
        {
            InitializeComponent();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            int doktorId;
            bool doktorIdAlındıMı = int.TryParse(cmbDoktorlar.SelectedValue.ToString(), out doktorId);

            int bolumId;
            bool bolumIdAlındıMı = int.TryParse(cmbHastaneBolumLeri.SelectedValue.ToString(), out bolumId);

            if (doktorIdAlındıMı != true ||
                bolumIdAlındıMı != true)
            {
                MessageBox.Show("Bolum veya doktor bilgisi comboboxlardan okunamadi.");
            }

            string ad = txtHastaAdi.Text;
            string soyad = txtSoyad.Text;
            string TCNo = txtTCNo.Text;
            DateTime dogumTarihi = dateTimeDogumTarihi.Value;
            string sikayet = txtSikayet.Text;

            if(string.IsNullOrEmpty(ad.Trim()) ||
                string.IsNullOrEmpty(soyad.Trim()) ||
                string.IsNullOrEmpty(TCNo.Trim()) ||
                string.IsNullOrEmpty(sikayet))
            {
                MessageBox.Show("Lütfen boş alanları doldurup deneyiniz.");
                return;
            }

            //bilgiler ok ise hasta kaydı oluşturalım.
            string sql = "INSERT INTO HastaKayitlari " +
                    "(Ad, Soyad,TCNo,DogumTarihi,BolumId,DoctorId,Sikayet) " +
                    " VALUES " +
                    "('" + ad + "', '" + soyad + "','" + TCNo + "','" + dogumTarihi + "','" + bolumId + "','" + doktorId + "','" + sikayet + "')";

            int cevap = 0;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand eklemeCommand = new OleDbCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        cevap = eklemeCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Bir hata oluştu :" + ex); ;
                    }

                }
            }

            if (cevap > 0)
            {
                MessageBox.Show("Hasta kaydı başarılı bir şekilde eklendi.");
            }
            else
            {
                MessageBox.Show("Hasta kaydı oluşturulurken bir hata oluştu.");
            }



        }

        private void personelHastaKayitForm_Load(object sender, EventArgs e)
        {
            this.cmbHastaneBolumLeri.SelectedValueChanged -= new System.EventHandler(this.cmbHastaneBolumLeri_SelectedValueChanged);
            HastaneBolumleriniGetir();
            this.cmbHastaneBolumLeri.SelectedValueChanged += new System.EventHandler(this.cmbHastaneBolumLeri_SelectedValueChanged);
        }

        private void HastaneBolumleriniGetir()
        {
            cmbHastaneBolumLeri.DataSource = null;

            string strSQL = @"SELECT HastaneBolumler.Id, HastaneBolumler.BolumAdi from HastaneBolumler;";
            DataTable HastaneBolumleri = new DataTable();

            // Create a connection    
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Create a command and set its connection    
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                // Open the connection and execute the select command.    
                try
                {
                    // Open connecton    
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    HastaneBolumleri.Load(reader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu, doktor ve bolumleri getirilemedi.");
                }

                cmbHastaneBolumLeri.DataSource = HastaneBolumleri;
                cmbHastaneBolumLeri.ValueMember = "Id";
                cmbHastaneBolumLeri.DisplayMember = "BolumAdi";
            }
        }

        private void cmbHastaneBolumLeri_SelectedValueChanged(object sender, EventArgs e)
        {
            string secilenBolum = cmbHastaneBolumLeri.Text;
            AtananBolumunDoktorlariGetir(secilenBolum);
        }


       
        private void AtananBolumunDoktorlariGetir(string bolum)
        {
            cmbDoktorlar.DataSource = null;


            string strSQL = @"SELECT Doktorlar.Id, HastaneBolumler.BolumAdi, Kullanicilar.KullaniciAdi
FROM HastaneBolumler INNER JOIN (Kullanicilar INNER JOIN Doktorlar ON Kullanicilar.[Id] = Doktorlar.[KullaniciId]) ON HastaneBolumler.[ID] = Doktorlar.[HastaneBolumId] 
 WHERE HastaneBolumler.BolumAdi='"+bolum+"' ; ";


            DataTable HastaneBolumleri = new DataTable();

            // Create a connection    
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Create a command and set its connection    
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                // Open the connection and execute the select command.    
                try
                {
                    // Open connecton    
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    HastaneBolumleri.Load(reader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu, doktor ve bolumleri getirilemedi.");
                }

                cmbDoktorlar.DataSource = HastaneBolumleri;
                cmbDoktorlar.ValueMember = "Id";
                cmbDoktorlar.DisplayMember = "KullaniciAdi";
            }
        }
    }
}
