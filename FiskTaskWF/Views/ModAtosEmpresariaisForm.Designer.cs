namespace FiscoTask
{
    partial class ModAtosEmpresariaisForm
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
            label3 = new Label();
            label4 = new Label();
            txtRazao = new TextBox();
            label5 = new Label();
            txtCNPJ = new TextBox();
            label6 = new Label();
            txtLivro = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtData = new MaskedTextBox();
            dbAtosEmpresariaisBindingSource = new BindingSource(components);
            txtProtocolo = new TextBox();
            rtbObs = new RichTextBox();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            txtTipo = new TextBox();
            txtResponsavel = new TextBox();
            txtResponsavelnterno = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dbAtosEmpresariaisBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(283, 30);
            label1.TabIndex = 7;
            label1.Text = "Modificar atos empresariais";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 72);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 8;
            label2.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(57, 72);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(67, 23);
            txtID.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 101);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 10;
            label3.Text = "Data";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 130);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 12;
            label4.Text = "Tipo";
            // 
            // txtRazao
            // 
            txtRazao.Location = new Point(95, 159);
            txtRazao.Name = "txtRazao";
            txtRazao.Size = new Size(371, 23);
            txtRazao.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 159);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 14;
            label5.Text = "Razão Social";
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(57, 188);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(318, 23);
            txtCNPJ.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 188);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 16;
            label6.Text = "CNPJ";
            // 
            // txtLivro
            // 
            txtLivro.Location = new Point(56, 217);
            txtLivro.Name = "txtLivro";
            txtLivro.Size = new Size(318, 23);
            txtLivro.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 217);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 18;
            label7.Text = "Livro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 246);
            label8.Name = "label8";
            label8.Size = new Size(124, 15);
            label8.TabIndex = 20;
            label8.Text = "Escritório Responsável";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 275);
            label9.Name = "label9";
            label9.Size = new Size(113, 15);
            label9.TabIndex = 22;
            label9.Text = "Responsável Interno";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 304);
            label10.Name = "label10";
            label10.Size = new Size(107, 15);
            label10.TabIndex = 24;
            label10.Text = "Prot. Empresa Fácil";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 361);
            label11.Name = "label11";
            label11.Size = new Size(74, 15);
            label11.TabIndex = 26;
            label11.Text = "Observações";
            // 
            // txtData
            // 
            txtData.Location = new Point(57, 101);
            txtData.Mask = "00/00/0000";
            txtData.Name = "txtData";
            txtData.Size = new Size(73, 23);
            txtData.TabIndex = 2;
            txtData.ValidatingType = typeof(DateTime);
            // 
            // dbAtosEmpresariaisBindingSource
            // 
            dbAtosEmpresariaisBindingSource.DataSource = typeof(dbAtosEmpresariais);
            // 
            // txtProtocolo
            // 
            txtProtocolo.Location = new Point(148, 304);
            txtProtocolo.Name = "txtProtocolo";
            txtProtocolo.Size = new Size(227, 23);
            txtProtocolo.TabIndex = 9;
            // 
            // rtbObs
            // 
            rtbObs.Location = new Point(17, 379);
            rtbObs.Name = "rtbObs";
            rtbObs.Size = new Size(578, 273);
            rtbObs.TabIndex = 10;
            rtbObs.Text = "";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(601, 379);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 27;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(601, 408);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 28;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(601, 437);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(57, 130);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(209, 23);
            txtTipo.TabIndex = 30;
            // 
            // txtResponsavel
            // 
            txtResponsavel.Location = new Point(148, 246);
            txtResponsavel.Name = "txtResponsavel";
            txtResponsavel.Size = new Size(209, 23);
            txtResponsavel.TabIndex = 31;
            // 
            // txtResponsavelnterno
            // 
            txtResponsavelnterno.Location = new Point(148, 275);
            txtResponsavelnterno.Name = "txtResponsavelnterno";
            txtResponsavelnterno.Size = new Size(209, 23);
            txtResponsavelnterno.TabIndex = 32;
            // 
            // ModAtosEmpresariaisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 664);
            Controls.Add(txtResponsavelnterno);
            Controls.Add(txtResponsavel);
            Controls.Add(txtTipo);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(rtbObs);
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
            Name = "ModAtosEmpresariaisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Atos Empresariais";
            Load += ModAtosEmpresariaisForm_Load;
            ((System.ComponentModel.ISupportInitialize)dbAtosEmpresariaisBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtID;
        private TextBox txtResponsavel;
        private Label label3;
        private TextBox txtResponsavelnterno;
        private Label label4;
        private TextBox txtRazao;
        private Label label5;
        private TextBox txtCNPJ;
        private Label label6;
        private TextBox txtLivro;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox10;
        private Label label11;
        private MaskedTextBox txtData;
        private BindingSource dbAtosEmpresariaisBindingSource;
        private TextBox txtProtocolo;
        private RichTextBox rtbObs;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnCancelar;
        private TextBox txtTipo;
    }
}