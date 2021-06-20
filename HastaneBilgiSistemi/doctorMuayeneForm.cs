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
    public partial class doctorMuayeneForm : Form
    {
        public int doctorId { get; set; }
        public string kullaniciAdi { get; set; }
        public static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB\HastaneBilgiSistemiDB.accdb";

        public doctorMuayeneForm(string kullaniciTipi, string kullaniciAdi, string kullaniciSifre)
        {
            InitializeComponent();

            doctorId = DoctorIdBul(kullaniciTipi, kullaniciAdi, kullaniciSifre);
        }

        private int DoctorIdBul(string kullaniciTipi, string kullaniciAdi, string kullaniciSifre)
        {
            return 1;
        }


        //Muayene durumu güncellenir, hastanın durumu Bekliyor durumundan Tedavi Edildi durumuna çevrilir.
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int durumuGuncellenecekHasta;
            int selectedCount = dataGridHastalar.SelectedRows.Count;

            if (selectedCount == 1)
            {
                durumuGuncellenecekHasta = Convert.ToInt32(dataGridHastalar.SelectedRows[0].Cells["Id"].Value);
                HastaDurumunuGuncelle(durumuGuncellenecekHasta);
            }
            else
            {
                MessageBox.Show("Lütfen bir hasta seçiniz.");
            }
        }

        private void HastaDurumunuGuncelle(int durumuGuncellenecekHastaId)
        {
            string secilenDurum = cmbDurum.Text;

            if(string.IsNullOrEmpty(secilenDurum))
            {
                MessageBox.Show("Lütfen güncellemek için hasta durumu seçiniz");
                return;
            }
            string aciklama = txtAciklama.Text;
            string ilaclar = txtilaclar.Text;

            string sql = "Update Hastakayitlari SET [Durum]=?, [Aciklama]=?, [İlaclar]=? " +
                "where [Id] = ?";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Create a command and set its connection    
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@Durum", secilenDurum);
                        command.Parameters.AddWithValue("@Aciklama", aciklama);
                        command.Parameters.AddWithValue("@İlaclar", ilaclar);
                        command.Parameters.AddWithValue("@Id", durumuGuncellenecekHastaId);

                        int i = command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Bir hata oluştu.");;
                    }              
                }

            }

            HastalarıGetir();

        }

        private void doctorMuayeneForm_Load(object sender, EventArgs e)
        {
            dataGridHastalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridHastalar.MultiSelect = false;

            HastalarıGetir();


        }

        private void HastalarıGetir()
        {
            dataGridHastalar.DataSource = null;

            //            string strSQL = @"SELECT Doktorlar.ID, HastaneBolumler.BolumAdi, HastaneBolumler.Aciklama, Kullanicilar.KullaniciAdi, Kullanicilar.Ad, Kullanicilar.Soyad, Kullanicilar.DogumTarihi, Kullanicilar.TCNo
            //FROM Kullanicilar INNER JOIN (HastaneBolumler INNER JOIN Doktorlar ON HastaneBolumler.[ID] = Doktorlar.[HastaneBolumId]) ON Kullanicilar.[Id] = Doktorlar.[KullaniciId];";

            string strSQL = @"SELECT * from HastaKayitlari";
            DataTable hastaKayitlari = new DataTable();

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
                    hastaKayitlari.Load(reader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu, doktor ve bolumleri getirilemedi.");
                }

                dataGridHastalar.DataSource = hastaKayitlari;
            }
        }
    }
}
