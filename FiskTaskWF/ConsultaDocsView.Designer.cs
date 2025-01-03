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
            idDoc = new DataGridViewTextBoxColumn();
            Livro = new DataGridViewTextBoxColumn();
            NOME = new DataGridViewTextBoxColumn();
            CNPJ = new DataGridViewTextBoxColumn();
            CIDADE = new DataGridViewTextBoxColumn();
            DtRegistro = new DataGridViewTextBoxColumn();
            Vencimentodoc = new DataGridViewTextBoxColumn();
            Obs = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Exercicio = new DataGridViewTextBoxColumn();
            Link = new DataGridViewTextBoxColumn();
            Soli_atua = new DataGridViewTextBoxColumn();
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
            dgConsultaDocumentos.AllowUserToOrderColumns = true;
            dgConsultaDocumentos.AutoGenerateColumns = false;
            dgConsultaDocumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgConsultaDocumentos.Columns.AddRange(new DataGridViewColumn[] { idDoc, Livro, NOME, CNPJ, CIDADE, DtRegistro, Vencimentodoc, Obs, Tipo, Exercicio, Link, Soli_atua });
            dgConsultaDocumentos.DataSource = dbDocumentsBindingSource;
            dgConsultaDocumentos.Location = new Point(15, 243);
            dgConsultaDocumentos.Name = "dgConsultaDocumentos";
            dgConsultaDocumentos.Size = new Size(1306, 200);
            dgConsultaDocumentos.TabIndex = 0;
            dgConsultaDocumentos.CellDoubleClick += dgConsultaDocumentos_CellDoubleClick;
            // 
            // idDoc
            // 
            idDoc.DataPropertyName = "IdDoc";
            idDoc.HeaderText = "IdDoc";
            idDoc.Name = "idDoc";
            // 
            // Livro
            // 
            Livro.DataPropertyName = "Livro";
            Livro.HeaderText = "Livro";
            Livro.Name = "Livro";
            // 
            // NOME
            // 
            NOME.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            NOME.DataPropertyName = "NOME";
            NOME.HeaderText = "NOME";
            NOME.Name = "NOME";
            NOME.Width = 67;
            // 
            // CNPJ
            // 
            CNPJ.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CNPJ.DataPropertyName = "CNPJ";
            CNPJ.HeaderText = "CNPJ";
            CNPJ.Name = "CNPJ";
            CNPJ.Width = 59;
            // 
            // CIDADE
            // 
            CIDADE.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CIDADE.DataPropertyName = "CIDADE";
            CIDADE.HeaderText = "CIDADE";
            CIDADE.Name = "CIDADE";
            CIDADE.Width = 73;
            // 
            // DtRegistro
            // 
            DtRegistro.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DtRegistro.DataPropertyName = "DtRegistro";
            DtRegistro.HeaderText = "DtRegistro";
            DtRegistro.Name = "DtRegistro";
            DtRegistro.Width = 87;
            // 
            // Vencimentodoc
            // 
            Vencimentodoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Vencimentodoc.DataPropertyName = "Vencimentodoc";
            Vencimentodoc.HeaderText = "Vencimentodoc";
            Vencimentodoc.Name = "Vencimentodoc";
            Vencimentodoc.Width = 115;
            // 
            // Obs
            // 
            Obs.DataPropertyName = "Obs";
            Obs.HeaderText = "Obs";
            Obs.Name = "Obs";
            // 
            // Tipo
            // 
            Tipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Tipo.DataPropertyName = "Tipo";
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.Width = 55;
            // 
            // Exercicio
            // 
            Exercicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Exercicio.DataPropertyName = "Exercicio";
            Exercicio.HeaderText = "Exercicio";
            Exercicio.Name = "Exercicio";
            Exercicio.Width = 79;
            // 
            // Link
            // 
            Link.DataPropertyName = "Link";
            Link.HeaderText = "Link";
            Link.Name = "Link";
            // 
            // Soli_atua
            // 
            Soli_atua.DataPropertyName = "Soli_atua";
            Soli_atua.HeaderText = "Soli_atua";
            Soli_atua.Name = "Soli_atua";
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
        private BindingSource dbDocumentsBindingSource;
        private TextBox txtPesquisa;
        private Button btnRefresh;
        private Label label1;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private DataGridViewTextBoxColumn idDoc;
        private DataGridViewTextBoxColumn Livro;
        private DataGridViewTextBoxColumn NOME;
        private DataGridViewTextBoxColumn CNPJ;
        private DataGridViewTextBoxColumn CIDADE;
        private DataGridViewTextBoxColumn DtRegistro;
        private DataGridViewTextBoxColumn Vencimentodoc;
        private DataGridViewTextBoxColumn Obs;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Exercicio;
        private DataGridViewTextBoxColumn Link;
        private DataGridViewTextBoxColumn Soli_atua;
    }
}
