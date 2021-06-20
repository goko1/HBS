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
    public partial class formGiris : Form
    {
        public string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB\HastaneBilgiSistemiDB.accdb";

        public formGiris()
        {

            InitializeComponent();

            
                

        }

        //Giris butonuna tıklanınca sisteme giriş yapılır.
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciTipi = comboboxKullaniciTipi.Text.Trim();
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string kullaniciSifre = txtSifre.Text.Trim();

            bool kullaniciDogrulandi = GirisDogruMu(kullaniciTipi,kullaniciAdi, kullaniciSifre);

            if (kullaniciDogrulandi == false)
            {
                MessageBox.Show("Kullanici adi veya şifreyi kontrol ediniz.");
            }
            else
            {
                if (kullaniciTipi == "Admin")
                {
                    this.Visible = false;
                    adminMenu adminMenu = new adminMenu();
                    adminMenu.Visible = true;
                }
                else if (kullaniciTipi == "Personel")
                {
                    //Giris işlemi için : database de bu kullanici adi ve şifresi doğru mu diye kontrol edilir:
                    this.Visible = false;
                    personelForm personelForm = new personelForm();
                    personelForm.Visible = true;
                }
                else if (kullaniciTipi == "Doktor")
                {
                    //Giriş işlemi için : database de bu kullanici adi ve şifresi doğru mu diye kontrol edilir:
                    this.Visible = false;
                    doctorForm personelForm = new doctorForm();
                    personelForm.Visible = true;
                }
            }
            

          

        }

        public bool GirisDogruMu(string kullaniciTipi, string kullaniciAdi, string sifre)
        {
            // Connection string and SQL query    //HastaneBilgiSistemiDB.accdb
            // OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HastaneBilgiSistemiDB.accdb");

            string strSQL = @"SELECT count(*) FROM Kullanicilar k INNER JOIN KullaniciTipi kt ON k.KullaniciTipi=kt.Id " +
                "where k.KullaniciAdi='"+kullaniciAdi+"'" +
                "and k.Sifre='"+sifre+"' " +
                "and kt.KullaniciTipi ='"+kullaniciTipi+"'";
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
                    int? varmi = (int)command.ExecuteScalar();

                    //Sql çalıştırdığımızda bir eşleşme varsa 0 dan büyük döner.
                    if (varmi > 0)
                    {
                        return true;
                    }
                    else        //Sql çalıştırdığımızsa bir eşleşme yoksa 0 sonucu döner.
                    {
                        return false;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu, doğrulama yapılamadı.");
                    return false;
                }
            }

        }
    }
}
