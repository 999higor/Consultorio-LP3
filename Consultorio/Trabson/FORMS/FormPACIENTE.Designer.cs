namespace Trabson.FORMS
{
    partial class FormPACIENTE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btEXCLUIR = new System.Windows.Forms.Button();
            this.btALTERAR = new System.Windows.Forms.Button();
            this.btCADASTRAR = new System.Windows.Forms.Button();
            this.btLIMPAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.txtTELEFONE = new System.Windows.Forms.TextBox();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.btPESQUISAR = new System.Windows.Forms.Button();
            this.txtPESQUISA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // btEXCLUIR
            // 
            this.btEXCLUIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEXCLUIR.Location = new System.Drawing.Point(63, 297);
            this.btEXCLUIR.Name = "btEXCLUIR";
            this.btEXCLUIR.Size = new System.Drawing.Size(141, 31);
            this.btEXCLUIR.TabIndex = 0;
            this.btEXCLUIR.Text = "EXCLUIR";
            this.btEXCLUIR.UseVisualStyleBackColor = true;
            this.btEXCLUIR.Click += new System.EventHandler(this.btEXCLUIR_Click);
            // 
            // btALTERAR
            // 
            this.btALTERAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btALTERAR.Location = new System.Drawing.Point(63, 348);
            this.btALTERAR.Name = "btALTERAR";
            this.btALTERAR.Size = new System.Drawing.Size(141, 31);
            this.btALTERAR.TabIndex = 1;
            this.btALTERAR.Text = "ALTERAR";
            this.btALTERAR.UseVisualStyleBackColor = true;
            this.btALTERAR.Click += new System.EventHandler(this.btALTERAR_Click);
            // 
            // btCADASTRAR
            // 
            this.btCADASTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCADASTRAR.Location = new System.Drawing.Point(63, 199);
            this.btCADASTRAR.Name = "btCADASTRAR";
            this.btCADASTRAR.Size = new System.Drawing.Size(141, 32);
            this.btCADASTRAR.TabIndex = 2;
            this.btCADASTRAR.Text = "CADASTRAR";
            this.btCADASTRAR.UseVisualStyleBackColor = true;
            this.btCADASTRAR.Click += new System.EventHandler(this.btCADASTRAR_Click);
            // 
            // btLIMPAR
            // 
            this.btLIMPAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLIMPAR.Location = new System.Drawing.Point(63, 248);
            this.btLIMPAR.Name = "btLIMPAR";
            this.btLIMPAR.Size = new System.Drawing.Size(141, 31);
            this.btLIMPAR.TabIndex = 3;
            this.btLIMPAR.Text = "LIMPAR";
            this.btLIMPAR.UseVisualStyleBackColor = true;
            this.btLIMPAR.Click += new System.EventHandler(this.btLIMPAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(12, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(60, 22);
            this.txtID.TabIndex = 7;
            // 
            // txtNOME
            // 
            this.txtNOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOME.Location = new System.Drawing.Point(12, 89);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(244, 22);
            this.txtNOME.TabIndex = 8;
            // 
            // txtTELEFONE
            // 
            this.txtTELEFONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTELEFONE.Location = new System.Drawing.Point(12, 137);
            this.txtTELEFONE.Name = "txtTELEFONE";
            this.txtTELEFONE.Size = new System.Drawing.Size(244, 22);
            this.txtTELEFONE.TabIndex = 9;
            // 
            // tabela
            // 
            this.tabela.AllowUserToAddRows = false;
            this.tabela.AllowUserToDeleteRows = false;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Location = new System.Drawing.Point(292, 74);
            this.tabela.Name = "tabela";
            this.tabela.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela.Size = new System.Drawing.Size(414, 338);
            this.tabela.TabIndex = 10;
            this.tabela.Click += new System.EventHandler(this.selecionar_tabela);
            // 
            // btPESQUISAR
            // 
            this.btPESQUISAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPESQUISAR.Location = new System.Drawing.Point(583, 25);
            this.btPESQUISAR.Name = "btPESQUISAR";
            this.btPESQUISAR.Size = new System.Drawing.Size(123, 30);
            this.btPESQUISAR.TabIndex = 11;
            this.btPESQUISAR.Text = "PESQUISAR";
            this.btPESQUISAR.UseVisualStyleBackColor = true;
            this.btPESQUISAR.Click += new System.EventHandler(this.btPESQUISAR_Click);
            // 
            // txtPESQUISA
            // 
            this.txtPESQUISA.Location = new System.Drawing.Point(292, 30);
            this.txtPESQUISA.Name = "txtPESQUISA";
            this.txtPESQUISA.Size = new System.Drawing.Size(285, 20);
            this.txtPESQUISA.TabIndex = 12;
            // 
            // FormPACIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 424);
            this.Controls.Add(this.txtPESQUISA);
            this.Controls.Add(this.btPESQUISAR);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.txtTELEFONE);
            this.Controls.Add(this.txtNOME);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLIMPAR);
            this.Controls.Add(this.btCADASTRAR);
            this.Controls.Add(this.btALTERAR);
            this.Controls.Add(this.btEXCLUIR);
            this.Name = "FormPACIENTE";
            this.Text = "Registros de Pacientes";
            this.Load += new System.EventHandler(this.FormPACIENTE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEXCLUIR;
        private System.Windows.Forms.Button btALTERAR;
        private System.Windows.Forms.Button btCADASTRAR;
        private System.Windows.Forms.Button btLIMPAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNOME;
        private System.Windows.Forms.TextBox txtTELEFONE;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Button btPESQUISAR;
        private System.Windows.Forms.TextBox txtPESQUISA;
    }
}