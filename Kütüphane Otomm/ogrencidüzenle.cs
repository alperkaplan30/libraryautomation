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
    public partial class ogrencidüzenle : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\kütüphane4.accdb");
        public ogrencidüzenle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand("update ogrenci set tcno='" + textBox1.Text + "',adi='" + textBox2.Text + "',soyadi='" + textBox3.Text + "',telefon='" + textBox4.Text + "',adres='" + textBox5.Text + "' where tcno='" + textBox1.Text + "'", con);
            komut.ExecuteNonQuery();
            MessageBox.Show("Öğrenci bilgileri başarıyla düzenlendi");
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand("select * from ogrenci where tcno LIKE'" + textBox1.Text.ToString() + "'", con);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                textBox2.Text = okuyucu["adi"].ToString();
                textBox3.Text = okuyucu["soyadi"].ToString();
                textBox4.Text = okuyucu["telefon"].ToString();
                textBox5.Text = okuyucu["adres"].ToString();
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

        private void ogrencidüzenle_Load(object sender, EventArgs e)
        {

        }
    }
}
