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
    public partial class adminKullaniciEkle : Form
    {
        public adminKullaniciEkle()
        {
            InitializeComponent();
        }

        private void adminForm_Load(object sender, EventArgs e)
        {

        }

        //Tablo da seçilen kullanici silinir
        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        //doctor eklenir
        private void btnDoctorKaydet_Click(object sender, EventArgs e)
        {

        }

        //çalışan personel eklenir
        private void btnKullaniciKaydet_Click(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            adminMenu adminMenu = new adminMenu();
            adminMenu.Visible = true;
        }
    }
}
