using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp72
{
    public partial class FrmSınavSorumlusuGiris : Form
    {
        SqlConnection baglanti = new SqlConnection("data source=DESKTOP-2EB8G19;initial catalog=YazilimYapimiProje; integrated security=true;");

        public FrmSınavSorumlusuGiris()
        {
            InitializeComponent();
        }

        private void Btn_Giris_Click(object sender, EventArgs e) //sınav sorumlusu girişinin yapılması
        {
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Tbl_SınavS where SınavSKadi='" + txtKadi2.Text + "' AND SınavSSifre='" + txtSifre2.Text + "'", baglanti);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.Read()) //sqlcommand'dan dönen bir sonuc varsa onu okur.
            {
                MessageBox.Show("Giris Basarılı");
                FrmSoruHazırlama soruHazırlama = new FrmSoruHazırlama();
                this.Hide();
                soruHazırlama.Show();
            }


            else //yoksa veri bulunamaz ve hata verir.
                MessageBox.Show("Giris Hatali");
            baglanti.Close();
        }

        private void FrmSınavSorumlusuGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
            frmAnaSayfa.Show();
            this.Hide();
        }
    }
}
