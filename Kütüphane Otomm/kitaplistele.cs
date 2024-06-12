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
    public partial class kitaplistele : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\kütüphane4.accdb");
        DataTable dt = new DataTable();
        public kitaplistele()
        {
            InitializeComponent();
        }

        private void kitaplistele_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from kitap", con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
