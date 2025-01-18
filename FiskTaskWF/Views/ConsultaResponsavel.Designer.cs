namespace FiscoTask
{
    partial class ConsultaResponsavel
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
            txtEmpresa = new TextBox();
            dgResponsaveis = new DataGridView();
            LIVRO = new DataGridViewTextBoxColumn();
            ABERTURA = new DataGridViewTextBoxColumn();
            REGIME = new DataGridViewTextBoxColumn();
            RESPONSAVEL = new DataGridViewTextBoxColumn();
            NOME = new DataGridViewTextBoxColumn();
            CNPJ = new DataGridViewTextBoxColumn();
            CIDADE = new DataGridViewTextBoxColumn();
            dbResponsaveisBindingSource = new BindingSource(components);
            txtResponsaveis = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgResponsaveis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbResponsaveisBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(439, 30);
            label1.TabIndex = 5;
            label1.Text = "Consultar resposáveis internos por empresa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 6;
            label2.Text = "Pesquisa por empresa";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(157, 108);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(523, 23);
            txtEmpresa.TabIndex = 1;
            txtEmpresa.TextChanged += txtEmpresa_TextChanged;
            // 
            // dgResponsaveis
            // 
            dgResponsaveis.AllowUserToAddRows = false;
            dgResponsaveis.AllowUserToDeleteRows = false;
            dgResponsaveis.AutoGenerateColumns = false;
            dgResponsaveis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgResponsaveis.Columns.AddRange(new DataGridViewColumn[] { LIVRO, ABERTURA, REGIME, RESPONSAVEL, NOME, CNPJ, CIDADE });
            dgResponsaveis.DataSource = dbResponsaveisBindingSource;
            dgResponsaveis.Location = new Point(12, 175);
            dgResponsaveis.Name = "dgResponsaveis";
            dgResponsaveis.ReadOnly = true;
            dgResponsaveis.Size = new Size(1084, 271);
            dgResponsaveis.TabIndex = 3;
            // 
            // LIVRO
            // 
            LIVRO.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            LIVRO.DataPropertyName = "LIVRO";
            LIVRO.HeaderText = "LIVRO";
            LIVRO.Name = "LIVRO";
            LIVRO.ReadOnly = true;
            LIVRO.Width = 64;
            // 
            // ABERTURA
            // 
            ABERTURA.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ABERTURA.DataPropertyName = "ABERTURA";
            ABERTURA.HeaderText = "ABERTURA";
            ABERTURA.Name = "ABERTURA";
            ABERTURA.ReadOnly = true;
            ABERTURA.Width = 88;
            // 
            // REGIME
            // 
            REGIME.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            REGIME.DataPropertyName = "REGIME";
            REGIME.HeaderText = "REGIME";
            REGIME.Name = "REGIME";
            REGIME.ReadOnly = true;
            REGIME.Width = 73;
            // 
            // RESPONSAVEL
            // 
            RESPONSAVEL.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            RESPONSAVEL.DataPropertyName = "RESPONSAVEL";
            RESPONSAVEL.HeaderText = "RESPONSAVEL";
            RESPONSAVEL.Name = "RESPONSAVEL";
            RESPONSAVEL.ReadOnly = true;
            RESPONSAVEL.Width = 108;
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
            // dbResponsaveisBindingSource
            // 
            dbResponsaveisBindingSource.DataSource = typeof(DbResponsaveis);
            // 
            // txtResponsaveis
            // 
            txtResponsaveis.Location = new Point(157, 137);
            txtResponsaveis.Name = "txtResponsaveis";
            txtResponsaveis.Size = new Size(523, 23);
            txtResponsaveis.TabIndex = 2;
            txtResponsaveis.TextChanged += txtResponsaveis_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 9;
            label3.Text = "Pesquisa por responsavel";
            // 
            // ConsultaResponsavel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 458);
            Controls.Add(txtResponsaveis);
            Controls.Add(label3);
            Controls.Add(dgResponsaveis);
            Controls.Add(txtEmpresa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultaResponsavel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Responsável";
            ((System.ComponentModel.ISupportInitialize)dgResponsaveis).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbResponsaveisBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmpresa;
        private DataGridView dgResponsaveis;
        private TextBox txtResponsaveis;
        private Label label3;
        private DataGridViewTextBoxColumn LIVRO;
        private DataGridViewTextBoxColumn ABERTURA;
        private DataGridViewTextBoxColumn REGIME;
        private DataGridViewTextBoxColumn RESPONSAVEL;
        private DataGridViewTextBoxColumn NOME;
        private DataGridViewTextBoxColumn CNPJ;
        private DataGridViewTextBoxColumn CIDADE;
        private BindingSource dbResponsaveisBindingSource;
    }
}