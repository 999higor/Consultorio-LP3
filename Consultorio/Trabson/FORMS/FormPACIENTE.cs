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
    public partial class FormPACIENTE : Form
    {
        public FormPACIENTE()
        {
            InitializeComponent();
        }

        private void FormPACIENTE_Load(object sender, EventArgs e)
        {
            this.tabela_load();
        }

        private void btCADASTRAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNOME.Text))
            {
                MessageBox.Show(" Verifique campos em Branco !", "Falha ao Inserir !" ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = 0;

                resultado = PacienteDAL.Cadastrar(txtNOME.Text, txtTELEFONE.Text);

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

        private void btEXCLUIR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluír esse Registro ?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show(" Verifique campos em Branco !", "Falha ao Excluír !" ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int resultado = 0;

                    resultado = PacienteDAL.Excluir(Convert.ToInt16(txtID.Text));


                    if (resultado == 1)
                    {
                        MessageBox.Show("Registro excluido com sucesso ! ! !");
                    }
                    else
                    {
                        MessageBox.Show("O Paciente : " + txtNOME.Text + " ainda possui Consultas !", "Falha na Exclusão");
                    }
                }

            }
            this.tabela_load();
        }

        private void btLIMPAR_Click(object sender, EventArgs e)
        {
            txtID.ResetText();
            txtNOME.ResetText();
            txtTELEFONE.ResetText();
            this.tabela_load();

        }

        private void btALTERAR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Alterar esse Registro ?", "Alterar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtID.Text) && string.IsNullOrEmpty(txtNOME.Text))
                {
                    MessageBox.Show(" Verifique campos em Branco !", "Falha ao Alterar !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    int resultado = 0;

                    resultado = PacienteDAL.Alterar(txtNOME.Text, txtTELEFONE.Text, Convert.ToInt16(txtID.Text));

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

        private void tabela_load()
        {
            DataSet ds = PacienteDAL.atualizaTabela();
            tabela.DataSource = ds;
            tabela.DataMember = ds.Tables[0].TableName;
        }

        private void btPESQUISAR_Click(object sender, EventArgs e)
        {
            DataSet ds = PacienteDAL.pesquisa(txtPESQUISA.Text);
            tabela.DataSource = ds;
            tabela.DataMember = ds.Tables[0].TableName;
        }

        private void selecionar_tabela(object sender, EventArgs e)
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
                txtID.Text = dr["ID"].ToString();
                txtNOME.Text = dr["Nome"].ToString();
                txtTELEFONE.Text = dr["Telefone"].ToString();
            }
        }
    }
}
