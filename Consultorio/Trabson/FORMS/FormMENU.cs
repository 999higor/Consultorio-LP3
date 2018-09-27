using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabson.FORMS;

namespace Trabson
{
    public partial class FormMENU : Form
    {
        public FormMENU()
        {
            InitializeComponent();
        }

        private void médicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormMEDICO().ShowDialog();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormPACIENTE().ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCONSULTA().ShowDialog();
        }

        private void relatórioPorDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormRELATORIO().ShowDialog();
        }
    }
}
