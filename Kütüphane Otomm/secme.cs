using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomm
{
    public partial class secme : Form
    {
        public secme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ogrencig = new ogrencigiris();
            ogrencig.Show();
            this.Hide();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Form admin = new adming();
            admin.Show();
            this.Hide();
        }
    }
}
