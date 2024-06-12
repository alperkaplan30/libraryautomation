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
    public partial class kitapver : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\kütüphane4.accdb");
        DataTable dt = new DataTable();
        public kitapver()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand("insert into kitapver (tcno,adi,soyadi,telefon,adres,barkodno,kitapad,yazar,sayfas,rafno,verilistarihi,teslimtarihi) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')", con);
            komut.ExecuteNonQuery();
            dt.Clear();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from kitapver", con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("Başarıyla kaydedildi");
            con.Close();

        }

        private void kitapver_Load(object sender, EventArgs e)
        {
            con.Open();
            dt.Clear();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from kitapver", con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
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

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand("select * from kitap where barkodno LIKE'" + textBox10.Text.ToString() + "'", con);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                textBox9.Text = okuyucu["kitapad"].ToString();
                textBox8.Text = okuyucu["yazar"].ToString();
                textBox7.Text = okuyucu["sayfas"].ToString();
                textBox6.Text = okuyucu["rafno"].ToString();
            }
            con.Close();
        }
    }
}
