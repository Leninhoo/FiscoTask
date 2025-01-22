namespace FiscoTask
{
    partial class ModDocForm
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
            btnInsert = new Button();
            rtbObs = new RichTextBox();
            dtpVencimento = new DateTimePicker();
            label17 = new Label();
            label16 = new Label();
            label6 = new Label();
            txtLivro = new TextBox();
            label2 = new Label();
            txtEmpresa = new TextBox();
            label3 = new Label();
            txtCidade = new TextBox();
            label4 = new Label();
            txtId = new TextBox();
            label5 = new Label();
            btnDelete = new Button();
            button2 = new Button();
            txtTipo = new TextBox();
            txtCNPJ = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(346, 30);
            label1.TabIndex = 1;
            label1.Text = "Modificar Registro de Documento";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(12, 479);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 8;
            btnInsert.Text = "Salvar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // rtbObs
            // 
            rtbObs.Location = new Point(69, 210);
            rtbObs.Name = "rtbObs";
            rtbObs.Size = new Size(489, 219);
            rtbObs.TabIndex = 7;
            rtbObs.Text = "";
            // 
            // dtpVencimento
            // 
            dtpVencimento.Format = DateTimePickerFormat.Short;
            dtpVencimento.Location = new Point(104, 178);
            dtpVencimento.Name = "dtpVencimento";
            dtpVencimento.Size = new Size(227, 23);
            dtpVencimento.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(30, 152);
            label17.Name = "label17";
            label17.Size = new Size(112, 15);
            label17.TabIndex = 43;
            label17.Text = "Tipo de Documento";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(30, 182);
            label16.Name = "label16";
            label16.Size = new Size(70, 15);
            label16.TabIndex = 42;
            label16.Text = "Vencimento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 210);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 41;
            label6.Text = "Obs";
            // 
            // txtLivro
            // 
            txtLivro.Location = new Point(69, 84);
            txtLivro.Name = "txtLivro";
            txtLivro.ReadOnly = true;
            txtLivro.Size = new Size(73, 23);
            txtLivro.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 87);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 39;
            label2.Text = "Livro";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(206, 84);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.ReadOnly = true;
            txtEmpresa.Size = new Size(412, 23);
            txtEmpresa.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 87);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 48;
            label3.Text = "Empresa";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(78, 113);
            txtCidade.Name = "txtCidade";
            txtCidade.ReadOnly = true;
            txtCidade.Size = new Size(158, 23);
            txtCidade.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 116);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 50;
            label4.Text = "Cidade";
            // 
            // txtId
            // 
            txtId.Location = new Point(690, 9);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(73, 23);
            txtId.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(663, 12);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 52;
            label5.Text = "Id";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(93, 479);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Apagar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button2
            // 
            button2.Location = new Point(174, 479);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(148, 144);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(158, 23);
            txtTipo.TabIndex = 5;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(295, 113);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.ReadOnly = true;
            txtCNPJ.Size = new Size(158, 23);
            txtCNPJ.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(247, 116);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 57;
            label7.Text = "CNPJ";
            // 
            // ModDocForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 582);
            Controls.Add(txtCNPJ);
            Controls.Add(label7);
            Controls.Add(txtTipo);
            Controls.Add(button2);
            Controls.Add(btnDelete);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(txtCidade);
            Controls.Add(label4);
            Controls.Add(txtEmpresa);
            Controls.Add(label3);
            Controls.Add(btnInsert);
            Controls.Add(rtbObs);
            Controls.Add(dtpVencimento);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label6);
            Controls.Add(txtLivro);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModDocForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Registro de Documento";
            Load += ModDocForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnInsert;
        private RichTextBox rtbObs;
        private DateTimePicker dtpVencimento;
        private Label label17;
        private Label label16;
        private Label label6;
        private TextBox txtLivro;
        private Label label2;
        private TextBox txtEmpresa;
        private Label label3;
        private TextBox txtCidade;
        private Label label4;
        private TextBox txtId;
        private Label label5;
        private Button btnDelete;
        private Button button2;
        private TextBox txtTipo;
        private TextBox txtCNPJ;
        private Label label7;
    }
}