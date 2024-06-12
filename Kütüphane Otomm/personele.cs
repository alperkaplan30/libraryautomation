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
    public partial class personele : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\kütüphane4.accdb");
        public personele()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand("insert into kullanicigirisi (kullaniciadi,sifre,adi,soyadi) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
            komut.ExecuteNonQuery();
            MessageBox.Show("Personel Kaydedildi");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
