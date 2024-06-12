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
    public partial class gecikenkitap : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\kütüphane4.accdb");
        public gecikenkitap()
        {
            InitializeComponent();
        }

        private void gecikenkitap_Load(object sender, EventArgs e)
        {
            string tarih = DateTime.Now.ToShortDateString();
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from kitapver where teslimtarihi <'" + tarih + "'", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
