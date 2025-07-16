namespace FiscoTask
{
    partial class RegistroDocumentoControl
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
            txtVencimento = new MaskedTextBox();
            btnInsert = new Button();
            rtbObs = new RichTextBox();
            cbTipoDoc = new ComboBox();
            label17 = new Label();
            label16 = new Label();
            label6 = new Label();
            txtLivro = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtVencimento
            // 
            txtVencimento.Location = new Point(86, 72);
            txtVencimento.Mask = "00/00/0000";
            txtVencimento.Name = "txtVencimento";
            txtVencimento.Size = new Size(72, 23);
            txtVencimento.TabIndex = 48;
            txtVencimento.ValidatingType = typeof(DateTime);
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(368, 17);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 47;
            btnInsert.Text = "Inserir";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // rtbObs
            // 
            rtbObs.Location = new Point(49, 104);
            rtbObs.Name = "rtbObs";
            rtbObs.Size = new Size(289, 168);
            rtbObs.TabIndex = 46;
            rtbObs.Text = "";
            // 
            // cbTipoDoc
            // 
            cbTipoDoc.FormattingEnabled = true;
            cbTipoDoc.Location = new Point(128, 43);
            cbTipoDoc.Name = "cbTipoDoc";
            cbTipoDoc.Size = new Size(210, 23);
            cbTipoDoc.TabIndex = 45;
            cbTipoDoc.Click += cbTipoDoc_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(10, 46);
            label17.Name = "label17";
            label17.Size = new Size(113, 15);
            label17.TabIndex = 44;
            label17.Text = "Tipo de Documento";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(10, 76);
            label16.Name = "label16";
            label16.Size = new Size(70, 15);
            label16.TabIndex = 43;
            label16.Text = "Vencimento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 104);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 42;
            label6.Text = "Obs";
            // 
            // txtLivro
            // 
            txtLivro.Location = new Point(49, 14);
            txtLivro.Name = "txtLivro";
            txtLivro.ReadOnly = true;
            txtLivro.Size = new Size(109, 23);
            txtLivro.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 17);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 40;
            label2.Text = "Livro";
            // 
            // RegistroDocumentoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtVencimento);
            Controls.Add(btnInsert);
            Controls.Add(rtbObs);
            Controls.Add(cbTipoDoc);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label6);
            Controls.Add(txtLivro);
            Controls.Add(label2);
            Name = "RegistroDocumentoControl";
            Size = new Size(458, 298);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtVencimento;
        private Button btnInsert;
        private RichTextBox rtbObs;
        private ComboBox cbTipoDoc;
        private Label label17;
        private Label label16;
        private Label label6;
        private TextBox txtLivro;
        private Label label2;
    }
}
