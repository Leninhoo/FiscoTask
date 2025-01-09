namespace FiscoTask
{
    partial class RegistroBombeiroForm
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
            label3 = new Label();
            txtPesquisa = new TextBox();
            dgEmpresas = new DataGridView();
            EMPRESA = new DataGridViewTextBoxColumn();
            NOME = new DataGridViewTextBoxColumn();
            CNPJ = new DataGridViewTextBoxColumn();
            NOMEFANTASIA = new DataGridViewTextBoxColumn();
            CIDADE = new DataGridViewTextBoxColumn();
            empresaViewBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            txtLivro = new TextBox();
            txtProcesso = new TextBox();
            label4 = new Label();
            label5 = new Label();
            rtbObs = new RichTextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgEmpresas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empresaViewBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 71);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 40;
            label3.Text = "Nome da Empresa";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(113, 68);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(296, 23);
            txtPesquisa.TabIndex = 39;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // dgEmpresas
            // 
            dgEmpresas.AllowUserToAddRows = false;
            dgEmpresas.AllowUserToDeleteRows = false;
            dgEmpresas.AutoGenerateColumns = false;
            dgEmpresas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmpresas.Columns.AddRange(new DataGridViewColumn[] { EMPRESA, NOME, CNPJ, NOMEFANTASIA, CIDADE });
            dgEmpresas.DataSource = empresaViewBindingSource;
            dgEmpresas.Location = new Point(113, 97);
            dgEmpresas.Name = "dgEmpresas";
            dgEmpresas.ReadOnly = true;
            dgEmpresas.Size = new Size(520, 150);
            dgEmpresas.TabIndex = 38;
            dgEmpresas.CellMouseDoubleClick += dgEmpresas_CellMouseDoubleClick;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(318, 30);
            label1.TabIndex = 41;
            label1.Text = "Registro de Processo Bombeiro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 296);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 42;
            label2.Text = "Livro";
            // 
            // txtLivro
            // 
            txtLivro.Location = new Point(92, 293);
            txtLivro.Name = "txtLivro";
            txtLivro.ReadOnly = true;
            txtLivro.Size = new Size(96, 23);
            txtLivro.TabIndex = 43;
            // 
            // txtProcesso
            // 
            txtProcesso.Location = new Point(92, 322);
            txtProcesso.Name = "txtProcesso";
            txtProcesso.Size = new Size(317, 23);
            txtProcesso.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 325);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 44;
            label4.Text = "Processo n°";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 365);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 46;
            label5.Text = "Observações";
            // 
            // rtbObs
            // 
            rtbObs.Location = new Point(92, 391);
            rtbObs.Name = "rtbObs";
            rtbObs.Size = new Size(455, 133);
            rtbObs.TabIndex = 47;
            rtbObs.Text = "";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(558, 390);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 48;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(558, 419);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 49;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // RegistroBombeiroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 536);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(rtbObs);
            Controls.Add(label5);
            Controls.Add(txtProcesso);
            Controls.Add(label4);
            Controls.Add(txtLivro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtPesquisa);
            Controls.Add(dgEmpresas);
            Name = "RegistroBombeiroForm";
            Text = "Registro de Processo Bombeiro";
            ((System.ComponentModel.ISupportInitialize)dgEmpresas).EndInit();
            ((System.ComponentModel.ISupportInitialize)empresaViewBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtPesquisa;
        private DataGridView dgEmpresas;
        private Label label1;
        private Label label2;
        private TextBox txtLivro;
        private TextBox txtProcesso;
        private Label label4;
        private Label label5;
        private RichTextBox rtbObs;
        private DataGridViewTextBoxColumn EMPRESA;
        private DataGridViewTextBoxColumn NOME;
        private DataGridViewTextBoxColumn CNPJ;
        private DataGridViewTextBoxColumn NOMEFANTASIA;
        private DataGridViewTextBoxColumn CIDADE;
        private BindingSource empresaViewBindingSource;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}