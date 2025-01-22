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
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            txtPesquisa = new TextBox();
            txtAtualizar = new Button();
            cbSituacao = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbTipo = new ComboBox();
            btnFitroAlvara = new Button();
            btnOutrosPendentes = new Button();
            btnExport = new Button();
            dgTarefas2 = new DataGridView();
            dbTarefaBindingSource3 = new BindingSource(components);
            Codigo = new DataGridViewTextBoxColumn();
            Empresa = new DataGridViewTextBoxColumn();
            NOME = new DataGridViewTextBoxColumn();
            CNPJs = new DataGridViewTextBoxColumn();
            CIDADE = new DataGridViewTextBoxColumn();
            Situacao = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Obs = new DataGridViewTextBoxColumn();
            Dtregistro = new DataGridViewTextBoxColumn();
            ((ISupportInitialize)dgTarefas2).BeginInit();
            ((ISupportInitialize)dbTarefaBindingSource3).BeginInit();
            SuspendLayout();
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
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(156, 181);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(432, 23);
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
            label2.Location = new Point(790, 70);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 9;
            label2.Text = "Filtrar por situação";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 184);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 10;
            label3.Text = "Pesquisa por Empresa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(790, 114);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 14;
            label4.Text = "Filtrar por Tipo";
            // 
            // cbTipo
            // 
            cbTipo.AllowDrop = true;
            cbTipo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTipo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Alvará", "Bombeiro", "Vigilância Sanitária", "Consulta Jurídica", "Documentos gerais", "Outro", "Segunda via alvará", "Licença de transporte", "Alteração Ata/Documento", "Débitos", "Atualizar Alvará" });
            cbTipo.Location = new Point(790, 132);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(248, 23);
            cbTipo.TabIndex = 15;
            cbTipo.SelectedIndexChanged += cbTipo_SelectedIndexChanged;
            // 
            // btnFitroAlvara
            // 
            btnFitroAlvara.Location = new Point(790, 176);
            btnFitroAlvara.Name = "btnFitroAlvara";
            btnFitroAlvara.Size = new Size(128, 28);
            btnFitroAlvara.TabIndex = 16;
            btnFitroAlvara.Text = "Alvarás Pendentes";
            btnFitroAlvara.UseVisualStyleBackColor = true;
            btnFitroAlvara.Click += btnFitroAlvara_Click;
            // 
            // btnOutrosPendentes
            // 
            btnOutrosPendentes.Location = new Point(790, 210);
            btnOutrosPendentes.Name = "btnOutrosPendentes";
            btnOutrosPendentes.Size = new Size(128, 28);
            btnOutrosPendentes.TabIndex = 17;
            btnOutrosPendentes.Text = "Outros Pendentes";
            btnOutrosPendentes.UseVisualStyleBackColor = true;
            btnOutrosPendentes.Click += btnOutrosPendentes_Click;
            // 
            // btnExport
            // 
            btnExport.Image = Properties.Resources.file_type_excel_icon_130611__1_;
            btnExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnExport.Location = new Point(28, 238);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(93, 38);
            btnExport.TabIndex = 18;
            btnExport.Text = "Exportar";
            btnExport.TextAlign = ContentAlignment.MiddleRight;
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // dgTarefas2
            // 
            dgTarefas2.AllowUserToAddRows = false;
            dgTarefas2.AllowUserToDeleteRows = false;
            dgTarefas2.AutoGenerateColumns = false;
            dgTarefas2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTarefas2.Columns.AddRange(new DataGridViewColumn[] { Codigo, Empresa, NOME, CNPJs, CIDADE, Situacao, Tipo, Obs, Dtregistro });
            dgTarefas2.DataSource = dbTarefaBindingSource3;
            dgTarefas2.Location = new Point(28, 292);
            dgTarefas2.Name = "dgTarefas2";
            dgTarefas2.ReadOnly = true;
            dgTarefas2.Size = new Size(1304, 346);
            dgTarefas2.TabIndex = 19;
            dgTarefas2.CellDoubleClick += dgTarefas2_CellDoubleClick_1;
            // 
            // dbTarefaBindingSource3
            // 
            dbTarefaBindingSource3.DataSource = typeof(DbTarefa);
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
            // CNPJs
            // 
            CNPJs.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CNPJs.DataPropertyName = "CNPJ";
            CNPJs.HeaderText = "CNPJ";
            CNPJs.Name = "CNPJs";
            CNPJs.ReadOnly = true;
            CNPJs.Width = 59;
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
            // Situacao
            // 
            Situacao.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Situacao.DataPropertyName = "Situacao";
            Situacao.HeaderText = "Situacao";
            Situacao.Name = "Situacao";
            Situacao.ReadOnly = true;
            Situacao.Width = 77;
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
            // Obs
            // 
            Obs.DataPropertyName = "Obs";
            Obs.HeaderText = "Obs";
            Obs.MinimumWidth = 10;
            Obs.Name = "Obs";
            Obs.ReadOnly = true;
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
            // ConsultaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 650);
            Controls.Add(dgTarefas2);
            Controls.Add(btnExport);
            Controls.Add(btnOutrosPendentes);
            Controls.Add(btnFitroAlvara);
            Controls.Add(cbTipo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbSituacao);
            Controls.Add(txtAtualizar);
            Controls.Add(txtPesquisa);
            Controls.Add(label1);
            Name = "ConsultaTarefaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar tarefas";
            ((ISupportInitialize)dgTarefas2).EndInit();
            ((ISupportInitialize)dbTarefaBindingSource3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ColorDialog colorDialog1;
        private TextBox txtPesquisa;
        private Button txtAtualizar;
        private DataGridViewTextBoxColumn CNPJ;
        private ComboBox cbSituacao;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbTipo;
        private Button btnFitroAlvara;
        private Button btnOutrosPendentes;
        private Button btnExport;
        private DataGridView dgTarefas2;
        private BindingSource dbTarefaBindingSource3;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Empresa;
        private DataGridViewTextBoxColumn NOME;
        private DataGridViewTextBoxColumn CNPJs;
        private DataGridViewTextBoxColumn CIDADE;
        private DataGridViewTextBoxColumn Situacao;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Obs;
        private DataGridViewTextBoxColumn Dtregistro;
    }
}