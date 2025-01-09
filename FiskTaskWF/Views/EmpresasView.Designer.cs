namespace FiscoTask
{
    partial class EmpresasView
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
            dgEmpresas = new DataGridView();
            EMPRESA = new DataGridViewTextBoxColumn();
            NOME = new DataGridViewTextBoxColumn();
            CNPJ = new DataGridViewTextBoxColumn();
            NOMEFANTASIA = new DataGridViewTextBoxColumn();
            ENDERECO = new DataGridViewTextBoxColumn();
            NUMERO = new DataGridViewTextBoxColumn();
            BAIRRO = new DataGridViewTextBoxColumn();
            COMPLEMENTO = new DataGridViewTextBoxColumn();
            CIDADE = new DataGridViewTextBoxColumn();
            UF = new DataGridViewTextBoxColumn();
            CEP = new DataGridViewTextBoxColumn();
            REGIME = new DataGridViewTextBoxColumn();
            E_MAIL = new DataGridViewTextBoxColumn();
            FONE = new DataGridViewTextBoxColumn();
            RESPONSAVEL = new DataGridViewTextBoxColumn();
            IE = new DataGridViewTextBoxColumn();
            empresaViewBindingSource = new BindingSource(components);
            label1 = new Label();
            txtPesquisa = new TextBox();
            btnAtualizar = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgEmpresas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empresaViewBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgEmpresas
            // 
            dgEmpresas.AllowUserToAddRows = false;
            dgEmpresas.AllowUserToDeleteRows = false;
            dgEmpresas.AutoGenerateColumns = false;
            dgEmpresas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmpresas.Columns.AddRange(new DataGridViewColumn[] { EMPRESA, NOME, CNPJ, NOMEFANTASIA, ENDERECO, NUMERO, BAIRRO, COMPLEMENTO, CIDADE, UF, CEP, REGIME, E_MAIL, FONE, RESPONSAVEL, IE });
            dgEmpresas.DataSource = empresaViewBindingSource;
            dgEmpresas.Location = new Point(37, 199);
            dgEmpresas.Name = "dgEmpresas";
            dgEmpresas.ReadOnly = true;
            dgEmpresas.Size = new Size(1283, 276);
            dgEmpresas.TabIndex = 3;
            dgEmpresas.CellDoubleClick += dgEmpresas_CellDoubleClick;
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
            // NOMEFANTASIA
            // 
            NOMEFANTASIA.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            NOMEFANTASIA.DataPropertyName = "NOMEFANTASIA";
            NOMEFANTASIA.HeaderText = "NOMEFANTASIA";
            NOMEFANTASIA.Name = "NOMEFANTASIA";
            NOMEFANTASIA.ReadOnly = true;
            NOMEFANTASIA.Width = 119;
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
            // NUMERO
            // 
            NUMERO.DataPropertyName = "NUMERO";
            NUMERO.HeaderText = "NUMERO";
            NUMERO.Name = "NUMERO";
            NUMERO.ReadOnly = true;
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
            // COMPLEMENTO
            // 
            COMPLEMENTO.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            COMPLEMENTO.DataPropertyName = "COMPLEMENTO";
            COMPLEMENTO.HeaderText = "COMPLEMENTO";
            COMPLEMENTO.Name = "COMPLEMENTO";
            COMPLEMENTO.ReadOnly = true;
            COMPLEMENTO.Width = 119;
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
            // UF
            // 
            UF.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            UF.DataPropertyName = "UF";
            UF.HeaderText = "UF";
            UF.Name = "UF";
            UF.ReadOnly = true;
            UF.Width = 46;
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
            // REGIME
            // 
            REGIME.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            REGIME.DataPropertyName = "REGIME";
            REGIME.HeaderText = "REGIME";
            REGIME.Name = "REGIME";
            REGIME.ReadOnly = true;
            REGIME.Width = 73;
            // 
            // E_MAIL
            // 
            E_MAIL.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            E_MAIL.DataPropertyName = "E_MAIL";
            E_MAIL.HeaderText = "E_MAIL";
            E_MAIL.Name = "E_MAIL";
            E_MAIL.ReadOnly = true;
            E_MAIL.Width = 71;
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
            // RESPONSAVEL
            // 
            RESPONSAVEL.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            RESPONSAVEL.DataPropertyName = "RESPONSAVEL";
            RESPONSAVEL.HeaderText = "RESPONSAVEL";
            RESPONSAVEL.Name = "RESPONSAVEL";
            RESPONSAVEL.ReadOnly = true;
            RESPONSAVEL.Width = 108;
            // 
            // IE
            // 
            IE.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            IE.DataPropertyName = "IE";
            IE.HeaderText = "IE";
            IE.Name = "IE";
            IE.ReadOnly = true;
            IE.Width = 41;
            // 
            // empresaViewBindingSource
            // 
            empresaViewBindingSource.DataSource = typeof(EmpresaView);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 40);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 0;
            label1.Text = "Lista de empresas cadastradas";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(153, 144);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(527, 23);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(37, 99);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 4;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 147);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 5;
            label2.Text = "Pesquisar Empresas";
            // 
            // EmpresasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(btnAtualizar);
            Controls.Add(txtPesquisa);
            Controls.Add(label1);
            Controls.Add(dgEmpresas);
            Name = "EmpresasView";
            Size = new Size(1377, 530);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)dgEmpresas).EndInit();
            ((System.ComponentModel.ISupportInitialize)empresaViewBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgEmpresas;
        private BindingSource empresaViewBindingSource;
        private Label label1;
        private TextBox txtPesquisa;
        private DataGridViewTextBoxColumn EMPRESA;
        private DataGridViewTextBoxColumn NOME;
        private DataGridViewTextBoxColumn CNPJ;
        private DataGridViewTextBoxColumn NOMEFANTASIA;
        private DataGridViewTextBoxColumn ENDERECO;
        private DataGridViewTextBoxColumn NUMERO;
        private DataGridViewTextBoxColumn BAIRRO;
        private DataGridViewTextBoxColumn COMPLEMENTO;
        private DataGridViewTextBoxColumn CIDADE;
        private DataGridViewTextBoxColumn UF;
        private DataGridViewTextBoxColumn CEP;
        private DataGridViewTextBoxColumn REGIME;
        private DataGridViewTextBoxColumn E_MAIL;
        private DataGridViewTextBoxColumn FONE;
        private DataGridViewTextBoxColumn RESPONSAVEL;
        private DataGridViewTextBoxColumn IE;
        private Button btnAtualizar;
        private Label label2;
    }
}
