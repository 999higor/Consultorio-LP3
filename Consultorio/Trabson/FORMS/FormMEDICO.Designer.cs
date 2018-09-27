namespace Trabson.FORMS
{
    partial class FormMEDICO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTLIMPAR = new System.Windows.Forms.Button();
            this.BTALTERAR = new System.Windows.Forms.Button();
            this.BTEXCLUIR = new System.Windows.Forms.Button();
            this.BTCADASTRAR = new System.Windows.Forms.Button();
            this.txtIDMEDICO = new System.Windows.Forms.TextBox();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.txtNOMEMEDICO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.btPESQUISAR = new System.Windows.Forms.Button();
            this.txtPESQUISA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // BTLIMPAR
            // 
            this.BTLIMPAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLIMPAR.Location = new System.Drawing.Point(64, 222);
            this.BTLIMPAR.Name = "BTLIMPAR";
            this.BTLIMPAR.Size = new System.Drawing.Size(144, 29);
            this.BTLIMPAR.TabIndex = 0;
            this.BTLIMPAR.Text = "LIMPAR";
            this.BTLIMPAR.UseVisualStyleBackColor = true;
            this.BTLIMPAR.Click += new System.EventHandler(this.BTLIMPAR_Click);
            // 
            // BTALTERAR
            // 
            this.BTALTERAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTALTERAR.Location = new System.Drawing.Point(64, 268);
            this.BTALTERAR.Name = "BTALTERAR";
            this.BTALTERAR.Size = new System.Drawing.Size(144, 31);
            this.BTALTERAR.TabIndex = 1;
            this.BTALTERAR.Text = "ALTERAR";
            this.BTALTERAR.UseVisualStyleBackColor = true;
            this.BTALTERAR.Click += new System.EventHandler(this.BTALTERAR_Click);
            // 
            // BTEXCLUIR
            // 
            this.BTEXCLUIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEXCLUIR.Location = new System.Drawing.Point(64, 316);
            this.BTEXCLUIR.Name = "BTEXCLUIR";
            this.BTEXCLUIR.Size = new System.Drawing.Size(144, 29);
            this.BTEXCLUIR.TabIndex = 2;
            this.BTEXCLUIR.Text = "EXCLUIR";
            this.BTEXCLUIR.UseVisualStyleBackColor = true;
            this.BTEXCLUIR.Click += new System.EventHandler(this.BTEXCLUIR_Click);
            // 
            // BTCADASTRAR
            // 
            this.BTCADASTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCADASTRAR.Location = new System.Drawing.Point(64, 175);
            this.BTCADASTRAR.Name = "BTCADASTRAR";
            this.BTCADASTRAR.Size = new System.Drawing.Size(144, 29);
            this.BTCADASTRAR.TabIndex = 3;
            this.BTCADASTRAR.Text = "CADASTRAR";
            this.BTCADASTRAR.UseVisualStyleBackColor = true;
            this.BTCADASTRAR.Click += new System.EventHandler(this.BTCADASTRAR_Click);
            // 
            // txtIDMEDICO
            // 
            this.txtIDMEDICO.Enabled = false;
            this.txtIDMEDICO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMEDICO.Location = new System.Drawing.Point(16, 39);
            this.txtIDMEDICO.Name = "txtIDMEDICO";
            this.txtIDMEDICO.Size = new System.Drawing.Size(65, 22);
            this.txtIDMEDICO.TabIndex = 4;
            // 
            // txtCRM
            // 
            this.txtCRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCRM.Location = new System.Drawing.Point(16, 135);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(254, 22);
            this.txtCRM.TabIndex = 5;
            // 
            // txtNOMEMEDICO
            // 
            this.txtNOMEMEDICO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOMEMEDICO.Location = new System.Drawing.Point(16, 87);
            this.txtNOMEMEDICO.Name = "txtNOMEMEDICO";
            this.txtNOMEMEDICO.Size = new System.Drawing.Size(254, 22);
            this.txtNOMEMEDICO.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "CRM";
            // 
            // tabela
            // 
            this.tabela.AllowUserToAddRows = false;
            this.tabela.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Location = new System.Drawing.Point(302, 67);
            this.tabela.Name = "tabela";
            this.tabela.ReadOnly = true;
            this.tabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela.Size = new System.Drawing.Size(425, 294);
            this.tabela.TabIndex = 10;
            this.tabela.Click += new System.EventHandler(this.selecionar_Tabela);
            // 
            // btPESQUISAR
            // 
            this.btPESQUISAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPESQUISAR.Location = new System.Drawing.Point(606, 18);
            this.btPESQUISAR.Name = "btPESQUISAR";
            this.btPESQUISAR.Size = new System.Drawing.Size(121, 33);
            this.btPESQUISAR.TabIndex = 11;
            this.btPESQUISAR.Text = "PESQUISAR";
            this.btPESQUISAR.UseVisualStyleBackColor = true;
            this.btPESQUISAR.Click += new System.EventHandler(this.btPESQUISAR_Click);
            // 
            // txtPESQUISA
            // 
            this.txtPESQUISA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPESQUISA.Location = new System.Drawing.Point(302, 24);
            this.txtPESQUISA.Name = "txtPESQUISA";
            this.txtPESQUISA.Size = new System.Drawing.Size(298, 22);
            this.txtPESQUISA.TabIndex = 12;
            // 
            // FormMEDICO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 373);
            this.Controls.Add(this.txtPESQUISA);
            this.Controls.Add(this.btPESQUISAR);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNOMEMEDICO);
            this.Controls.Add(this.txtCRM);
            this.Controls.Add(this.txtIDMEDICO);
            this.Controls.Add(this.BTCADASTRAR);
            this.Controls.Add(this.BTEXCLUIR);
            this.Controls.Add(this.BTALTERAR);
            this.Controls.Add(this.BTLIMPAR);
            this.Name = "FormMEDICO";
            this.Text = "Registros de Médicos";
            this.Load += new System.EventHandler(this.FormMEDICO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTLIMPAR;
        private System.Windows.Forms.Button BTALTERAR;
        private System.Windows.Forms.Button BTEXCLUIR;
        private System.Windows.Forms.Button BTCADASTRAR;
        private System.Windows.Forms.TextBox txtIDMEDICO;
        private System.Windows.Forms.TextBox txtCRM;
        private System.Windows.Forms.TextBox txtNOMEMEDICO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Button btPESQUISAR;
        private System.Windows.Forms.TextBox txtPESQUISA;
    }
}