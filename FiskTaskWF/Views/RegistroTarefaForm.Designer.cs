namespace FiscoTask
{
    partial class RegistroTarefaForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtLivro = new TextBox();
            dgPesquisaEmpresa = new DataGridView();
            EMPRESA = new DataGridViewTextBoxColumn();
            NOME = new DataGridViewTextBoxColumn();
            CNPJ = new DataGridViewTextBoxColumn();
            CIDADE = new DataGridViewTextBoxColumn();
            empresaViewBindingSource = new BindingSource(components);
            txtPesquisa = new TextBox();
            label3 = new Label();
            cbTipo = new ComboBox();
            cbSituacao = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            rtbObs = new RichTextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgPesquisaEmpresa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empresaViewBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 30);
            label1.TabIndex = 5;
            label1.Text = "Registro de tarefas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 126);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 6;
            label2.Text = "Livro";
            // 
            // txtLivro
            // 
            txtLivro.Location = new Point(67, 123);
            txtLivro.Name = "txtLivro";
            txtLivro.ReadOnly = true;
            txtLivro.Size = new Size(94, 23);
            txtLivro.TabIndex = 2;
            // 
            // dgPesquisaEmpresa
            // 
            dgPesquisaEmpresa.AllowUserToAddRows = false;
            dgPesquisaEmpresa.AllowUserToDeleteRows = false;
            dgPesquisaEmpresa.AutoGenerateColumns = false;
            dgPesquisaEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPesquisaEmpresa.Columns.AddRange(new DataGridViewColumn[] { EMPRESA, NOME, CNPJ, CIDADE });
            dgPesquisaEmpresa.DataSource = empresaViewBindingSource;
            dgPesquisaEmpresa.Location = new Point(473, 71);
            dgPesquisaEmpresa.Name = "dgPesquisaEmpresa";
            dgPesquisaEmpresa.ReadOnly = true;
            dgPesquisaEmpresa.Size = new Size(634, 148);
            dgPesquisaEmpresa.TabIndex = 8;
            dgPesquisaEmpresa.CellDoubleClick += dgPesquisaEmpresa_CellDoubleClick;
            // 
            // EMPRESA
            // 
            EMPRESA.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            EMPRESA.DataPropertyName = "EMPRESA";
            EMPRESA.HeaderText = "EMPRESA";
            EMPRESA.Name = "EMPRESA";
            EMPRESA.ReadOnly = true;
            EMPRESA.Width = 83;
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
            // empresaViewBindingSource
            // 
            empresaViewBindingSource.DataSource = typeof(EmpresaView);
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(473, 28);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(497, 23);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 155);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 10;
            label3.Text = "Tipo";
            // 
            // cbTipo
            // 
            cbTipo.AllowDrop = true;
            cbTipo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTipo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Alvará", "Bombeiro", "Vigilância Sanitária", "Consulta Jurídica", "Documentos gerais", "Outro", "Segunda via alvará", "Licença de transporte", "Alteração Ata/Documento", "Débitos", "Atualizar Alvará" });
            cbTipo.Location = new Point(67, 152);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(248, 23);
            cbTipo.TabIndex = 3;
            // 
            // cbSituacao
            // 
            cbSituacao.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSituacao.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSituacao.FormattingEnabled = true;
            cbSituacao.Items.AddRange(new object[] { "Em andamento", "Aguardando terceiro", "Encerrado", "Pagamento alvará", "Solicitar Vigilância", "Vigilância solicitada", "Solicitar Bombeiro", "Aguardando pagamento bombeiro", "Solicitar alvará", "Alvará solicitado para Prefeitura" });
            cbSituacao.Location = new Point(67, 181);
            cbSituacao.Name = "cbSituacao";
            cbSituacao.Size = new Size(248, 23);
            cbSituacao.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 184);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 12;
            label4.Text = "Situação";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 282);
            label5.Name = "label5";
            label5.Size = new Size(152, 15);
            label5.TabIndex = 14;
            label5.Text = "Observações e comentários";
            // 
            // rtbObs
            // 
            rtbObs.Location = new Point(13, 309);
            rtbObs.Name = "rtbObs";
            rtbObs.Size = new Size(1081, 190);
            rtbObs.TabIndex = 5;
            rtbObs.Text = "";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 536);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(93, 536);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(473, 9);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 15;
            label6.Text = "Pesquisar Empresa";
            // 
            // RegistroTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 585);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(rtbObs);
            Controls.Add(label5);
            Controls.Add(cbSituacao);
            Controls.Add(label4);
            Controls.Add(cbTipo);
            Controls.Add(label3);
            Controls.Add(txtPesquisa);
            Controls.Add(dgPesquisaEmpresa);
            Controls.Add(txtLivro);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroTarefaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Tarefas";
            ((System.ComponentModel.ISupportInitialize)dgPesquisaEmpresa).EndInit();
            ((System.ComponentModel.ISupportInitialize)empresaViewBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLivro;
        private DataGridView dgPesquisaEmpresa;
        private TextBox txtPesquisa;
        private BindingSource empresaViewBindingSource;
        private DataGridViewTextBoxColumn EMPRESA;
        private DataGridViewTextBoxColumn NOME;
        private DataGridViewTextBoxColumn CNPJ;
        private DataGridViewTextBoxColumn CIDADE;
        private Label label3;
        private ComboBox cbTipo;
        private ComboBox cbSituacao;
        private Label label4;
        private Label label5;
        private RichTextBox rtbObs;
        private Button btnSalvar;
        private Button btnCancelar;
        private Label label6;
    }
}