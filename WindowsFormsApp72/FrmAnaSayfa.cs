using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp72
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        //giriş için gerekli yönlendirmeler
        private void Btn_Ogrenci_Click(object sender, EventArgs e)
        {
            FrmOgrenciGiris ogrenciGiris = new FrmOgrenciGiris();
            ogrenciGiris.Show();
            this.Hide();

        }

        private void Btn_SınavS_Click(object sender, EventArgs e)
        {
            FrmSınavSorumlusuGiris sınavSorumlusu = new FrmSınavSorumlusuGiris();
            
            sınavSorumlusu.Show();
            this.Hide();
        }

        private void Btn_Admin_Click(object sender, EventArgs e)
        {
            FrmAdminGiris admin = new FrmAdminGiris();
            
            admin.Show();
            this.Hide();
        }

        private void Btn_Kayit_Click(object sender, EventArgs e)
        {
            FrmKayıt kayıt = new FrmKayıt();
            kayıt.Show();
            this.Hide();
        }

       
    }
}
