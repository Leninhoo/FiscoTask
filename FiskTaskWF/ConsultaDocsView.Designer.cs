namespace FiscoTask
{
    partial class ConsultaDocsView
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
            dgConsultaDocumentos = new DataGridView();
            idDocDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            livroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nOMEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cNPJDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cIDADEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dtRegistroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vencimentodocDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            obsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            exercicioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            linkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soliatuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dbDocumentsBindingSource = new BindingSource(components);
            txtPesquisa = new TextBox();
            btnRefresh = new Button();
            label1 = new Label();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)dgConsultaDocumentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbDocumentsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgConsultaDocumentos
            // 
            dgConsultaDocumentos.AllowUserToAddRows = false;
            dgConsultaDocumentos.AllowUserToDeleteRows = false;
            dgConsultaDocumentos.AutoGenerateColumns = false;
            dgConsultaDocumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgConsultaDocumentos.Columns.AddRange(new DataGridViewColumn[] { idDocDataGridViewTextBoxColumn, livroDataGridViewTextBoxColumn, nOMEDataGridViewTextBoxColumn, cNPJDataGridViewTextBoxColumn, cIDADEDataGridViewTextBoxColumn, dtRegistroDataGridViewTextBoxColumn, vencimentodocDataGridViewTextBoxColumn, obsDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, exercicioDataGridViewTextBoxColumn, linkDataGridViewTextBoxColumn, soliatuaDataGridViewTextBoxColumn });
            dgConsultaDocumentos.DataSource = dbDocumentsBindingSource;
            dgConsultaDocumentos.Location = new Point(15, 243);
            dgConsultaDocumentos.Name = "dgConsultaDocumentos";
            dgConsultaDocumentos.Size = new Size(1306, 200);
            dgConsultaDocumentos.TabIndex = 0;
            // 
            // idDocDataGridViewTextBoxColumn
            // 
            idDocDataGridViewTextBoxColumn.DataPropertyName = "IdDoc";
            idDocDataGridViewTextBoxColumn.HeaderText = "IdDoc";
            idDocDataGridViewTextBoxColumn.Name = "idDocDataGridViewTextBoxColumn";
            // 
            // livroDataGridViewTextBoxColumn
            // 
            livroDataGridViewTextBoxColumn.DataPropertyName = "Livro";
            livroDataGridViewTextBoxColumn.HeaderText = "Livro";
            livroDataGridViewTextBoxColumn.Name = "livroDataGridViewTextBoxColumn";
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            nOMEDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            nOMEDataGridViewTextBoxColumn.Width = 67;
            // 
            // cNPJDataGridViewTextBoxColumn
            // 
            cNPJDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ";
            cNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            cNPJDataGridViewTextBoxColumn.Name = "cNPJDataGridViewTextBoxColumn";
            cNPJDataGridViewTextBoxColumn.Width = 59;
            // 
            // cIDADEDataGridViewTextBoxColumn
            // 
            cIDADEDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cIDADEDataGridViewTextBoxColumn.DataPropertyName = "CIDADE";
            cIDADEDataGridViewTextBoxColumn.HeaderText = "CIDADE";
            cIDADEDataGridViewTextBoxColumn.Name = "cIDADEDataGridViewTextBoxColumn";
            cIDADEDataGridViewTextBoxColumn.Width = 73;
            // 
            // dtRegistroDataGridViewTextBoxColumn
            // 
            dtRegistroDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtRegistroDataGridViewTextBoxColumn.DataPropertyName = "DtRegistro";
            dtRegistroDataGridViewTextBoxColumn.HeaderText = "DtRegistro";
            dtRegistroDataGridViewTextBoxColumn.Name = "dtRegistroDataGridViewTextBoxColumn";
            dtRegistroDataGridViewTextBoxColumn.Width = 87;
            // 
            // vencimentodocDataGridViewTextBoxColumn
            // 
            vencimentodocDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            vencimentodocDataGridViewTextBoxColumn.DataPropertyName = "Vencimentodoc";
            vencimentodocDataGridViewTextBoxColumn.HeaderText = "Vencimentodoc";
            vencimentodocDataGridViewTextBoxColumn.Name = "vencimentodocDataGridViewTextBoxColumn";
            vencimentodocDataGridViewTextBoxColumn.Width = 115;
            // 
            // obsDataGridViewTextBoxColumn
            // 
            obsDataGridViewTextBoxColumn.DataPropertyName = "Obs";
            obsDataGridViewTextBoxColumn.HeaderText = "Obs";
            obsDataGridViewTextBoxColumn.Name = "obsDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.Width = 55;
            // 
            // exercicioDataGridViewTextBoxColumn
            // 
            exercicioDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            exercicioDataGridViewTextBoxColumn.DataPropertyName = "Exercicio";
            exercicioDataGridViewTextBoxColumn.HeaderText = "Exercicio";
            exercicioDataGridViewTextBoxColumn.Name = "exercicioDataGridViewTextBoxColumn";
            exercicioDataGridViewTextBoxColumn.Width = 79;
            // 
            // linkDataGridViewTextBoxColumn
            // 
            linkDataGridViewTextBoxColumn.DataPropertyName = "Link";
            linkDataGridViewTextBoxColumn.HeaderText = "Link";
            linkDataGridViewTextBoxColumn.Name = "linkDataGridViewTextBoxColumn";
            // 
            // soliatuaDataGridViewTextBoxColumn
            // 
            soliatuaDataGridViewTextBoxColumn.DataPropertyName = "Soli_atua";
            soliatuaDataGridViewTextBoxColumn.HeaderText = "Soli_atua";
            soliatuaDataGridViewTextBoxColumn.Name = "soliatuaDataGridViewTextBoxColumn";
            // 
            // dbDocumentsBindingSource
            // 
            dbDocumentsBindingSource.DataSource = typeof(DbDocuments);
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(15, 183);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(703, 23);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.TextChanged += textBox1_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(15, 94);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Atualizar";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(229, 30);
            label1.TabIndex = 3;
            label1.Text = "Consulta Documentos";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // ConsultaDocsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(txtPesquisa);
            Controls.Add(dgConsultaDocumentos);
            Name = "ConsultaDocsView";
            Size = new Size(1346, 492);
            ((System.ComponentModel.ISupportInitialize)dgConsultaDocumentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbDocumentsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgConsultaDocumentos;
        private DataGridViewTextBoxColumn idDocDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn livroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cIDADEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dtRegistroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vencimentodocDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn obsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn exercicioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn linkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soliatuaDataGridViewTextBoxColumn;
        private BindingSource dbDocumentsBindingSource;
        private TextBox txtPesquisa;
        private Button btnRefresh;
        private Label label1;
        private MySqlConnector.MySqlCommand mySqlCommand1;
    }
}
