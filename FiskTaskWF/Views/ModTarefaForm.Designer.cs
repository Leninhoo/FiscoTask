namespace FiscoTask
{
    partial class ModTarefaForm
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
            label1 = new Label();
            rtbObs = new RichTextBox();
            label5 = new Label();
            cbSituacao = new ComboBox();
            label4 = new Label();
            cbTipo = new ComboBox();
            label3 = new Label();
            txtLivro = new TextBox();
            label2 = new Label();
            txtCNPJ = new TextBox();
            label6 = new Label();
            txtEmpresa = new TextBox();
            label7 = new Label();
            txtId = new TextBox();
            label8 = new Label();
            txtCidade = new TextBox();
            label9 = new Label();
            groupBox1 = new GroupBox();
            txtDataRegistro = new TextBox();
            label10 = new Label();
            btnSalvar = new Button();
            btnApagar = new Button();
            btnCancelar = new Button();
            cbBombeiro = new CheckBox();
            cbVigilanciaSanitaria = new CheckBox();
            cbTaxaAlvaraPgto = new CheckBox();
            groupBox2 = new GroupBox();
            cbEntregaTaxaAlvara = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 30);
            label1.TabIndex = 4;
            label1.Text = "Atualizar Status de Tarefas";
            // 
            // rtbObs
            // 
            rtbObs.Location = new Point(12, 221);
            rtbObs.Name = "rtbObs";
            rtbObs.Size = new Size(1081, 358);
            rtbObs.TabIndex = 1;
            rtbObs.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 194);
            label5.Name = "label5";
            label5.Size = new Size(135, 15);
            label5.TabIndex = 22;
            label5.Text = "Histórico e Comentários";
            // 
            // cbSituacao
            // 
            cbSituacao.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSituacao.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSituacao.FormattingEnabled = true;
            cbSituacao.ItemHeight = 15;
            cbSituacao.Items.AddRange(new object[] { "Em andamento", "Encerrado" });
            cbSituacao.Location = new Point(69, 133);
            cbSituacao.Name = "cbSituacao";
            cbSituacao.Size = new Size(248, 23);
            cbSituacao.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 136);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 21;
            label4.Text = "Situação";
            // 
            // cbTipo
            // 
            cbTipo.AllowDrop = true;
            cbTipo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTipo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbTipo.Enabled = false;
            cbTipo.FormattingEnabled = true;
            cbTipo.ItemHeight = 15;
            cbTipo.Items.AddRange(new object[] { "Alvará", "Bombeiro", "Vigilância Sanitária", "Consulta Jurídica", "Documentos gerais", "Outro", "Segunda via alvará", "Licença de transporte", "Alteração Ata/Documento", "Débitos", "Atualizar Alvará" });
            cbTipo.Location = new Point(69, 104);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(248, 23);
            cbTipo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 107);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 20;
            label3.Text = "Tipo";
            // 
            // txtLivro
            // 
            txtLivro.Location = new Point(69, 75);
            txtLivro.Name = "txtLivro";
            txtLivro.ReadOnly = true;
            txtLivro.Size = new Size(94, 23);
            txtLivro.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 78);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 19;
            label2.Text = "Livro";
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(60, 89);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.ReadOnly = true;
            txtCNPJ.Size = new Size(283, 23);
            txtCNPJ.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 92);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 24;
            label6.Text = "CNPJ";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(60, 60);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.ReadOnly = true;
            txtEmpresa.Size = new Size(283, 23);
            txtEmpresa.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 63);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 26;
            label7.Text = "Empresa";
            // 
            // txtId
            // 
            txtId.Location = new Point(60, 31);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(94, 23);
            txtId.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 34);
            label8.Name = "label8";
            label8.Size = new Size(17, 15);
            label8.TabIndex = 28;
            label8.Text = "Id";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(60, 118);
            txtCidade.Name = "txtCidade";
            txtCidade.ReadOnly = true;
            txtCidade.Size = new Size(283, 23);
            txtCidade.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 121);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 30;
            label9.Text = "Cidade";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDataRegistro);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtCNPJ);
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(txtEmpresa);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(744, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 172);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações Registro";
            // 
            // txtDataRegistro
            // 
            txtDataRegistro.Location = new Point(60, 147);
            txtDataRegistro.Name = "txtDataRegistro";
            txtDataRegistro.ReadOnly = true;
            txtDataRegistro.Size = new Size(283, 23);
            txtDataRegistro.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 150);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 32;
            label10.Text = "Registro";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 614);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(93, 614);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(75, 23);
            btnApagar.TabIndex = 3;
            btnApagar.Text = "Excluir";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(174, 614);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbBombeiro
            // 
            cbBombeiro.AutoSize = true;
            cbBombeiro.Location = new Point(6, 22);
            cbBombeiro.Name = "cbBombeiro";
            cbBombeiro.Size = new Size(78, 19);
            cbBombeiro.TabIndex = 32;
            cbBombeiro.Text = "Bombeiro";
            cbBombeiro.UseVisualStyleBackColor = true;
            // 
            // cbVigilanciaSanitaria
            // 
            cbVigilanciaSanitaria.AutoSize = true;
            cbVigilanciaSanitaria.Location = new Point(6, 47);
            cbVigilanciaSanitaria.Name = "cbVigilanciaSanitaria";
            cbVigilanciaSanitaria.Size = new Size(125, 19);
            cbVigilanciaSanitaria.TabIndex = 33;
            cbVigilanciaSanitaria.Text = "Vigilância Sanitária";
            cbVigilanciaSanitaria.UseVisualStyleBackColor = true;
            // 
            // cbTaxaAlvaraPgto
            // 
            cbTaxaAlvaraPgto.AutoSize = true;
            cbTaxaAlvaraPgto.Location = new Point(6, 72);
            cbTaxaAlvaraPgto.Name = "cbTaxaAlvaraPgto";
            cbTaxaAlvaraPgto.Size = new Size(130, 19);
            cbTaxaAlvaraPgto.TabIndex = 34;
            cbTaxaAlvaraPgto.Text = "Taxa de Alvará Paga";
            cbTaxaAlvaraPgto.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbEntregaTaxaAlvara);
            groupBox2.Controls.Add(cbBombeiro);
            groupBox2.Controls.Add(cbTaxaAlvaraPgto);
            groupBox2.Controls.Add(cbVigilanciaSanitaria);
            groupBox2.Location = new Point(514, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 125);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Situação Documentos";
            // 
            // cbEntregaTaxaAlvara
            // 
            cbEntregaTaxaAlvara.AutoSize = true;
            cbEntregaTaxaAlvara.Location = new Point(6, 97);
            cbEntregaTaxaAlvara.Name = "cbEntregaTaxaAlvara";
            cbEntregaTaxaAlvara.Size = new Size(151, 19);
            cbEntregaTaxaAlvara.TabIndex = 35;
            cbEntregaTaxaAlvara.Text = "Taxa de Alvará Entregue";
            cbEntregaTaxaAlvara.UseVisualStyleBackColor = true;
            // 
            // ModTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 649);
            Controls.Add(groupBox2);
            Controls.Add(btnCancelar);
            Controls.Add(btnApagar);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox1);
            Controls.Add(rtbObs);
            Controls.Add(label5);
            Controls.Add(cbSituacao);
            Controls.Add(label4);
            Controls.Add(cbTipo);
            Controls.Add(label3);
            Controls.Add(txtLivro);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModTarefaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alterar Tarefa";
            Load += ModTarefaForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox rtbObs;
        private Label label5;
        private ComboBox cbSituacao;
        private Label label4;
        private ComboBox cbTipo;
        private Label label3;
        private TextBox txtLivro;
        private Label label2;
        private TextBox txtCNPJ;
        private Label label6;
        private TextBox txtEmpresa;
        private Label label7;
        private TextBox txtId;
        private Label label8;
        private TextBox txtCidade;
        private Label label9;
        private GroupBox groupBox1;
        private TextBox txtDataRegistro;
        private Label label10;
        private Button btnSalvar;
        private Button btnApagar;
        private Button btnCancelar;
        private CheckBox cbBombeiro;
        private CheckBox cbVigilanciaSanitaria;
        private CheckBox cbTaxaAlvaraPgto;
        private GroupBox groupBox2;
        private CheckBox cbEntregaTaxaAlvara;
    }
}