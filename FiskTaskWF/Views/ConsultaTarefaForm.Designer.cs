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
            Codigo = new DataGridViewTextBoxColumn();
            Empresa = new DataGridViewTextBoxColumn();
            NOME = new DataGridViewTextBoxColumn();
            CIDADE = new DataGridViewTextBoxColumn();
            Situacao = new DataGridViewTextBoxColumn();
            Fase = new DataGridViewTextBoxColumn();
            Ativo = new DataGridViewCheckBoxColumn();
            EntregaTaxaAlvara = new DataGridViewCheckBoxColumn();
            Bombeiro = new DataGridViewCheckBoxColumn();
            VigilanciaSanitaria = new DataGridViewCheckBoxColumn();
            TaxaAlvaraPgto = new DataGridViewCheckBoxColumn();
            Obs = new DataGridViewTextBoxColumn();
            Dtregistro = new DataGridViewTextBoxColumn();
            CNPJs = new DataGridViewTextBoxColumn();
            dbTarefaBindingSource3 = new BindingSource(components);
            cbEmAndamento = new CheckBox();
            lblTarefasPendentes = new Label();
            clbDocumentos = new CheckedListBox();
            lblTarefasAtivas = new Label();
            lblTarefasConcluidas = new Label();
            gbInfos = new GroupBox();
            lblSuspensas = new Label();
            btnExportarTudo = new Button();
            ((ISupportInitialize)dgTarefas2).BeginInit();
            ((ISupportInitialize)dbTarefaBindingSource3).BeginInit();
            gbInfos.SuspendLayout();
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
            txtPesquisa.TabIndex = 1;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // txtAtualizar
            // 
            txtAtualizar.Location = new Point(28, 126);
            txtAtualizar.Name = "txtAtualizar";
            txtAtualizar.Size = new Size(75, 23);
            txtAtualizar.TabIndex = 3;
            txtAtualizar.Text = "Atualizar";
            txtAtualizar.UseVisualStyleBackColor = true;
            txtAtualizar.Click += txtAtualizar_Click;
            // 
            // cbSituacao
            // 
            cbSituacao.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSituacao.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSituacao.FormattingEnabled = true;
            cbSituacao.ItemHeight = 15;
            cbSituacao.Location = new Point(926, 88);
            cbSituacao.Name = "cbSituacao";
            cbSituacao.Size = new Size(248, 23);
            cbSituacao.TabIndex = 8;
            cbSituacao.SelectedIndexChanged += cbSituacao_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(926, 70);
            label2.Name = "label2";
            label2.Size = new Size(152, 15);
            label2.TabIndex = 9;
            label2.Text = "Filtrar por Fase/Andamento";
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
            label4.Location = new Point(926, 114);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 14;
            label4.Text = "Filtrar por Situação";
            // 
            // cbTipo
            // 
            cbTipo.AllowDrop = true;
            cbTipo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTipo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbTipo.FormattingEnabled = true;
            cbTipo.ItemHeight = 15;
            cbTipo.Location = new Point(926, 132);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(248, 23);
            cbTipo.TabIndex = 15;
            cbTipo.SelectedIndexChanged += cbTipo_SelectedIndexChanged;
            // 
            // btnFitroAlvara
            // 
            btnFitroAlvara.Location = new Point(926, 176);
            btnFitroAlvara.Name = "btnFitroAlvara";
            btnFitroAlvara.Size = new Size(128, 28);
            btnFitroAlvara.TabIndex = 6;
            btnFitroAlvara.Text = "Alvarás em Análise";
            btnFitroAlvara.UseVisualStyleBackColor = true;
            btnFitroAlvara.Click += btnFitroAlvara_Click;
            // 
            // btnOutrosPendentes
            // 
            btnOutrosPendentes.Location = new Point(926, 210);
            btnOutrosPendentes.Name = "btnOutrosPendentes";
            btnOutrosPendentes.Size = new Size(128, 28);
            btnOutrosPendentes.TabIndex = 7;
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
            btnExport.Size = new Size(175, 38);
            btnExport.TabIndex = 8;
            btnExport.Text = "Exportar Dados Filtrados";
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
            dgTarefas2.Columns.AddRange(new DataGridViewColumn[] { Codigo, Empresa, NOME, CIDADE, Situacao, Fase, Ativo, EntregaTaxaAlvara, Bombeiro, VigilanciaSanitaria, TaxaAlvaraPgto, Obs, Dtregistro, CNPJs });
            dgTarefas2.DataSource = dbTarefaBindingSource3;
            dgTarefas2.Location = new Point(28, 292);
            dgTarefas2.Name = "dgTarefas2";
            dgTarefas2.ReadOnly = true;
            dgTarefas2.Size = new Size(1304, 346);
            dgTarefas2.TabIndex = 2;
            dgTarefas2.CellDoubleClick += dgTarefas2_CellDoubleClick_1;
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
            // Fase
            // 
            Fase.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Fase.DataPropertyName = "Fase";
            Fase.HeaderText = "Fase";
            Fase.Name = "Fase";
            Fase.ReadOnly = true;
            Fase.Width = 55;
            // 
            // Ativo
            // 
            Ativo.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Ativo.DataPropertyName = "Ativo";
            Ativo.HeaderText = "Ativo";
            Ativo.Name = "Ativo";
            Ativo.ReadOnly = true;
            Ativo.Width = 41;
            // 
            // EntregaTaxaAlvara
            // 
            EntregaTaxaAlvara.DataPropertyName = "EntregaTaxaAlvara";
            EntregaTaxaAlvara.HeaderText = "EntregaTaxaAlvara";
            EntregaTaxaAlvara.Name = "EntregaTaxaAlvara";
            EntregaTaxaAlvara.ReadOnly = true;
            // 
            // Bombeiro
            // 
            Bombeiro.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Bombeiro.DataPropertyName = "Bombeiro";
            Bombeiro.HeaderText = "Bombeiro";
            Bombeiro.Name = "Bombeiro";
            Bombeiro.ReadOnly = true;
            Bombeiro.Width = 65;
            // 
            // VigilanciaSanitaria
            // 
            VigilanciaSanitaria.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            VigilanciaSanitaria.DataPropertyName = "VigilanciaSanitaria";
            VigilanciaSanitaria.HeaderText = "VigilanciaSanitaria";
            VigilanciaSanitaria.Name = "VigilanciaSanitaria";
            VigilanciaSanitaria.ReadOnly = true;
            VigilanciaSanitaria.Width = 109;
            // 
            // TaxaAlvaraPgto
            // 
            TaxaAlvaraPgto.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TaxaAlvaraPgto.DataPropertyName = "TaxaAlvaraPgto";
            TaxaAlvaraPgto.HeaderText = "TaxaAlvaraPgto";
            TaxaAlvaraPgto.Name = "TaxaAlvaraPgto";
            TaxaAlvaraPgto.ReadOnly = true;
            TaxaAlvaraPgto.Width = 94;
            // 
            // Obs
            // 
            Obs.DataPropertyName = "Obs";
            Obs.HeaderText = "Obs";
            Obs.Name = "Obs";
            Obs.ReadOnly = true;
            // 
            // Dtregistro
            // 
            Dtregistro.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Dtregistro.DataPropertyName = "Dtregistro";
            Dtregistro.HeaderText = "Data Registro";
            Dtregistro.Name = "Dtregistro";
            Dtregistro.ReadOnly = true;
            Dtregistro.Width = 102;
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
            // dbTarefaBindingSource3
            // 
            dbTarefaBindingSource3.DataSource = typeof(DbTarefa);
            // 
            // cbEmAndamento
            // 
            cbEmAndamento.AutoSize = true;
            cbEmAndamento.Checked = true;
            cbEmAndamento.CheckState = CheckState.Checked;
            cbEmAndamento.Location = new Point(156, 219);
            cbEmAndamento.Name = "cbEmAndamento";
            cbEmAndamento.Size = new Size(131, 19);
            cbEmAndamento.TabIndex = 20;
            cbEmAndamento.Text = "Somente Pendentes";
            cbEmAndamento.UseVisualStyleBackColor = true;
            // 
            // lblTarefasPendentes
            // 
            lblTarefasPendentes.AutoSize = true;
            lblTarefasPendentes.Location = new Point(6, 19);
            lblTarefasPendentes.Name = "lblTarefasPendentes";
            lblTarefasPendentes.Size = new Size(277, 15);
            lblTarefasPendentes.TabIndex = 21;
            lblTarefasPendentes.Text = "O número de tarefas pendentes no momento é de: ";
            // 
            // clbDocumentos
            // 
            clbDocumentos.FormattingEnabled = true;
            clbDocumentos.Items.AddRange(new object[] { "Taxa de alvará paga", "Bombeiro", "Vigilância Sanitária", "Taxa de Alvará Entregue" });
            clbDocumentos.Location = new Point(729, 88);
            clbDocumentos.Name = "clbDocumentos";
            clbDocumentos.Size = new Size(165, 76);
            clbDocumentos.TabIndex = 23;
            clbDocumentos.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // lblTarefasAtivas
            // 
            lblTarefasAtivas.AutoSize = true;
            lblTarefasAtivas.Location = new Point(6, 34);
            lblTarefasAtivas.Name = "lblTarefasAtivas";
            lblTarefasAtivas.Size = new Size(176, 15);
            lblTarefasAtivas.TabIndex = 24;
            lblTarefasAtivas.Text = "O número de tarefas ativas é de:";
            // 
            // lblTarefasConcluidas
            // 
            lblTarefasConcluidas.AutoSize = true;
            lblTarefasConcluidas.BackColor = Color.FromArgb(192, 255, 192);
            lblTarefasConcluidas.Location = new Point(6, 49);
            lblTarefasConcluidas.Name = "lblTarefasConcluidas";
            lblTarefasConcluidas.Size = new Size(203, 15);
            lblTarefasConcluidas.TabIndex = 25;
            lblTarefasConcluidas.Text = "O número de tarefas concluídas é de:";
            // 
            // gbInfos
            // 
            gbInfos.Controls.Add(lblSuspensas);
            gbInfos.Controls.Add(lblTarefasPendentes);
            gbInfos.Controls.Add(lblTarefasConcluidas);
            gbInfos.Controls.Add(lblTarefasAtivas);
            gbInfos.Location = new Point(237, 9);
            gbInfos.Name = "gbInfos";
            gbInfos.Size = new Size(351, 100);
            gbInfos.TabIndex = 26;
            gbInfos.TabStop = false;
            gbInfos.Text = "Informações";
            // 
            // lblSuspensas
            // 
            lblSuspensas.AutoSize = true;
            lblSuspensas.Location = new Point(6, 64);
            lblSuspensas.Name = "lblSuspensas";
            lblSuspensas.Size = new Size(199, 15);
            lblSuspensas.TabIndex = 26;
            lblSuspensas.Text = "O número de tarefas suspensas é de:";
            // 
            // btnExportarTudo
            // 
            btnExportarTudo.Image = Properties.Resources.file_type_excel_icon_130611__1_;
            btnExportarTudo.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportarTudo.Location = new Point(209, 238);
            btnExportarTudo.Name = "btnExportarTudo";
            btnExportarTudo.Size = new Size(175, 38);
            btnExportarTudo.TabIndex = 27;
            btnExportarTudo.Text = "Exportar todos os Dados";
            btnExportarTudo.TextAlign = ContentAlignment.MiddleRight;
            btnExportarTudo.UseVisualStyleBackColor = true;
            btnExportarTudo.Click += btnExportarTudo_Click;
            // 
            // ConsultaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 650);
            Controls.Add(btnExportarTudo);
            Controls.Add(gbInfos);
            Controls.Add(clbDocumentos);
            Controls.Add(cbEmAndamento);
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
            gbInfos.ResumeLayout(false);
            gbInfos.PerformLayout();
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
        private CheckBox cbEmAndamento;
        private Label lblTarefasPendentes;
        private CheckedListBox clbDocumentos;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Empresa;
        private DataGridViewTextBoxColumn NOME;
        private DataGridViewTextBoxColumn CIDADE;
        private DataGridViewTextBoxColumn Situacao;
        private DataGridViewTextBoxColumn Fase;
        private DataGridViewCheckBoxColumn Ativo;
        private DataGridViewCheckBoxColumn EntregaTaxaAlvara;
        private DataGridViewCheckBoxColumn Bombeiro;
        private DataGridViewCheckBoxColumn VigilanciaSanitaria;
        private DataGridViewCheckBoxColumn TaxaAlvaraPgto;
        private DataGridViewTextBoxColumn Obs;
        private DataGridViewTextBoxColumn Dtregistro;
        private DataGridViewTextBoxColumn CNPJs;
        private Label lblTarefasAtivas;
        private Label lblTarefasConcluidas;
        private GroupBox gbInfos;
        private Label lblSuspensas;
        private Button btnExportarTudo;
    }
}