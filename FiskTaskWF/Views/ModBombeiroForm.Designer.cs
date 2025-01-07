namespace FiscoTask
{
    partial class ModBombeiroForm
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
            btnCancelar = new Button();
            btnSalvar = new Button();
            rtbObs = new RichTextBox();
            label5 = new Label();
            txtProcesso = new TextBox();
            label4 = new Label();
            txtLivro = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtDataRegistro = new TextBox();
            label9 = new Label();
            txtCIDADE = new TextBox();
            label8 = new Label();
            txtCNPJ = new TextBox();
            label7 = new Label();
            txtNOME = new TextBox();
            label6 = new Label();
            txtID = new TextBox();
            label3 = new Label();
            btnApagar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(310, 30);
            label1.TabIndex = 6;
            label1.Text = "Anotações Processo Bombeiro";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(554, 362);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 57;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(554, 304);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 56;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // rtbObs
            // 
            rtbObs.Location = new Point(88, 305);
            rtbObs.Name = "rtbObs";
            rtbObs.Size = new Size(455, 133);
            rtbObs.TabIndex = 55;
            rtbObs.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 279);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 54;
            label5.Text = "Observações";
            // 
            // txtProcesso
            // 
            txtProcesso.Location = new Point(100, 80);
            txtProcesso.Name = "txtProcesso";
            txtProcesso.ReadOnly = true;
            txtProcesso.Size = new Size(231, 23);
            txtProcesso.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 83);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 52;
            label4.Text = "Processo n°";
            // 
            // txtLivro
            // 
            txtLivro.Location = new Point(100, 51);
            txtLivro.Name = "txtLivro";
            txtLivro.ReadOnly = true;
            txtLivro.Size = new Size(83, 23);
            txtLivro.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 54);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 50;
            label2.Text = "Livro";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDataRegistro);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtCIDADE);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtCNPJ);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtNOME);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtLivro);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtProcesso);
            groupBox1.Location = new Point(432, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 226);
            groupBox1.TabIndex = 58;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Processo";
            // 
            // txtDataRegistro
            // 
            txtDataRegistro.Location = new Point(100, 196);
            txtDataRegistro.Name = "txtDataRegistro";
            txtDataRegistro.ReadOnly = true;
            txtDataRegistro.Size = new Size(231, 23);
            txtDataRegistro.TabIndex = 63;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 199);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 62;
            label9.Text = "Data Registro";
            // 
            // txtCIDADE
            // 
            txtCIDADE.Location = new Point(100, 167);
            txtCIDADE.Name = "txtCIDADE";
            txtCIDADE.ReadOnly = true;
            txtCIDADE.Size = new Size(231, 23);
            txtCIDADE.TabIndex = 61;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 170);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 60;
            label8.Text = "Cidade";
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(100, 138);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.ReadOnly = true;
            txtCNPJ.Size = new Size(231, 23);
            txtCNPJ.TabIndex = 59;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 141);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 58;
            label7.Text = "CNPJ";
            // 
            // txtNOME
            // 
            txtNOME.Location = new Point(100, 109);
            txtNOME.Name = "txtNOME";
            txtNOME.ReadOnly = true;
            txtNOME.Size = new Size(231, 23);
            txtNOME.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 112);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 56;
            label6.Text = "Empresa";
            // 
            // txtID
            // 
            txtID.Location = new Point(100, 22);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(83, 23);
            txtID.TabIndex = 55;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 25);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 54;
            label3.Text = "Id ";
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(554, 333);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(75, 23);
            btnApagar.TabIndex = 59;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // ModBombeiroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnApagar);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(rtbObs);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "ModBombeiroForm";
            Text = "Anotações Processo Bombeiro";
            Load += ModBombeiroForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancelar;
        private Button btnSalvar;
        private RichTextBox rtbObs;
        private Label label5;
        private TextBox txtProcesso;
        private Label label4;
        private TextBox txtLivro;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtID;
        private Label label3;
        private TextBox txtDataRegistro;
        private Label label9;
        private TextBox txtCIDADE;
        private Label label8;
        private TextBox txtCNPJ;
        private Label label7;
        private TextBox txtNOME;
        private Label label6;
        private Button btnApagar;
    }
}