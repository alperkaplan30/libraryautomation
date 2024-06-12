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
    public partial class personels : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\kütüphane4.accdb");
        public personels()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand("delete from kullanicigirisi where kullaniciadi='" + textBox1.Text + "'", con);
            komut.ExecuteNonQuery();
            MessageBox.Show("Personel başarıyla silindi");
            con.Close();
        }
    }
}
