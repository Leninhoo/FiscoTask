namespace FiscoTask.Views
{
    partial class RegistroProcesso
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
            txtID = new TextBox();
            txtRazao = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtCidade = new TextBox();
            label5 = new Label();
            txtCNPJ = new TextBox();
            groupBox1 = new GroupBox();
            dgPesquisaEmpresa = new DataGridView();
            EMPRESA = new DataGridViewTextBoxColumn();
            NOME = new DataGridViewTextBoxColumn();
            CNPJ = new DataGridViewTextBoxColumn();
            CIDADE = new DataGridViewTextBoxColumn();
            UF = new DataGridViewTextBoxColumn();
            empresaViewBindingSource = new BindingSource(components);
            txtPesquisa = new TextBox();
            label7 = new Label();
            cbSituacao = new ComboBox();
            label6 = new Label();
            label8 = new Label();
            cbAndamento = new ComboBox();
            label9 = new Label();
            cbTipo = new ComboBox();
            listasComboBoxBindingSource = new BindingSource(components);
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnCarimbo = new Button();
            rtfEditor = new FiscoTask.Controls.RtfEditor();
            txtCnpjLimpo = new TextBox();
            label10 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPesquisaEmpresa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empresaViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listasComboBoxBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(225, 30);
            label1.TabIndex = 5;
            label1.Text = "Registro de Processos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 58);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 7;
            label2.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(74, 50);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(53, 23);
            txtID.TabIndex = 80;
            // 
            // txtRazao
            // 
            txtRazao.Location = new Point(191, 50);
            txtRazao.Name = "txtRazao";
            txtRazao.ReadOnly = true;
            txtRazao.Size = new Size(335, 23);
            txtRazao.TabIndex = 108;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 58);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 9;
            label3.Text = "Empresa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 87);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 11;
            label4.Text = "CNPJ";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(347, 79);
            txtCidade.Name = "txtCidade";
            txtCidade.ReadOnly = true;
            txtCidade.Size = new Size(179, 23);
            txtCidade.TabIndex = 140;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(289, 87);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 13;
            label5.Text = "Cidade";
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(75, 79);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.ReadOnly = true;
            txtCNPJ.Size = new Size(208, 23);
            txtCNPJ.TabIndex = 120;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgPesquisaEmpresa);
            groupBox1.Controls.Add(txtPesquisa);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(549, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(657, 198);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisar empresa";
            // 
            // dgPesquisaEmpresa
            // 
            dgPesquisaEmpresa.AllowUserToAddRows = false;
            dgPesquisaEmpresa.AllowUserToDeleteRows = false;
            dgPesquisaEmpresa.AutoGenerateColumns = false;
            dgPesquisaEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPesquisaEmpresa.Columns.AddRange(new DataGridViewColumn[] { EMPRESA, NOME, CNPJ, CIDADE, UF });
            dgPesquisaEmpresa.DataSource = empresaViewBindingSource;
            dgPesquisaEmpresa.Location = new Point(7, 82);
            dgPesquisaEmpresa.Name = "dgPesquisaEmpresa";
            dgPesquisaEmpresa.ReadOnly = true;
            dgPesquisaEmpresa.Size = new Size(632, 110);
            dgPesquisaEmpresa.TabIndex = 19;
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
            CNPJ.DataPropertyName = "CNPJ";
            CNPJ.HeaderText = "CNPJ";
            CNPJ.Name = "CNPJ";
            CNPJ.ReadOnly = true;
            // 
            // CIDADE
            // 
            CIDADE.DataPropertyName = "CIDADE";
            CIDADE.HeaderText = "CIDADE";
            CIDADE.Name = "CIDADE";
            CIDADE.ReadOnly = true;
            // 
            // UF
            // 
            UF.DataPropertyName = "UF";
            UF.HeaderText = "UF";
            UF.Name = "UF";
            UF.ReadOnly = true;
            // 
            // empresaViewBindingSource
            // 
            empresaViewBindingSource.DataSource = typeof(EmpresaView);
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(65, 22);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(345, 23);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 30);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 17;
            label7.Text = "Empresa";
            // 
            // cbSituacao
            // 
            cbSituacao.FormattingEnabled = true;
            cbSituacao.Location = new Point(75, 145);
            cbSituacao.Name = "cbSituacao";
            cbSituacao.Size = new Size(224, 23);
            cbSituacao.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 148);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 18;
            label6.Text = "Situação";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 177);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 20;
            label8.Text = "Andamento";
            // 
            // cbAndamento
            // 
            cbAndamento.FormattingEnabled = true;
            cbAndamento.Location = new Point(92, 174);
            cbAndamento.Name = "cbAndamento";
            cbAndamento.Size = new Size(224, 23);
            cbAndamento.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 206);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 22;
            label9.Text = "Tipo Processo";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(103, 203);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(230, 23);
            cbTipo.TabIndex = 4;
            // 
            // listasComboBoxBindingSource
            // 
            listasComboBoxBindingSource.DataSource = typeof(Models.ListasComboBox);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(16, 774);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(97, 774);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCarimbo
            // 
            btnCarimbo.BackColor = Color.FromArgb(255, 128, 128);
            btnCarimbo.Location = new Point(26, 236);
            btnCarimbo.Name = "btnCarimbo";
            btnCarimbo.Size = new Size(101, 23);
            btnCarimbo.TabIndex = 26;
            btnCarimbo.Text = "Adicionar Data";
            btnCarimbo.UseVisualStyleBackColor = false;
            btnCarimbo.Click += btnCarimbo_Click;
            // 
            // rtfEditor
            // 
            rtfEditor.Location = new Point(17, 316);
            rtfEditor.Name = "rtfEditor";
            rtfEditor.Size = new Size(819, 435);
            rtfEditor.TabIndex = 141;
            // 
            // txtCnpjLimpo
            // 
            txtCnpjLimpo.Location = new Point(92, 108);
            txtCnpjLimpo.Name = "txtCnpjLimpo";
            txtCnpjLimpo.ReadOnly = true;
            txtCnpjLimpo.Size = new Size(190, 23);
            txtCnpjLimpo.TabIndex = 143;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 116);
            label10.Name = "label10";
            label10.Size = new Size(71, 15);
            label10.TabIndex = 142;
            label10.Text = "CNPJ Limpo";
            // 
            // RegistroProcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 809);
            Controls.Add(txtCnpjLimpo);
            Controls.Add(label10);
            Controls.Add(rtfEditor);
            Controls.Add(btnCarimbo);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label9);
            Controls.Add(cbTipo);
            Controls.Add(label8);
            Controls.Add(cbAndamento);
            Controls.Add(label6);
            Controls.Add(cbSituacao);
            Controls.Add(groupBox1);
            Controls.Add(txtCidade);
            Controls.Add(label5);
            Controls.Add(txtCNPJ);
            Controls.Add(label4);
            Controls.Add(txtRazao);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroProcesso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Processos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPesquisaEmpresa).EndInit();
            ((System.ComponentModel.ISupportInitialize)empresaViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)listasComboBoxBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtID;
        private TextBox txtRazao;
        private Label label3;
        private Label label4;
        private TextBox txtCidade;
        private Label label5;
        private TextBox txtCNPJ;
        private GroupBox groupBox1;
        private TextBox txtPesquisa;
        private Label label7;
        private DataGridView dgPesquisaEmpresa;
        private BindingSource empresaViewBindingSource;
        private ComboBox cbSituacao;
        private Label label6;
        private Label label8;
        private ComboBox cbAndamento;
        private Label label9;
        private ComboBox cbTipo;
        private BindingSource listasComboBoxBindingSource;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnCarimbo;
        private DataGridViewTextBoxColumn EMPRESA;
        private DataGridViewTextBoxColumn NOME;
        private DataGridViewTextBoxColumn CNPJ;
        private DataGridViewTextBoxColumn CIDADE;
        private DataGridViewTextBoxColumn UF;
        private Controls.RtfEditor rtfEditor;
        private TextBox txtCnpjLimpo;
        private Label label10;
    }
}