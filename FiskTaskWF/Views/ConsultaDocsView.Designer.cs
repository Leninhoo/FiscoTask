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
            label2 = new Label();
            dgVencendo = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgConsultaDocumentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbDocumentsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgVencendo).BeginInit();
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
            dgVencendo.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dgVencendo.DataSource = dbDocumentsBindingSource;
            dgVencendo.Location = new Point(15, 540);
            dgVencendo.Name = "dgVencendo";
            dgVencendo.Size = new Size(1306, 200);
            dgVencendo.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "IdDoc";
            dataGridViewTextBoxColumn1.HeaderText = "IdDoc";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Livro";
            dataGridViewTextBoxColumn2.HeaderText = "Livro";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewTextBoxColumn3.DataPropertyName = "NOME";
            dataGridViewTextBoxColumn3.HeaderText = "NOME";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 67;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewTextBoxColumn4.DataPropertyName = "CNPJ";
            dataGridViewTextBoxColumn4.HeaderText = "CNPJ";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 59;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewTextBoxColumn5.DataPropertyName = "CIDADE";
            dataGridViewTextBoxColumn5.HeaderText = "CIDADE";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 73;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewTextBoxColumn6.DataPropertyName = "DtRegistro";
            dataGridViewTextBoxColumn6.HeaderText = "DtRegistro";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 87;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewTextBoxColumn7.DataPropertyName = "Vencimentodoc";
            dataGridViewTextBoxColumn7.HeaderText = "Vencimentodoc";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 115;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Obs";
            dataGridViewTextBoxColumn8.HeaderText = "Obs";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewTextBoxColumn9.DataPropertyName = "Tipo";
            dataGridViewTextBoxColumn9.HeaderText = "Tipo";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 55;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewTextBoxColumn10.DataPropertyName = "Exercicio";
            dataGridViewTextBoxColumn10.HeaderText = "Exercicio";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Width = 79;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "Link";
            dataGridViewTextBoxColumn11.HeaderText = "Link";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "Soli_atua";
            dataGridViewTextBoxColumn12.HeaderText = "Soli_atua";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 494);
            label3.Name = "label3";
            label3.Size = new Size(325, 30);
            label3.TabIndex = 8;
            label3.Text = "Vencendo nos próximos 30 dias";
            // 
            // ConsultaDocsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(dgVencendo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(txtPesquisa);
            Controls.Add(dgConsultaDocumentos);
            Name = "ConsultaDocsView";
            Size = new Size(1346, 799);
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
        private Label label2;
        private DataGridView dgVencendo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private Label label3;
    }
}
