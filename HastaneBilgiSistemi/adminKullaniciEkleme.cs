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
    public partial class adminKullaniciEkle : Form
    {
        public static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB\HastaneBilgiSistemiDB.accdb";

        public adminKullaniciEkle()
        {
            InitializeComponent();
        }

        //Form açılırken kayıtlı kullanicilar eklenir
        private void adminForm_Load(object sender, EventArgs e)
        {
            //Kullanici silerken satır seçilsin
            dataGridKullanicilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridKullanicilar.MultiSelect = false;

             KullanicilariGetir();
        }

        private void KullanicilariGetir()
        {
            string strSQL = @"SELECT * FROM Kullanicilar";
            DataTable kullanicilarDataTable = new DataTable();

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
                    kullanicilarDataTable.Load(reader);
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu, kullanicilar getirilemedi.");
                }

                dataGridKullanicilar.DataSource = kullanicilarDataTable;
            }
        }

        //Tablo da seçilen kullanici silinir
        private void btnSil_Click(object sender, EventArgs e)
        {
            int silinecekKullaniciId;
            int selectedCount = dataGridKullanicilar.SelectedRows.Count;

            if (selectedCount == 1)
            {
                silinecekKullaniciId = Convert.ToInt32(dataGridKullanicilar.SelectedRows[0].Cells["Id"].Value);

                KullaniciyiSil(silinecekKullaniciId);
                   
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanici seçiniz.");
            }
        }

        private void KullaniciyiSil(int silinecekKullaniciId)
        {
            string sql = "Delete from kullanicilar where [Id] = ?";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Create a command and set its connection    
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Id", silinecekKullaniciId);
                    int i = command.ExecuteNonQuery();
                }
                
            }
            //Silinen kullanicilar datagrid view den çıkardığımızı göstermek için yeniliyoryz.
            KullanicilariGetir();
        }


        //çalışan personel eklenir
        private void btnKullaniciKaydet_Click(object sender, EventArgs e)
        {
            string kullaniciTipi = comboboxKullaniciTipi.Text;
            string kullaniciAdi = txtKullaniciGirisAdi.Text;
            string sifre = txtKullaniciSifre.Text;
            string ad = txtKullaniciAd.Text;
            string soyad = txtKullaniciSoyad.Text;
            DateTime dogumTarihi = dateTimeKullaniciDogumTarihi.Value;
            string tcNo = txtKullaniciTCNo.Text;


            if(string.IsNullOrEmpty(kullaniciTipi.Trim()) || 
                string.IsNullOrEmpty(kullaniciAdi.Trim()) ||
                string.IsNullOrEmpty(sifre.Trim())||
                string.IsNullOrEmpty(ad.Trim())||
                string.IsNullOrEmpty(soyad.Trim())||
                string.IsNullOrEmpty(tcNo))
            {
                MessageBox.Show("Lütfen bütün bilgileri girdikten sonra tekrar deneyiniz.");
                return;
            }

            string sql = "INSERT INTO Kullanicilar " +
                    "(KullaniciTipi, KullaniciAdi,Sifre,Ad,Soyad,DogumTarihi,TCNo) " +
                    " VALUES " +
                    "('" + kullaniciTipi + "', '" + kullaniciAdi + "','" + sifre + "','" + ad + "','" + soyad + "','" + dogumTarihi + "','" + tcNo + "')";


            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand eklemeCommand = new OleDbCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        var cevap = eklemeCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Bir hata oluştu :"+ex);;
                    }
                   
                }
            }

            //yeni bir kayıt eklendiğinde grid view güncelle.
            KullanicilariGetir();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            adminMenu adminMenu = new adminMenu();
            adminMenu.Visible = true;
        }
    }
}
