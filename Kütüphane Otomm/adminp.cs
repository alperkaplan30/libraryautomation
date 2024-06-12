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
    public partial class adminp : Form
    {
        public adminp()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
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

        private void personelBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pekle = new personele();
            pekle.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form psil = new personels();
            psil.Show();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form perd = new personeld();
            perd.Show();
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form plist = new personell();
            plist.Show();
        }

        private void adminp_Load(object sender, EventArgs e)
        {

        }
    }
}
