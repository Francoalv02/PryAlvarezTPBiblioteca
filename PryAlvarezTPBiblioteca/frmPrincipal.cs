using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryAlvarezTPBiblioteca
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBiblioteca frm1 = new frmBiblioteca();
            frm1.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
