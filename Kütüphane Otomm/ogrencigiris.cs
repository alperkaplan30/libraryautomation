using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Kütüphane_Otomm
{
    public partial class ogrencigiris : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\kütüphane4.accdb");
        public ogrencigiris()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Lütfen Giriş Bilgilerinizi Doldurunuz.");
            }
            else
            {
                con.Open();
                OleDbCommand komut = new OleDbCommand("select * from ogrenci where tcno='" + textBox3.Text.ToString() + "'", con);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                if (okuyucu.Read() == true)
                {
                    if (textBox3.Text.ToString() == okuyucu["tcno"].ToString())

                    {                                                                                           
                        MessageBox.Show("Hoşgeldin " + okuyucu["adi"].ToString() + " " + okuyucu["soyadi"].ToString());
                        Form ogrencip = new ogrencipanelcs();
                        ogrencip.Show();
                        this.Hide();
                    }                  
                }
                else
                {
                    MessageBox.Show("TC No Hatalı. Lütfen TC Kimlik Numaranızı Kontrol Ediniz");
                }
                con.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
