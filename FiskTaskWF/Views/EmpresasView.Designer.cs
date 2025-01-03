namespace FiscoTask
{
    partial class EmpresasView
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgEmpresas = new DataGridView();
            empresaViewBindingSource = new BindingSource(components);
            label1 = new Label();
            txtPesquisa = new TextBox();
            eMPRESADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nOMEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cNPJDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nOMEFANTASIADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eNDERECODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nUMERODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bAIRRODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cOMPLEMENTODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cIDADEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uFDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cEPDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rEGIMEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eMAILDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fONEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rESPONSAVELDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgEmpresas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empresaViewBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgEmpresas
            // 
            dgEmpresas.AllowUserToAddRows = false;
            dgEmpresas.AllowUserToDeleteRows = false;
            dgEmpresas.AutoGenerateColumns = false;
            dgEmpresas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmpresas.Columns.AddRange(new DataGridViewColumn[] { eMPRESADataGridViewTextBoxColumn, nOMEDataGridViewTextBoxColumn, cNPJDataGridViewTextBoxColumn, nOMEFANTASIADataGridViewTextBoxColumn, eNDERECODataGridViewTextBoxColumn, nUMERODataGridViewTextBoxColumn, bAIRRODataGridViewTextBoxColumn, cOMPLEMENTODataGridViewTextBoxColumn, cIDADEDataGridViewTextBoxColumn, uFDataGridViewTextBoxColumn, cEPDataGridViewTextBoxColumn, rEGIMEDataGridViewTextBoxColumn, eMAILDataGridViewTextBoxColumn, fONEDataGridViewTextBoxColumn, rESPONSAVELDataGridViewTextBoxColumn, iEDataGridViewTextBoxColumn });
            dgEmpresas.DataSource = empresaViewBindingSource;
            dgEmpresas.Location = new Point(37, 199);
            dgEmpresas.Name = "dgEmpresas";
            dgEmpresas.ReadOnly = true;
            dgEmpresas.Size = new Size(1283, 276);
            dgEmpresas.TabIndex = 3;
            // 
            // empresaViewBindingSource
            // 
            empresaViewBindingSource.DataSource = typeof(EmpresaView);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 40);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 0;
            label1.Text = "Lista de empresas cadastradas";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(37, 145);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(527, 23);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // eMPRESADataGridViewTextBoxColumn
            // 
            eMPRESADataGridViewTextBoxColumn.DataPropertyName = "EMPRESA";
            eMPRESADataGridViewTextBoxColumn.HeaderText = "EMPRESA";
            eMPRESADataGridViewTextBoxColumn.Name = "eMPRESADataGridViewTextBoxColumn";
            eMPRESADataGridViewTextBoxColumn.ReadOnly = true;
            eMPRESADataGridViewTextBoxColumn.Width = 83;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            nOMEDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            nOMEDataGridViewTextBoxColumn.ReadOnly = true;
            nOMEDataGridViewTextBoxColumn.Width = 67;
            // 
            // cNPJDataGridViewTextBoxColumn
            // 
            cNPJDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ";
            cNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            cNPJDataGridViewTextBoxColumn.Name = "cNPJDataGridViewTextBoxColumn";
            cNPJDataGridViewTextBoxColumn.ReadOnly = true;
            cNPJDataGridViewTextBoxColumn.Width = 59;
            // 
            // nOMEFANTASIADataGridViewTextBoxColumn
            // 
            nOMEFANTASIADataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            nOMEFANTASIADataGridViewTextBoxColumn.DataPropertyName = "NOMEFANTASIA";
            nOMEFANTASIADataGridViewTextBoxColumn.HeaderText = "NOMEFANTASIA";
            nOMEFANTASIADataGridViewTextBoxColumn.Name = "nOMEFANTASIADataGridViewTextBoxColumn";
            nOMEFANTASIADataGridViewTextBoxColumn.ReadOnly = true;
            nOMEFANTASIADataGridViewTextBoxColumn.Width = 119;
            // 
            // eNDERECODataGridViewTextBoxColumn
            // 
            eNDERECODataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            eNDERECODataGridViewTextBoxColumn.DataPropertyName = "ENDERECO";
            eNDERECODataGridViewTextBoxColumn.HeaderText = "ENDERECO";
            eNDERECODataGridViewTextBoxColumn.Name = "eNDERECODataGridViewTextBoxColumn";
            eNDERECODataGridViewTextBoxColumn.ReadOnly = true;
            eNDERECODataGridViewTextBoxColumn.Width = 91;
            // 
            // nUMERODataGridViewTextBoxColumn
            // 
            nUMERODataGridViewTextBoxColumn.DataPropertyName = "NUMERO";
            nUMERODataGridViewTextBoxColumn.HeaderText = "NUMERO";
            nUMERODataGridViewTextBoxColumn.Name = "nUMERODataGridViewTextBoxColumn";
            nUMERODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bAIRRODataGridViewTextBoxColumn
            // 
            bAIRRODataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            bAIRRODataGridViewTextBoxColumn.DataPropertyName = "BAIRRO";
            bAIRRODataGridViewTextBoxColumn.HeaderText = "BAIRRO";
            bAIRRODataGridViewTextBoxColumn.Name = "bAIRRODataGridViewTextBoxColumn";
            bAIRRODataGridViewTextBoxColumn.ReadOnly = true;
            bAIRRODataGridViewTextBoxColumn.Width = 73;
            // 
            // cOMPLEMENTODataGridViewTextBoxColumn
            // 
            cOMPLEMENTODataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cOMPLEMENTODataGridViewTextBoxColumn.DataPropertyName = "COMPLEMENTO";
            cOMPLEMENTODataGridViewTextBoxColumn.HeaderText = "COMPLEMENTO";
            cOMPLEMENTODataGridViewTextBoxColumn.Name = "cOMPLEMENTODataGridViewTextBoxColumn";
            cOMPLEMENTODataGridViewTextBoxColumn.ReadOnly = true;
            cOMPLEMENTODataGridViewTextBoxColumn.Width = 119;
            // 
            // cIDADEDataGridViewTextBoxColumn
            // 
            cIDADEDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cIDADEDataGridViewTextBoxColumn.DataPropertyName = "CIDADE";
            cIDADEDataGridViewTextBoxColumn.HeaderText = "CIDADE";
            cIDADEDataGridViewTextBoxColumn.Name = "cIDADEDataGridViewTextBoxColumn";
            cIDADEDataGridViewTextBoxColumn.ReadOnly = true;
            cIDADEDataGridViewTextBoxColumn.Width = 73;
            // 
            // uFDataGridViewTextBoxColumn
            // 
            uFDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            uFDataGridViewTextBoxColumn.DataPropertyName = "UF";
            uFDataGridViewTextBoxColumn.HeaderText = "UF";
            uFDataGridViewTextBoxColumn.Name = "uFDataGridViewTextBoxColumn";
            uFDataGridViewTextBoxColumn.ReadOnly = true;
            uFDataGridViewTextBoxColumn.Width = 46;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            cEPDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            cEPDataGridViewTextBoxColumn.ReadOnly = true;
            cEPDataGridViewTextBoxColumn.Width = 53;
            // 
            // rEGIMEDataGridViewTextBoxColumn
            // 
            rEGIMEDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            rEGIMEDataGridViewTextBoxColumn.DataPropertyName = "REGIME";
            rEGIMEDataGridViewTextBoxColumn.HeaderText = "REGIME";
            rEGIMEDataGridViewTextBoxColumn.Name = "rEGIMEDataGridViewTextBoxColumn";
            rEGIMEDataGridViewTextBoxColumn.ReadOnly = true;
            rEGIMEDataGridViewTextBoxColumn.Width = 73;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            eMAILDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            eMAILDataGridViewTextBoxColumn.DataPropertyName = "E_MAIL";
            eMAILDataGridViewTextBoxColumn.HeaderText = "E_MAIL";
            eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            eMAILDataGridViewTextBoxColumn.Width = 71;
            // 
            // fONEDataGridViewTextBoxColumn
            // 
            fONEDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            fONEDataGridViewTextBoxColumn.DataPropertyName = "FONE";
            fONEDataGridViewTextBoxColumn.HeaderText = "FONE";
            fONEDataGridViewTextBoxColumn.Name = "fONEDataGridViewTextBoxColumn";
            fONEDataGridViewTextBoxColumn.ReadOnly = true;
            fONEDataGridViewTextBoxColumn.Width = 62;
            // 
            // rESPONSAVELDataGridViewTextBoxColumn
            // 
            rESPONSAVELDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            rESPONSAVELDataGridViewTextBoxColumn.DataPropertyName = "RESPONSAVEL";
            rESPONSAVELDataGridViewTextBoxColumn.HeaderText = "RESPONSAVEL";
            rESPONSAVELDataGridViewTextBoxColumn.Name = "rESPONSAVELDataGridViewTextBoxColumn";
            rESPONSAVELDataGridViewTextBoxColumn.ReadOnly = true;
            rESPONSAVELDataGridViewTextBoxColumn.Width = 108;
            // 
            // iEDataGridViewTextBoxColumn
            // 
            iEDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            iEDataGridViewTextBoxColumn.DataPropertyName = "IE";
            iEDataGridViewTextBoxColumn.HeaderText = "IE";
            iEDataGridViewTextBoxColumn.Name = "iEDataGridViewTextBoxColumn";
            iEDataGridViewTextBoxColumn.ReadOnly = true;
            iEDataGridViewTextBoxColumn.Width = 41;
            // 
            // EmpresasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtPesquisa);
            Controls.Add(label1);
            Controls.Add(dgEmpresas);
            Name = "EmpresasView";
            Size = new Size(1377, 530);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)dgEmpresas).EndInit();
            ((System.ComponentModel.ISupportInitialize)empresaViewBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgEmpresas;
        private BindingSource empresaViewBindingSource;
        private Label label1;
        private TextBox txtPesquisa;
        private DataGridViewTextBoxColumn eMPRESADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nOMEFANTASIADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eNDERECODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nUMERODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bAIRRODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cOMPLEMENTODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cIDADEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uFDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rEGIMEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fONEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rESPONSAVELDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iEDataGridViewTextBoxColumn;
    }
}
