namespace FiscoTask
{
    partial class RegAtosEmpresariaisForm
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
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            rtbObs = new RichTextBox();
            cbResponsavel = new ComboBox();
            dbAtosEmpresariaisBindingSource = new BindingSource(components);
            cbEscitorio = new ComboBox();
            cbTipo = new ComboBox();
            txtData = new MaskedTextBox();
            label11 = new Label();
            txtProtocolo = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtLivro = new TextBox();
            label7 = new Label();
            txtCNPJ = new TextBox();
            label6 = new Label();
            txtRazao = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dbAtosEmpresariaisBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(601, 437);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 53;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(601, 408);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 52;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(601, 379);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 51;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // rtbObs
            // 
            rtbObs.Location = new Point(17, 379);
            rtbObs.Name = "rtbObs";
            rtbObs.Size = new Size(578, 273);
            rtbObs.TabIndex = 41;
            rtbObs.Text = "";
            // 
            // cbResponsavel
            // 
            cbResponsavel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbResponsavel.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbResponsavel.DataSource = dbAtosEmpresariaisBindingSource;
            cbResponsavel.DisplayMember = "RESPONSAVEL_INTERNO";
            cbResponsavel.FormattingEnabled = true;
            cbResponsavel.Location = new Point(148, 275);
            cbResponsavel.Name = "cbResponsavel";
            cbResponsavel.Size = new Size(227, 23);
            cbResponsavel.TabIndex = 38;
            cbResponsavel.ValueMember = "RESPONSAVEL_INTERNO";
            cbResponsavel.Enter += cbResponsavel_Enter;
            // 
            // dbAtosEmpresariaisBindingSource
            // 
            dbAtosEmpresariaisBindingSource.DataSource = typeof(dbAtosEmpresariais);
            // 
            // cbEscitorio
            // 
            cbEscitorio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbEscitorio.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbEscitorio.DataSource = dbAtosEmpresariaisBindingSource;
            cbEscitorio.DisplayMember = "ESCRITORIO";
            cbEscitorio.FormattingEnabled = true;
            cbEscitorio.Location = new Point(148, 246);
            cbEscitorio.Name = "cbEscitorio";
            cbEscitorio.Size = new Size(226, 23);
            cbEscitorio.TabIndex = 37;
            cbEscitorio.ValueMember = "ESCRITORIO";
            cbEscitorio.Enter += cbEscitorio_Enter;
            // 
            // cbTipo
            // 
            cbTipo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTipo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbTipo.DataSource = dbAtosEmpresariaisBindingSource;
            cbTipo.DisplayMember = "TIPO";
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(57, 130);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(317, 23);
            cbTipo.TabIndex = 32;
            cbTipo.ValueMember = "TIPO";
            cbTipo.Enter += cbTipo_Enter;
            // 
            // txtData
            // 
            txtData.Location = new Point(57, 101);
            txtData.Mask = "00/00/0000";
            txtData.Name = "txtData";
            txtData.Size = new Size(73, 23);
            txtData.TabIndex = 31;
            txtData.ValidatingType = typeof(DateTime);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 361);
            label11.Name = "label11";
            label11.Size = new Size(74, 15);
            label11.TabIndex = 50;
            label11.Text = "Observações";
            // 
            // txtProtocolo
            // 
            txtProtocolo.Location = new Point(148, 304);
            txtProtocolo.Name = "txtProtocolo";
            txtProtocolo.Size = new Size(227, 23);
            txtProtocolo.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 304);
            label10.Name = "label10";
            label10.Size = new Size(107, 15);
            label10.TabIndex = 49;
            label10.Text = "Prot. Empresa Fácil";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 275);
            label9.Name = "label9";
            label9.Size = new Size(113, 15);
            label9.TabIndex = 48;
            label9.Text = "Responsável Interno";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 246);
            label8.Name = "label8";
            label8.Size = new Size(124, 15);
            label8.TabIndex = 47;
            label8.Text = "Escritório Responsável";
            // 
            // txtLivro
            // 
            txtLivro.Location = new Point(56, 217);
            txtLivro.Name = "txtLivro";
            txtLivro.Size = new Size(318, 23);
            txtLivro.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 217);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 46;
            label7.Text = "Livro";
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(57, 188);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(318, 23);
            txtCNPJ.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 188);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 45;
            label6.Text = "CNPJ";
            // 
            // txtRazao
            // 
            txtRazao.Location = new Point(95, 159);
            txtRazao.Name = "txtRazao";
            txtRazao.Size = new Size(371, 23);
            txtRazao.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 159);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 44;
            label5.Text = "Razão Social";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 130);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 43;
            label4.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 101);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 42;
            label3.Text = "Data";
            // 
            // txtID
            // 
            txtID.Location = new Point(57, 72);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(67, 23);
            txtID.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 72);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 39;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(275, 30);
            label1.TabIndex = 36;
            label1.Text = "Registrar atos empresariais";
            // 
            // RegAtosEmpresariaisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 661);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(rtbObs);
            Controls.Add(cbResponsavel);
            Controls.Add(cbEscitorio);
            Controls.Add(cbTipo);
            Controls.Add(txtData);
            Controls.Add(label11);
            Controls.Add(txtProtocolo);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtLivro);
            Controls.Add(label7);
            Controls.Add(txtCNPJ);
            Controls.Add(label6);
            Controls.Add(txtRazao);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegAtosEmpresariaisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar novo Ato Empresarial";
            Load += RegAtosEmpresariaisForm_Load;
            ((System.ComponentModel.ISupportInitialize)dbAtosEmpresariaisBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnSalvar;
        private RichTextBox rtbObs;
        private ComboBox cbResponsavel;
        private ComboBox cbEscitorio;
        private ComboBox cbTipo;
        private MaskedTextBox txtData;
        private Label label11;
        private TextBox txtProtocolo;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtLivro;
        private Label label7;
        private TextBox txtCNPJ;
        private Label label6;
        private TextBox txtRazao;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtID;
        private Label label2;
        private Label label1;
        private BindingSource dbAtosEmpresariaisBindingSource;
    }
}