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
    public partial class FormCONSULTA : Form
    {
        public FormCONSULTA()
        {
            InitializeComponent();
            this.carregaComboMedico();
            this.carregaComboPaciente();
            //txtDATACONSULTA.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            //txtDATAINICIO.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            //txtHORAFIM.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void FormCONSULTA_Load(object sender, EventArgs e)
        {

            this.tabela_load();
        }

        private void carregaComboMedico()
        {
            //criar um DataTable
            DataTable dtTabelas = ConsultaDAL.atualizaComboMedico();

            //carrega as informacoes no combo
            comboMEDICO.DataSource = dtTabelas;
            comboMEDICO.DisplayMember = "nomeMedico";
            comboMEDICO.ValueMember = "IdMedico";

        }

        private void carregaComboPaciente()
        {
            //criar um DataTable
            DataTable dtTabelas = ConsultaDAL.atualizaComboPaciente();

            //carrega as informacoes no combo
            comboPACIENTE.DataSource = dtTabelas;
            comboPACIENTE.DisplayMember = "nomePaciente";
            comboPACIENTE.ValueMember = "IdPaciente";

        }

        private void tabela_load()
        {
            DataSet ds = ConsultaDAL.atualizaTabela();
            tabela.DataSource = ds;
            tabela.DataMember = ds.Tables[0].TableName;
        }

        private void btCADASTRAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDATACONSULTA.Text) && string.IsNullOrEmpty(txtDATAINICIO.Text) && string.IsNullOrEmpty(txtHORAFIM.Text))
            {
                MessageBox.Show(" Verifique campos em Branco !", "Falha ao Inserir !" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);              
            }
            else
            {
                int resultado = 0;

                resultado = ConsultaDAL.Cadastrar(Convert.ToInt16(comboMEDICO.SelectedValue), Convert.ToInt16(comboPACIENTE.SelectedValue), Convert.ToDateTime(txtDATACONSULTA.Text), Convert.ToDateTime(txtDATAINICIO.Text), Convert.ToDateTime(txtHORAFIM.Text), txtOBSERVACAO.Text, chkATIVO.Checked);

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

        private void btALTERAR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Alterar esse Registro ?", "Alterar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtDATACONSULTA.Text) && string.IsNullOrEmpty(txtDATAINICIO.Text) && string.IsNullOrEmpty(txtHORAFIM.Text) && string.IsNullOrEmpty(txtIDCONSULTA.Text))
                {
                    MessageBox.Show(" Verifique campos em Branco !", "Falha ao Alterar !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    int resultado = 0;

                    resultado = ConsultaDAL.Alterar(Convert.ToInt32(comboMEDICO.SelectedValue), Convert.ToInt16(comboPACIENTE.SelectedValue), Convert.ToDateTime(txtDATACONSULTA), Convert.ToDateTime(txtDATAINICIO), Convert.ToDateTime(txtHORAFIM), txtOBSERVACAO.Text, chkATIVO.Checked, Convert.ToInt16(txtIDCONSULTA.Text));

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

        private void btLIMPAR_Click(object sender, EventArgs e)
        {
            txtDATACONSULTA.ResetText();
            //txtATIVO.ResetText();
            txtDATAINICIO.ResetText();
            txtHORAFIM.ResetText();
            txtIDCONSULTA.ResetText();
            txtOBSERVACAO.ResetText();
            this.tabela_load();

        }

        private void btEXCLUIR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluír esse Registro ?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtIDCONSULTA.Text))
                {
                    MessageBox.Show(" Verifique campos em Branco !", "Falha ao Excluír !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    int resultado = 0;

                    resultado = ConsultaDAL.Excluir(Convert.ToInt16(txtIDCONSULTA.Text));

                    if (resultado == 1)
                    {
                        MessageBox.Show("Registro excluido com sucesso ! ! !");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao excluir o registro  ! ! !");
                    }
                }
            }

            this.tabela_load();
        }

        private void chkATIVO_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btPESQUISAR_Click(object sender, EventArgs e)
        {
            DataSet ds = ConsultaDAL.pesquisa(textBox1.Text);
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
                txtIDCONSULTA.Text = dr["ID"].ToString();
                txtDATACONSULTA.Text = dr["Data"].ToString();
                txtDATAINICIO.Text = dr["Início"].ToString();
                txtHORAFIM.Text = dr["Fim"].ToString();
                txtOBSERVACAO.Text = dr["Observações"].ToString();
                comboMEDICO.SelectedValue = Convert.ToInt16(dr["MED"].ToString());
                comboPACIENTE.SelectedValue = Convert.ToInt16(dr["PAC"].ToString());
            }
        }
    }
}
