namespace FiscoTask
{
    partial class RegistrarBombeiroControl
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
            btnCancelar = new Button();
            btnSalvar = new Button();
            rtbObs = new RichTextBox();
            label5 = new Label();
            txtProcesso = new TextBox();
            label4 = new Label();
            txtLivro = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(547, 131);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 57;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(547, 102);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 56;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // rtbObs
            // 
            rtbObs.Location = new Point(81, 103);
            rtbObs.Name = "rtbObs";
            rtbObs.Size = new Size(455, 133);
            rtbObs.TabIndex = 55;
            rtbObs.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 77);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 54;
            label5.Text = "Observações";
            // 
            // txtProcesso
            // 
            txtProcesso.Location = new Point(81, 34);
            txtProcesso.Name = "txtProcesso";
            txtProcesso.Size = new Size(317, 23);
            txtProcesso.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 37);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 52;
            label4.Text = "Processo n°";
            // 
            // txtLivro
            // 
            txtLivro.Location = new Point(81, 5);
            txtLivro.Name = "txtLivro";
            txtLivro.ReadOnly = true;
            txtLivro.Size = new Size(96, 23);
            txtLivro.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 8);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 50;
            label2.Text = "Livro";
            // 
            // RegistrarBombeiroControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(rtbObs);
            Controls.Add(label5);
            Controls.Add(txtProcesso);
            Controls.Add(label4);
            Controls.Add(txtLivro);
            Controls.Add(label2);
            Name = "RegistrarBombeiroControl";
            Size = new Size(633, 245);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnSalvar;
        private RichTextBox rtbObs;
        private Label label5;
        private TextBox txtProcesso;
        private Label label4;
        private TextBox txtLivro;
        private Label label2;
    }
}
