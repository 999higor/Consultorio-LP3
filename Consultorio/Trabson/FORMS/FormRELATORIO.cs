using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabson.DAL;

namespace Trabson.FORMS
{
    public partial class FormRELATORIO : Form
    {
        public FormRELATORIO()
        {
            InitializeComponent();
        }

        private void FormRELATORIO_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtbPESQUISA.Text))
            {
                MessageBox.Show(" Verifique campos em Branco !", "Falha ao Pesquisar !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataSet ds = RelatorioDAL.pesquisa(mtbPESQUISA.Text);
                tabela.DataSource = ds;
                tabela.DataMember = ds.Tables[0].TableName;
            }
        }
    }
}
