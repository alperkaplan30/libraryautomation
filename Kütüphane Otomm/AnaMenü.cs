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
    public partial class AnaMenü : Form
    {
        public static AnaMenü mdiobj;
        public AnaMenü()
        {
            
            InitializeComponent();
        }

        private void AnaMenü_Load(object sender, EventArgs e)
        {
            

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form ogrencie = new ogrenciekle();
            ogrencie.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form ogrencis = new ogrencis();
            ogrencis.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form ogrenciduzenle = new ogrencidüzenle();
            ogrenciduzenle.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form ogrencilistele = new ogrencilistele();
            ogrencilistele.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form kitape = new kitapekle();
            kitape.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Form kitaps = new kitapsil();
            kitaps.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Form kitapd = new kitapduzenle();
            kitapd.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Form kitapl = new kitaplistele();
            kitapl.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Form kitapv = new kitapver();
            kitapv.Show();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Form geckit = new gecikenkitap();
            geckit.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
