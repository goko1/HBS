using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneBilgiSistemi
{
    public partial class formGiris : Form
    {
        public formGiris()
        {

            InitializeComponent();

            bool dbOk = false;
            //ilk önce db bağlantısı yapıyoruz, sistem db bağlanmalı veyahut hata verip çalışmamalı.
            try
            {
                MessageBox.Show("Test");
                int i = int.Parse("dsd2");
                dbOk = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database bağlantısı sağlanırken bir hata oluştu.\n" +
                    "Hatayı giderip uygulamayı tekrar açınız.\n" +
                    "\nHata:"+ex);
                return;
            }


        }

        //Giris butonuna tıklanınca sisteme giriş yapılır.
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciTipi = comboboxKullaniciTipi.Text.Trim();
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string kullaniciSifre = txtSifre.Text.Trim();

            bool kullaniciDogrulandi = false;

            if (kullaniciTipi == "Admin")
            {
                if(kullaniciAdi == "Admin" && kullaniciSifre == "sifre")
                {
                    this.Visible = false;
                    adminForm adminForm = new adminForm();
                    adminForm.Visible = true;
                    kullaniciDogrulandi = true;
                }
            }
            else if (kullaniciTipi == "Personel")
            {
                //Giris işlemi için : database de bu kullanici adi ve şifresi doğru mu diye kontrol edilir:
                kullaniciDogrulandi = true;

            }
            else if(kullaniciTipi == "Doktor")
            {
                //Giriş işlemi için : database de bu kullanici adi ve şifresi doğru mu diye kontrol edilir:
                kullaniciDogrulandi = true;
            }
            else
            {
                MessageBox.Show("Kullanici Tipi bulunamadi.");
            }

            if(kullaniciDogrulandi == false)
            {
                MessageBox.Show("Kullanici adi veya şifreyi kontrol ediniz.");
            }

        }
    }
}
