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
    public partial class kitapduzenle : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\kütüphane4.accdb");
        public kitapduzenle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand("update kitap set barkodno='" + textBox1.Text + "',kitapad='" + textBox2.Text + "',yazar='" + textBox3.Text + "',sayfas='" + textBox4.Text + "',rafno='" + textBox5.Text + "' where barkodno='" + textBox1.Text + "'", con);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kitap bilgileri başarıyla düzenlendi");
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand("select * from kitap where barkodno LIKE'" + textBox1.Text.ToString() + "'", con);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                textBox2.Text = okuyucu["kitapad"].ToString();
                textBox3.Text = okuyucu["yazar"].ToString();
                textBox4.Text = okuyucu["sayfas"].ToString();
                textBox5.Text = okuyucu["rafno"].ToString();
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
