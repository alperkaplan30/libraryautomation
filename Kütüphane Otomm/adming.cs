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
    public partial class adming : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\kütüphane4.accdb");
        public adming()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("Lütfen Giriş Bilgilerinizi Doldurunuz.");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Kullanıcı adınızı giriniz");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Şifre giriniz");
            }
            else
            {
                con.Open();
                OleDbCommand komut = new OleDbCommand("select * from admin where adminid='" + textBox3.Text.ToString() + "'", con);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                if (okuyucu.Read() == true)
                {
                    if (textBox3.Text.ToString() == okuyucu["adminid"].ToString() && textBox4.Text.ToString() == okuyucu["adminsifre"].ToString())

                    {
                        MessageBox.Show("Hoşgeldin " + okuyucu["adi"].ToString() + " " + okuyucu["soyadi"].ToString());
                        Form adminp = new adminp();
                        adminp.Show();
                        this.Hide();

                    }

                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı. Lütfen kontrol ediniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı. Lütfen kontrol ediniz.");
                }
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
