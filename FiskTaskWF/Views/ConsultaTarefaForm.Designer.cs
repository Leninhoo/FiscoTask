using System.ComponentModel;

namespace FiscoTask
{
    partial class ConsultaTarefaForm
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
            components = new Container();
            dbTarefaBindingSource = new BindingSource(components);
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            dbTarefaBindingSource1 = new BindingSource(components);
            dgTarefas2 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Empresa = new DataGridViewTextBoxColumn();
            NOME = new DataGridViewTextBoxColumn();
            CNPJ = new DataGridViewTextBoxColumn();
            CIDADE = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Situacao = new DataGridViewTextBoxColumn();
            Obs = new DataGridViewTextBoxColumn();
            Dtregistro = new DataGridViewTextBoxColumn();
            txtPesquisa = new TextBox();
            txtAtualizar = new Button();
            cbSituacao = new ComboBox();
            label2 = new Label();
            ((ISupportInitialize)dbTarefaBindingSource).BeginInit();
            ((ISupportInitialize)dbTarefaBindingSource1).BeginInit();
            ((ISupportInitialize)dgTarefas2).BeginInit();
            SuspendLayout();
            // 
            // dbTarefaBindingSource
            // 
            dbTarefaBindingSource.DataSource = typeof(DbTarefa);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 30);
            label1.TabIndex = 4;
            label1.Text = "Consulta Tarefas";
            // 
            // dbTarefaBindingSource1
            // 
            dbTarefaBindingSource1.DataSource = typeof(DbTarefa);
            // 
            // dgTarefas2
            // 
            dgTarefas2.AllowUserToAddRows = false;
            dgTarefas2.AllowUserToDeleteRows = false;
            dgTarefas2.AutoGenerateColumns = false;
            dgTarefas2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTarefas2.Columns.AddRange(new DataGridViewColumn[] { Codigo, Empresa, NOME, CNPJ, CIDADE, Tipo, Situacao, Obs, Dtregistro });
            dgTarefas2.DataSource = dbTarefaBindingSource;
            dgTarefas2.Location = new Point(28, 282);
            dgTarefas2.Name = "dgTarefas2";
            dgTarefas2.ReadOnly = true;
            dgTarefas2.Size = new Size(1010, 225);
            dgTarefas2.TabIndex = 5;
            dgTarefas2.CellDoubleClick += dgTarefas2_CellDoubleClick;
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Codigo.DataPropertyName = "Codigo";
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 71;
            // 
            // Empresa
            // 
            Empresa.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Empresa.DataPropertyName = "Empresa";
            Empresa.HeaderText = "Empresa";
            Empresa.Name = "Empresa";
            Empresa.ReadOnly = true;
            Empresa.Width = 77;
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
            // Tipo
            // 
            Tipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Tipo.DataPropertyName = "Tipo";
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 55;
            // 
            // Situacao
            // 
            Situacao.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Situacao.DataPropertyName = "Situacao";
            Situacao.HeaderText = "Situacao";
            Situacao.Name = "Situacao";
            Situacao.ReadOnly = true;
            Situacao.Width = 77;
            // 
            // Obs
            // 
            Obs.DataPropertyName = "Obs";
            Obs.HeaderText = "Obs";
            Obs.Name = "Obs";
            Obs.ReadOnly = true;
            Obs.Width = 53;
            // 
            // Dtregistro
            // 
            Dtregistro.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Dtregistro.DataPropertyName = "Dtregistro";
            Dtregistro.HeaderText = "Dtregistro";
            Dtregistro.Name = "Dtregistro";
            Dtregistro.ReadOnly = true;
            Dtregistro.Width = 84;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(28, 181);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(560, 23);
            txtPesquisa.TabIndex = 6;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // txtAtualizar
            // 
            txtAtualizar.Location = new Point(28, 126);
            txtAtualizar.Name = "txtAtualizar";
            txtAtualizar.Size = new Size(75, 23);
            txtAtualizar.TabIndex = 7;
            txtAtualizar.Text = "Atualizar";
            txtAtualizar.UseVisualStyleBackColor = true;
            txtAtualizar.Click += txtAtualizar_Click;
            // 
            // cbSituacao
            // 
            cbSituacao.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSituacao.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSituacao.FormattingEnabled = true;
            cbSituacao.Items.AddRange(new object[] { "Em andamento", "Aguardando terceiro", "Encerrado", "Pagamento alvará", "Solicitar Vigilância", "Vigilância solicitada", "Solicitar Bombeiro", "Aguardando pagamento bombeiro", "Solicitar alvará", "Alvará solicitado para Prefeitura" });
            cbSituacao.Location = new Point(790, 88);
            cbSituacao.Name = "cbSituacao";
            cbSituacao.Size = new Size(248, 23);
            cbSituacao.TabIndex = 8;
            cbSituacao.SelectedIndexChanged += cbSituacao_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(790, 45);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 9;
            label2.Text = "Filtrar por situação";
            // 
            // ConsultaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 650);
            Controls.Add(label2);
            Controls.Add(cbSituacao);
            Controls.Add(txtAtualizar);
            Controls.Add(txtPesquisa);
            Controls.Add(dgTarefas2);
            Controls.Add(label1);
            Name = "ConsultaTarefaForm";
            Text = "Consultar tarefas";
            ((ISupportInitialize)dbTarefaBindingSource).EndInit();
            ((ISupportInitialize)dbTarefaBindingSource1).EndInit();
            ((ISupportInitialize)dgTarefas2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private BindingSource dbTarefaBindingSource;
        private ColorDialog colorDialog1;
        private BindingSource dbTarefaBindingSource1;
        private DataGridView dgTarefas2;
        private TextBox txtPesquisa;
        private Button txtAtualizar;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Empresa;
        private DataGridViewTextBoxColumn NOME;
        private DataGridViewTextBoxColumn CNPJ;
        private DataGridViewTextBoxColumn CIDADE;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Situacao;
        private DataGridViewTextBoxColumn Obs;
        private DataGridViewTextBoxColumn Dtregistro;
        private ComboBox cbSituacao;
        private Label label2;
    }
}