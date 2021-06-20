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
    public partial class adminDoktorAtamaForm : Form
    {
        public static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB\HastaneBilgiSistemiDB.accdb";

        public adminDoktorAtamaForm()
        {
            InitializeComponent();
        }

        private void adminDoktorAtamaForm_Load(object sender, EventArgs e)
        {
            //Kullanici silerken satır seçilsin
            dataGridHastaneBolumleriVeDoktorlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridHastaneBolumleriVeDoktorlar.MultiSelect = false;
            AtananDoktorlariGetir();

            HastaneBolumleriniGetir();
            DoktorlariGetir();

        }

        private void DoktorlariGetir()
        {
            cmbDoktorlar.DataSource = null;

            string strSQL = @"SELECT Kullanicilar.Id, Kullanicilar.KullaniciTipi, Kullanicilar.KullaniciAdi
            FROM Kullanicilar WHERE Kullanicilar.[KullaniciTipi] ='Doktor'; ";

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

        private void HastaneBolumleriniGetir()
        {
            cmbHastaneBolumleri.DataSource = null;

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

                cmbHastaneBolumleri.DataSource = HastaneBolumleri;
                cmbHastaneBolumleri.ValueMember = "Id";
                cmbHastaneBolumleri.DisplayMember = "BolumAdi";
            }
        }

        private void AtananDoktorlariGetir()
        {
            dataGridHastaneBolumleriVeDoktorlar.DataSource = null;

            string strSQL = @"SELECT Doktorlar.ID, HastaneBolumler.BolumAdi, HastaneBolumler.Aciklama, Kullanicilar.KullaniciAdi, Kullanicilar.Ad, Kullanicilar.Soyad, Kullanicilar.DogumTarihi, Kullanicilar.TCNo
FROM Kullanicilar INNER JOIN (HastaneBolumler INNER JOIN Doktorlar ON HastaneBolumler.[ID] = Doktorlar.[HastaneBolumId]) ON Kullanicilar.[Id] = Doktorlar.[KullaniciId];";
            DataTable doktorlarDataTable = new DataTable();

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
                    doktorlarDataTable.Load(reader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu, doktor ve bolumleri getirilemedi.");
                }

                dataGridHastaneBolumleriVeDoktorlar.DataSource = doktorlarDataTable;
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            adminMenu adminMenu = new adminMenu();
            adminMenu.Visible = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int silinecekKullaniciId;
            int selectedCount = dataGridHastaneBolumleriVeDoktorlar.SelectedRows.Count;

            if (selectedCount == 1)
            {
                silinecekKullaniciId = Convert.ToInt32(dataGridHastaneBolumleriVeDoktorlar.SelectedRows[0].Cells["Id"].Value);

                DoktoruAtamadanSil(silinecekKullaniciId);

            }
            else
            {
                MessageBox.Show("Lütfen bir kullanici seçiniz.");
            }
        }

        private void DoktoruAtamadanSil(int silinecekKullaniciId)
        {
            string sql = "Delete from Doktorlar where [Id] = ?";
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
            //silindikten sonra tablo güncellenir : 
            AtananDoktorlariGetir();
        }

        private void btnDoktorKaydet_Click(object sender, EventArgs e)
        {
            int doktorId;
            bool doktorIdAlındıMı = int.TryParse(cmbDoktorlar.SelectedValue.ToString(), out doktorId);

            int bolumId;
            bool bolumIdAlındıMı = int.TryParse(cmbHastaneBolumleri.SelectedValue.ToString(), out bolumId);

            if(doktorIdAlındıMı!=true ||
                bolumIdAlındıMı != true)
            {
                MessageBox.Show("Bolum veya doktor bilgisi comboboxlardan okunamadi.");
            }
            else
            {
                string sql = "INSERT INTO Doktorlar " +
                   "(KullaniciId, HastaneBolumId) " +
                   " VALUES " +
                   "('" + doktorId + "','" + bolumId + "')";


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

                            MessageBox.Show("Bir hata oluştu :" + ex); ;
                        }

                    }
                }

                //yeni bir kayıt eklendiğinde grid view güncelle.
                AtananDoktorlariGetir();
            }
        }
    }
}
