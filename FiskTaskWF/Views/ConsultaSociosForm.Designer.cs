namespace FiscoTask
{
    partial class ConsultaSociosForm
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
            label3 = new Label();
            txtEmpresa = new TextBox();
            txtSocio = new TextBox();
            dgSocios = new DataGridView();
            EMPRESA = new DataGridViewTextBoxColumn();
            NOME = new DataGridViewTextBoxColumn();
            CNPJ = new DataGridViewTextBoxColumn();
            CIDADE = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            RG = new DataGridViewTextBoxColumn();
            SOCIO = new DataGridViewTextBoxColumn();
            ENDERECO = new DataGridViewTextBoxColumn();
            BAIRRO = new DataGridViewTextBoxColumn();
            CEP = new DataGridViewTextBoxColumn();
            FONE = new DataGridViewTextBoxColumn();
            CAPITAL = new DataGridViewTextBoxColumn();
            FUNCAO = new DataGridViewTextBoxColumn();
            ASSINA = new DataGridViewTextBoxColumn();
            DATA_NASCIMENTO = new DataGridViewTextBoxColumn();
            DATA_ADMISSAO = new DataGridViewTextBoxColumn();
            DATA_DESLIGAMENTO = new DataGridViewTextBoxColumn();
            DT_ALT_SOC = new DataGridViewTextBoxColumn();
            DT_FIM_SOC = new DataGridViewTextBoxColumn();
            FUNDO_INVEST = new DataGridViewTextBoxColumn();
            PERC_CAP_VOT = new DataGridViewTextBoxColumn();
            CPF_REP_LEG = new DataGridViewTextBoxColumn();
            QUALIFICACAO = new DataGridViewTextBoxColumn();
            QUALIF_REP_LEG = new DataGridViewTextBoxColumn();
            DIST_LUCRO = new DataGridViewTextBoxColumn();
            IR = new DataGridViewTextBoxColumn();
            PRO_LABORE = new DataGridViewTextBoxColumn();
            SIGNATARIO = new DataGridViewTextBoxColumn();
            dbSocioBindingSource1 = new BindingSource(components);
            dbSocioBindingSource = new BindingSource(components);
            dbSociosBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgSocios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbSocioBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbSocioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbSociosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 30);
            label1.TabIndex = 5;
            label1.Text = "Consultar sócios ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 6;
            label2.Text = "Pesquisar por Empresa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 7;
            label3.Text = "Pesquisar por Sócio";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(144, 94);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(486, 23);
            txtEmpresa.TabIndex = 8;
            txtEmpresa.TextChanged += txtEmpresa_TextChanged;
            // 
            // txtSocio
            // 
            txtSocio.Location = new Point(144, 133);
            txtSocio.Name = "txtSocio";
            txtSocio.Size = new Size(486, 23);
            txtSocio.TabIndex = 9;
            txtSocio.TextChanged += txtSocio_TextChanged;
            // 
            // dgSocios
            // 
            dgSocios.AllowUserToAddRows = false;
            dgSocios.AllowUserToDeleteRows = false;
            dgSocios.AutoGenerateColumns = false;
            dgSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSocios.Columns.AddRange(new DataGridViewColumn[] { EMPRESA, NOME, CNPJ, CIDADE, CPF, RG, SOCIO, ENDERECO, BAIRRO, CEP, FONE, CAPITAL, FUNCAO, ASSINA, DATA_NASCIMENTO, DATA_ADMISSAO, DATA_DESLIGAMENTO, DT_ALT_SOC, DT_FIM_SOC, FUNDO_INVEST, PERC_CAP_VOT, CPF_REP_LEG, QUALIFICACAO, QUALIF_REP_LEG, DIST_LUCRO, IR, PRO_LABORE, SIGNATARIO });
            dgSocios.DataSource = dbSocioBindingSource1;
            dgSocios.Location = new Point(12, 174);
            dgSocios.Name = "dgSocios";
            dgSocios.ReadOnly = true;
            dgSocios.Size = new Size(1086, 338);
            dgSocios.TabIndex = 10;
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
            // CPF
            // 
            CPF.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CPF.DataPropertyName = "CPF";
            CPF.HeaderText = "CPF";
            CPF.Name = "CPF";
            CPF.ReadOnly = true;
            CPF.Width = 53;
            // 
            // RG
            // 
            RG.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            RG.DataPropertyName = "RG";
            RG.HeaderText = "RG";
            RG.Name = "RG";
            RG.ReadOnly = true;
            RG.Width = 47;
            // 
            // SOCIO
            // 
            SOCIO.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SOCIO.DataPropertyName = "SOCIO";
            SOCIO.HeaderText = "SOCIO";
            SOCIO.Name = "SOCIO";
            SOCIO.ReadOnly = true;
            SOCIO.Width = 67;
            // 
            // ENDERECO
            // 
            ENDERECO.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ENDERECO.DataPropertyName = "ENDERECO";
            ENDERECO.HeaderText = "ENDERECO";
            ENDERECO.Name = "ENDERECO";
            ENDERECO.ReadOnly = true;
            ENDERECO.Width = 91;
            // 
            // BAIRRO
            // 
            BAIRRO.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            BAIRRO.DataPropertyName = "BAIRRO";
            BAIRRO.HeaderText = "BAIRRO";
            BAIRRO.Name = "BAIRRO";
            BAIRRO.ReadOnly = true;
            BAIRRO.Width = 73;
            // 
            // CEP
            // 
            CEP.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CEP.DataPropertyName = "CEP";
            CEP.HeaderText = "CEP";
            CEP.Name = "CEP";
            CEP.ReadOnly = true;
            CEP.Width = 53;
            // 
            // FONE
            // 
            FONE.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            FONE.DataPropertyName = "FONE";
            FONE.HeaderText = "FONE";
            FONE.Name = "FONE";
            FONE.ReadOnly = true;
            FONE.Width = 62;
            // 
            // CAPITAL
            // 
            CAPITAL.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CAPITAL.DataPropertyName = "CAPITAL";
            CAPITAL.HeaderText = "CAPITAL";
            CAPITAL.Name = "CAPITAL";
            CAPITAL.ReadOnly = true;
            CAPITAL.Width = 77;
            // 
            // FUNCAO
            // 
            FUNCAO.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            FUNCAO.DataPropertyName = "FUNCAO";
            FUNCAO.HeaderText = "FUNCAO";
            FUNCAO.Name = "FUNCAO";
            FUNCAO.ReadOnly = true;
            FUNCAO.Width = 80;
            // 
            // ASSINA
            // 
            ASSINA.DataPropertyName = "ASSINA";
            ASSINA.HeaderText = "ASSINA";
            ASSINA.Name = "ASSINA";
            ASSINA.ReadOnly = true;
            // 
            // DATA_NASCIMENTO
            // 
            DATA_NASCIMENTO.DataPropertyName = "DATA_NASCIMENTO";
            DATA_NASCIMENTO.HeaderText = "DATA_NASCIMENTO";
            DATA_NASCIMENTO.Name = "DATA_NASCIMENTO";
            DATA_NASCIMENTO.ReadOnly = true;
            // 
            // DATA_ADMISSAO
            // 
            DATA_ADMISSAO.DataPropertyName = "DATA_ADMISSAO";
            DATA_ADMISSAO.HeaderText = "DATA_ADMISSAO";
            DATA_ADMISSAO.Name = "DATA_ADMISSAO";
            DATA_ADMISSAO.ReadOnly = true;
            // 
            // DATA_DESLIGAMENTO
            // 
            DATA_DESLIGAMENTO.DataPropertyName = "DATA_DESLIGAMENTO";
            DATA_DESLIGAMENTO.HeaderText = "DATA_DESLIGAMENTO";
            DATA_DESLIGAMENTO.Name = "DATA_DESLIGAMENTO";
            DATA_DESLIGAMENTO.ReadOnly = true;
            // 
            // DT_ALT_SOC
            // 
            DT_ALT_SOC.DataPropertyName = "DT_ALT_SOC";
            DT_ALT_SOC.HeaderText = "DT_ALT_SOC";
            DT_ALT_SOC.Name = "DT_ALT_SOC";
            DT_ALT_SOC.ReadOnly = true;
            // 
            // DT_FIM_SOC
            // 
            DT_FIM_SOC.DataPropertyName = "DT_FIM_SOC";
            DT_FIM_SOC.HeaderText = "DT_FIM_SOC";
            DT_FIM_SOC.Name = "DT_FIM_SOC";
            DT_FIM_SOC.ReadOnly = true;
            // 
            // FUNDO_INVEST
            // 
            FUNDO_INVEST.DataPropertyName = "FUNDO_INVEST";
            FUNDO_INVEST.HeaderText = "FUNDO_INVEST";
            FUNDO_INVEST.Name = "FUNDO_INVEST";
            FUNDO_INVEST.ReadOnly = true;
            // 
            // PERC_CAP_VOT
            // 
            PERC_CAP_VOT.DataPropertyName = "PERC_CAP_VOT";
            PERC_CAP_VOT.HeaderText = "PERC_CAP_VOT";
            PERC_CAP_VOT.Name = "PERC_CAP_VOT";
            PERC_CAP_VOT.ReadOnly = true;
            // 
            // CPF_REP_LEG
            // 
            CPF_REP_LEG.DataPropertyName = "CPF_REP_LEG";
            CPF_REP_LEG.HeaderText = "CPF_REP_LEG";
            CPF_REP_LEG.Name = "CPF_REP_LEG";
            CPF_REP_LEG.ReadOnly = true;
            // 
            // QUALIFICACAO
            // 
            QUALIFICACAO.DataPropertyName = "QUALIFICACAO";
            QUALIFICACAO.HeaderText = "QUALIFICACAO";
            QUALIFICACAO.Name = "QUALIFICACAO";
            QUALIFICACAO.ReadOnly = true;
            // 
            // QUALIF_REP_LEG
            // 
            QUALIF_REP_LEG.DataPropertyName = "QUALIF_REP_LEG";
            QUALIF_REP_LEG.HeaderText = "QUALIF_REP_LEG";
            QUALIF_REP_LEG.Name = "QUALIF_REP_LEG";
            QUALIF_REP_LEG.ReadOnly = true;
            // 
            // DIST_LUCRO
            // 
            DIST_LUCRO.DataPropertyName = "DIST_LUCRO";
            DIST_LUCRO.HeaderText = "DIST_LUCRO";
            DIST_LUCRO.Name = "DIST_LUCRO";
            DIST_LUCRO.ReadOnly = true;
            // 
            // IR
            // 
            IR.DataPropertyName = "IR";
            IR.HeaderText = "IR";
            IR.Name = "IR";
            IR.ReadOnly = true;
            // 
            // PRO_LABORE
            // 
            PRO_LABORE.DataPropertyName = "PRO_LABORE";
            PRO_LABORE.HeaderText = "PRO_LABORE";
            PRO_LABORE.Name = "PRO_LABORE";
            PRO_LABORE.ReadOnly = true;
            // 
            // SIGNATARIO
            // 
            SIGNATARIO.DataPropertyName = "SIGNATARIO";
            SIGNATARIO.HeaderText = "SIGNATARIO";
            SIGNATARIO.Name = "SIGNATARIO";
            SIGNATARIO.ReadOnly = true;
            // 
            // dbSocioBindingSource1
            // 
            dbSocioBindingSource1.DataSource = typeof(DbSocio);
            // 
            // dbSocioBindingSource
            // 
            dbSocioBindingSource.DataSource = typeof(DbSocio);
            // 
            // ConsultaSociosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 567);
            Controls.Add(dgSocios);
            Controls.Add(txtSocio);
            Controls.Add(txtEmpresa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultaSociosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Sócios";
            ((System.ComponentModel.ISupportInitialize)dgSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbSocioBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbSocioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbSociosBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmpresa;
        private TextBox txtSocio;
        private DataGridView dgSocios;
        private BindingSource dbSociosBindingSource;
        private BindingSource dbSocioBindingSource;
        private DataGridViewTextBoxColumn EMPRESA;
        private DataGridViewTextBoxColumn NOME;
        private DataGridViewTextBoxColumn CNPJ;
        private DataGridViewTextBoxColumn CIDADE;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn RG;
        private DataGridViewTextBoxColumn SOCIO;
        private DataGridViewTextBoxColumn ENDERECO;
        private DataGridViewTextBoxColumn BAIRRO;
        private DataGridViewTextBoxColumn CEP;
        private DataGridViewTextBoxColumn FONE;
        private DataGridViewTextBoxColumn CAPITAL;
        private DataGridViewTextBoxColumn FUNCAO;
        private DataGridViewTextBoxColumn ASSINA;
        private DataGridViewTextBoxColumn DATA_NASCIMENTO;
        private DataGridViewTextBoxColumn DATA_ADMISSAO;
        private DataGridViewTextBoxColumn DATA_DESLIGAMENTO;
        private DataGridViewTextBoxColumn DT_ALT_SOC;
        private DataGridViewTextBoxColumn DT_FIM_SOC;
        private DataGridViewTextBoxColumn FUNDO_INVEST;
        private DataGridViewTextBoxColumn PERC_CAP_VOT;
        private DataGridViewTextBoxColumn CPF_REP_LEG;
        private DataGridViewTextBoxColumn QUALIFICACAO;
        private DataGridViewTextBoxColumn QUALIF_REP_LEG;
        private DataGridViewTextBoxColumn DIST_LUCRO;
        private DataGridViewTextBoxColumn IR;
        private DataGridViewTextBoxColumn PRO_LABORE;
        private DataGridViewTextBoxColumn SIGNATARIO;
        private BindingSource dbSocioBindingSource1;
    }
}