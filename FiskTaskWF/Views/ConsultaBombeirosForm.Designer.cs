namespace FiscoTask
{
    partial class ConsultaBombeirosForm
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
            txtPesquisa = new TextBox();
            dgBombeiros = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Livro = new DataGridViewTextBoxColumn();
            NOME = new DataGridViewTextBoxColumn();
            CIDADE = new DataGridViewTextBoxColumn();
            PROCESSO = new DataGridViewTextBoxColumn();
            CNPJ = new DataGridViewTextBoxColumn();
            OBS = new DataGridViewTextBoxColumn();
            DATA_REGISTRO = new DataGridViewTextBoxColumn();
            dbBombeirosBindingSource = new BindingSource(components);
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgBombeiros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbBombeirosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(311, 30);
            label1.TabIndex = 5;
            label1.Text = "Consulta Processos Bombeiros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 90);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 6;
            label2.Text = "Pesquisar empresa";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(139, 82);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(443, 23);
            txtPesquisa.TabIndex = 7;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // dgBombeiros
            // 
            dgBombeiros.AllowUserToAddRows = false;
            dgBombeiros.AllowUserToDeleteRows = false;
            dgBombeiros.AutoGenerateColumns = false;
            dgBombeiros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBombeiros.Columns.AddRange(new DataGridViewColumn[] { Id, Livro, NOME, CIDADE, PROCESSO, CNPJ, OBS, DATA_REGISTRO });
            dgBombeiros.DataSource = dbBombeirosBindingSource;
            dgBombeiros.Location = new Point(26, 143);
            dgBombeiros.Name = "dgBombeiros";
            dgBombeiros.ReadOnly = true;
            dgBombeiros.Size = new Size(724, 295);
            dgBombeiros.TabIndex = 8;
            dgBombeiros.CellMouseDoubleClick += dgBombeiros_CellMouseDoubleClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 42;
            // 
            // Livro
            // 
            Livro.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Livro.DataPropertyName = "Livro";
            Livro.HeaderText = "Livro";
            Livro.Name = "Livro";
            Livro.ReadOnly = true;
            Livro.Width = 58;
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
            // PROCESSO
            // 
            PROCESSO.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            PROCESSO.DataPropertyName = "PROCESSO";
            PROCESSO.HeaderText = "PROCESSO";
            PROCESSO.Name = "PROCESSO";
            PROCESSO.ReadOnly = true;
            PROCESSO.Width = 90;
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
            // OBS
            // 
            OBS.DataPropertyName = "OBS";
            OBS.HeaderText = "OBS";
            OBS.Name = "OBS";
            OBS.ReadOnly = true;
            // 
            // DATA_REGISTRO
            // 
            DATA_REGISTRO.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DATA_REGISTRO.DataPropertyName = "DATA_REGISTRO";
            DATA_REGISTRO.HeaderText = "DATA_REGISTRO";
            DATA_REGISTRO.Name = "DATA_REGISTRO";
            DATA_REGISTRO.ReadOnly = true;
            DATA_REGISTRO.Width = 117;
            // 
            // dbBombeirosBindingSource
            // 
            dbBombeirosBindingSource.DataSource = typeof(DbBombeiros);
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(28, 51);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 9;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // ConsultaBombeirosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtualizar);
            Controls.Add(dgBombeiros);
            Controls.Add(txtPesquisa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultaBombeirosForm";
            Text = "Consulta Processos Bombeiros";
            ((System.ComponentModel.ISupportInitialize)dgBombeiros).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbBombeirosBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPesquisa;
        private DataGridView dgBombeiros;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Livro;
        private DataGridViewTextBoxColumn NOME;
        private DataGridViewTextBoxColumn CIDADE;
        private DataGridViewTextBoxColumn PROCESSO;
        private DataGridViewTextBoxColumn CNPJ;
        private DataGridViewTextBoxColumn OBS;
        private DataGridViewTextBoxColumn DATA_REGISTRO;
        private BindingSource dbBombeirosBindingSource;
        private Button btnAtualizar;
    }
}