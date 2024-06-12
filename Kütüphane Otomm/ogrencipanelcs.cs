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
    public partial class ogrencipanelcs : Form
    {
        public ogrencipanelcs()
        {
            InitializeComponent();
        }

        private void kitaplarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kitapl = new kitaplistele();
            kitapl.Show();
        }

        private void ogrencipanelcs_Load(object sender, EventArgs e)
        {

        }
    }
}
