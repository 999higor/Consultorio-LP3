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
    public partial class FormMEDICO : Form
    {
        public FormMEDICO()
        {
            InitializeComponent();
        }

        private void BTCADASTRAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNOMEMEDICO.Text) && string.IsNullOrEmpty(txtCRM.Text))
            {
                MessageBox.Show(" Verifique campos em Branco !", "Falha ao Inserir !" ,MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = 0;

                resultado = MedicoDAL.Cadastrar(txtNOMEMEDICO.Text, txtCRM.Text);

                if (resultado == 1)
                {
                    MessageBox.Show("Registro inserido com sucesso ! ! !");
                }
                else
                {
                    MessageBox.Show("Falha ao inserir o registro  ! ! !");
                }
            }
            this.tabela_load();

        }

        private void BTALTERAR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Alterar esse Registro ?", "Alterar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if ((txtIDMEDICO.Text == string.Empty) && (txtNOMEMEDICO.Text == string.Empty) && (txtCRM.Text == string.Empty))
                {
                    MessageBox.Show(" Verifique campos em Branco !", "Falha ao Alterar !" ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int resultado = 0;

                    resultado = MedicoDAL.Alterar(txtNOMEMEDICO.Text, txtCRM.Text, Convert.ToInt16(txtIDMEDICO.Text));


                    if (resultado == 1)
                    {
                        MessageBox.Show("Registro alterado com sucesso ! ! !");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao alterar o registro  ! ! !");
                    }
                }
            }
            this.tabela_load();
        }

        private void BTEXCLUIR_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja Excluir esse Registro ?" ,"Excluír Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation , MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (txtIDMEDICO.Text == string.Empty)
                {
                    MessageBox.Show(" Verifique campos em Branco !", "Falha ao Excluír !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int resultado = 0;

                    resultado = MedicoDAL.Excluir(Convert.ToInt16(txtIDMEDICO.Text));

                    if (resultado == 1)
                    {
                        MessageBox.Show("Registro excluido com sucesso ! ! !");
                    }
                    else
                    {
                        MessageBox.Show("O Médico : " + txtNOMEMEDICO.Text + " ainda possui Consultas !", "Falha na Exclusão");
                    }
                }
            }

            
            this.tabela_load();
        }

        private void tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabela_load()
        {
            DataSet ds = MedicoDAL.atualizaTabela();
            tabela.DataSource = ds;
            tabela.DataMember = ds.Tables[0].TableName;
        }

        private void BTLIMPAR_Click(object sender, EventArgs e)
        {
            txtIDMEDICO.ResetText();
            txtNOMEMEDICO.ResetText();
            txtCRM.ResetText();
            this.tabela_load();
        }

        private void FormMEDICO_Load(object sender, EventArgs e)
        {
            this.tabela_load();
        }

        private void btPESQUISAR_Click(object sender, EventArgs e)
        {
            DataSet ds = MedicoDAL.pesquisa(txtPESQUISA.Text);
            tabela.DataSource = ds;
            tabela.DataMember = ds.Tables[0].TableName;
        }

        private void selecionar_Tabela(object sender, EventArgs e)
        {
            int selecionado = -1;

            if (tabela.SelectedRows.Count > 0)
            {
                selecionado = tabela.SelectedRows[0].Index;
            }
            else
            {
                if (tabela.SelectedCells.Count > 0)
                {
                    selecionado = tabela.SelectedCells[0].RowIndex;
                }
            }

            if (selecionado != -1)
            {
                DataRowView dr = (DataRowView)tabela.Rows[selecionado].DataBoundItem;
                txtIDMEDICO.Text = dr["ID"].ToString();
                txtNOMEMEDICO.Text = dr["Nome"].ToString();
                txtCRM.Text = dr["CRM"].ToString();
            }
        }
    }
}
