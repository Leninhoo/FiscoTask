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
            dbDocumentsBindingSource = new BindingSource(components);
            txtPesquisa = new TextBox();
            btnRefresh = new Button();
            label1 = new Label();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            label2 = new Label();
            dgVencendo = new DataGridView();
            IdDoc1 = new DataGridViewTextBoxColumn();
            Livro1 = new DataGridViewTextBoxColumn();
            NOME1 = new DataGridViewTextBoxColumn();
            CNPJ1 = new DataGridViewTextBoxColumn();
            CIDADE1 = new DataGridViewTextBoxColumn();
            Vencimentodoc1 = new DataGridViewTextBoxColumn();
            Obs1 = new DataGridViewTextBoxColumn();
            Tipo1 = new DataGridViewTextBoxColumn();
            DtRegistro1 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            btnExport = new Button();
            btnExportarVencendo = new Button();
            Id = new DataGridViewTextBoxColumn();
            Livro = new DataGridViewTextBoxColumn();
            NOME = new DataGridViewTextBoxColumn();
            CNPJ = new DataGridViewTextBoxColumn();
            CIDADE = new DataGridViewTextBoxColumn();
            Vencimentodoc = new DataGridViewTextBoxColumn();
            Obs = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            DtRegistro = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgConsultaDocumentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbDocumentsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgVencendo).BeginInit();
            SuspendLayout();
            // 
            // dgConsultaDocumentos
            // 
            dgConsultaDocumentos.AllowUserToAddRows = false;
            dgConsultaDocumentos.AllowUserToDeleteRows = false;
            dgConsultaDocumentos.AutoGenerateColumns = false;
            dgConsultaDocumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgConsultaDocumentos.Columns.AddRange(new DataGridViewColumn[] { Id, Livro, NOME, CNPJ, CIDADE, Vencimentodoc, Obs, Tipo, DtRegistro });
            dgConsultaDocumentos.DataSource = dbDocumentsBindingSource;
            dgConsultaDocumentos.Location = new Point(15, 243);
            dgConsultaDocumentos.Name = "dgConsultaDocumentos";
            dgConsultaDocumentos.ReadOnly = true;
            dgConsultaDocumentos.Size = new Size(1306, 200);
            dgConsultaDocumentos.TabIndex = 0;
            dgConsultaDocumentos.CellDoubleClick += dgConsultaDocumentos_CellDoubleClick;
            // 
            // dbDocumentsBindingSource
            // 
            dbDocumentsBindingSource.DataSource = typeof(DbDocuments);
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(155, 185);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 188);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 6;
            label2.Text = "Pesquisar por Empresa";
            // 
            // dgVencendo
            // 
            dgVencendo.AllowUserToAddRows = false;
            dgVencendo.AllowUserToDeleteRows = false;
            dgVencendo.AllowUserToOrderColumns = true;
            dgVencendo.AutoGenerateColumns = false;
            dgVencendo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVencendo.Columns.AddRange(new DataGridViewColumn[] { IdDoc1, Livro1, NOME1, CNPJ1, CIDADE1, Vencimentodoc1, Obs1, Tipo1, DtRegistro1 });
            dgVencendo.DataSource = dbDocumentsBindingSource;
            dgVencendo.Location = new Point(15, 633);
            dgVencendo.Name = "dgVencendo";
            dgVencendo.ReadOnly = true;
            dgVencendo.Size = new Size(1306, 200);
            dgVencendo.TabIndex = 7;
            dgVencendo.CellDoubleClick += dgVencendo_CellDoubleClick;
            // 
            // IdDoc1
            // 
            IdDoc1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            IdDoc1.DataPropertyName = "IdDoc";
            IdDoc1.HeaderText = "IdDoc";
            IdDoc1.Name = "IdDoc1";
            IdDoc1.ReadOnly = true;
            IdDoc1.Width = 63;
            // 
            // Livro1
            // 
            Livro1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Livro1.DataPropertyName = "Livro";
            Livro1.HeaderText = "Livro";
            Livro1.Name = "Livro1";
            Livro1.ReadOnly = true;
            Livro1.Width = 58;
            // 
            // NOME1
            // 
            NOME1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            NOME1.DataPropertyName = "NOME";
            NOME1.HeaderText = "NOME";
            NOME1.Name = "NOME1";
            NOME1.ReadOnly = true;
            NOME1.Width = 67;
            // 
            // CNPJ1
            // 
            CNPJ1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CNPJ1.DataPropertyName = "CNPJ";
            CNPJ1.HeaderText = "CNPJ";
            CNPJ1.Name = "CNPJ1";
            CNPJ1.ReadOnly = true;
            CNPJ1.Width = 59;
            // 
            // CIDADE1
            // 
            CIDADE1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CIDADE1.DataPropertyName = "CIDADE";
            CIDADE1.HeaderText = "CIDADE";
            CIDADE1.Name = "CIDADE1";
            CIDADE1.ReadOnly = true;
            CIDADE1.Width = 73;
            // 
            // Vencimentodoc1
            // 
            Vencimentodoc1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Vencimentodoc1.DataPropertyName = "Vencimentodoc";
            Vencimentodoc1.HeaderText = "Vencimento";
            Vencimentodoc1.Name = "Vencimentodoc1";
            Vencimentodoc1.ReadOnly = true;
            Vencimentodoc1.Width = 95;
            // 
            // Obs1
            // 
            Obs1.DataPropertyName = "Obs";
            Obs1.HeaderText = "Obs";
            Obs1.Name = "Obs1";
            Obs1.ReadOnly = true;
            // 
            // Tipo1
            // 
            Tipo1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Tipo1.DataPropertyName = "Tipo";
            Tipo1.HeaderText = "Tipo";
            Tipo1.Name = "Tipo1";
            Tipo1.ReadOnly = true;
            Tipo1.Width = 55;
            // 
            // DtRegistro1
            // 
            DtRegistro1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DtRegistro1.DataPropertyName = "DtRegistro";
            DtRegistro1.HeaderText = "DtRegistro";
            DtRegistro1.Name = "DtRegistro1";
            DtRegistro1.ReadOnly = true;
            DtRegistro1.Width = 87;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 587);
            label3.Name = "label3";
            label3.Size = new Size(325, 30);
            label3.TabIndex = 8;
            label3.Text = "Vencendo nos próximos 30 dias";
            // 
            // btnExport
            // 
            btnExport.Image = Properties.Resources.file_type_excel_icon_130611__1_;
            btnExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnExport.Location = new Point(15, 449);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(93, 38);
            btnExport.TabIndex = 19;
            btnExport.Text = "Exportar";
            btnExport.TextAlign = ContentAlignment.MiddleRight;
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnExportarVencendo
            // 
            btnExportarVencendo.Image = Properties.Resources.file_type_excel_icon_130611__1_;
            btnExportarVencendo.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportarVencendo.Location = new Point(15, 839);
            btnExportarVencendo.Name = "btnExportarVencendo";
            btnExportarVencendo.Size = new Size(93, 38);
            btnExportarVencendo.TabIndex = 20;
            btnExportarVencendo.Text = "Exportar";
            btnExportarVencendo.TextAlign = ContentAlignment.MiddleRight;
            btnExportarVencendo.UseVisualStyleBackColor = true;
            btnExportarVencendo.Click += btnExportarVencendo_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "IdDoc";
            Id.HeaderText = "IdDoc";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Livro
            // 
            Livro.DataPropertyName = "Livro";
            Livro.HeaderText = "Livro";
            Livro.Name = "Livro";
            Livro.ReadOnly = true;
            // 
            // NOME
            // 
            NOME.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            NOME.DataPropertyName = "NOME";
            NOME.HeaderText = "NOME";
            NOME.Name = "NOME";
            NOME.ReadOnly = true;
            NOME.Width = 67;
            // 
            // CNPJ
            // 
            CNPJ.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CNPJ.DataPropertyName = "CNPJ";
            CNPJ.HeaderText = "CNPJ";
            CNPJ.Name = "CNPJ";
            CNPJ.ReadOnly = true;
            CNPJ.Width = 59;
            // 
            // CIDADE
            // 
            CIDADE.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CIDADE.DataPropertyName = "CIDADE";
            CIDADE.HeaderText = "CIDADE";
            CIDADE.Name = "CIDADE";
            CIDADE.ReadOnly = true;
            CIDADE.Width = 73;
            // 
            // Vencimentodoc
            // 
            Vencimentodoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Vencimentodoc.DataPropertyName = "Vencimentodoc";
            Vencimentodoc.HeaderText = "Vencimento";
            Vencimentodoc.Name = "Vencimentodoc";
            Vencimentodoc.ReadOnly = true;
            Vencimentodoc.Width = 95;
            // 
            // Obs
            // 
            Obs.DataPropertyName = "Obs";
            Obs.HeaderText = "Obs";
            Obs.Name = "Obs";
            Obs.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Tipo.DataPropertyName = "Tipo";
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 55;
            // 
            // DtRegistro
            // 
            DtRegistro.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DtRegistro.DataPropertyName = "DtRegistro";
            DtRegistro.HeaderText = "DtRegistro";
            DtRegistro.Name = "DtRegistro";
            DtRegistro.ReadOnly = true;
            DtRegistro.Width = 87;
            // 
            // ConsultaDocsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnExportarVencendo);
            Controls.Add(btnExport);
            Controls.Add(label3);
            Controls.Add(dgVencendo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(txtPesquisa);
            Controls.Add(dgConsultaDocumentos);
            Name = "ConsultaDocsView";
            Size = new Size(1346, 957);
            ((System.ComponentModel.ISupportInitialize)dgConsultaDocumentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbDocumentsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgVencendo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgConsultaDocumentos;
        private BindingSource dbDocumentsBindingSource;
        private TextBox txtPesquisa;
        private Button btnRefresh;
        private Label label1;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private Label label2;
        private DataGridView dgVencendo;
        private Label label3;
        private Button btnExport;
        private Button btnExportarVencendo;
        private DataGridViewTextBoxColumn idDoc;
        private DataGridViewTextBoxColumn IdDoc1;
        private DataGridViewTextBoxColumn Livro1;
        private DataGridViewTextBoxColumn NOME1;
        private DataGridViewTextBoxColumn CNPJ1;
        private DataGridViewTextBoxColumn CIDADE1;
        private DataGridViewTextBoxColumn Vencimentodoc1;
        private DataGridViewTextBoxColumn Obs1;
        private DataGridViewTextBoxColumn Tipo1;
        private DataGridViewTextBoxColumn DtRegistro1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Livro;
        private DataGridViewTextBoxColumn NOME;
        private DataGridViewTextBoxColumn CNPJ;
        private DataGridViewTextBoxColumn CIDADE;
        private DataGridViewTextBoxColumn Vencimentodoc;
        private DataGridViewTextBoxColumn Obs;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn DtRegistro;
    }
}
