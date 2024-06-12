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
    public partial class personeld : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\kütüphane4.accdb");
        public personeld()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand("update kullanicigirisi set kullaniciadi='" + textBox1.Text + "',sifre='" + textBox2.Text + "',adi='" + textBox3.Text + "',soyadi='" + textBox4.Text + "' where kullaniciadi='" + textBox1.Text + "'", con);
            komut.ExecuteNonQuery();
            MessageBox.Show("Personel bilgileri başarıyla düzenlendi");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand("select * from kullanicigirisi where kullaniciadi LIKE'" + textBox1.Text.ToString() + "'", con);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                textBox2.Text = okuyucu["sifre"].ToString();
                textBox3.Text = okuyucu["adi"].ToString();
                textBox4.Text = okuyucu["soyadi"].ToString();
                
            }
            con.Close();
        }
    }
}
