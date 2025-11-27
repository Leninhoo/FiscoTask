namespace FiscoTask.Controls
{
    partial class RtfEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RtfEditor));
            rtb = new RichTextBox();
            fontDialog1 = new FontDialog();
            toolStrip1 = new ToolStrip();
            btnNegrito = new ToolStripButton();
            btnSublinhado = new ToolStripButton();
            btnItalico = new ToolStripButton();
            btnTachado = new ToolStripButton();
            btnCor = new ToolStripButton();
            cbFonte = new ToolStripComboBox();
            toolStripSeparator1 = new ToolStripSeparator();
            btnAlinharEsquerda = new ToolStripButton();
            btnAlinharCentro = new ToolStripButton();
            btnAlinharDireita = new ToolStripButton();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            numTamanho = new NumericUpDown();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTamanho).BeginInit();
            SuspendLayout();
            // 
            // rtb
            // 
            rtb.AcceptsTab = true;
            rtb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtb.AutoWordSelection = true;
            rtb.BackColor = SystemColors.Window;
            rtb.EnableAutoDragDrop = true;
            rtb.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtb.HideSelection = false;
            rtb.Location = new Point(3, 61);
            rtb.Name = "rtb";
            rtb.ShowSelectionMargin = true;
            rtb.Size = new Size(556, 346);
            rtb.TabIndex = 0;
            rtb.Text = "";
            rtb.SelectionChanged += rtb_SelectionChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNegrito, btnSublinhado, btnItalico, btnTachado, btnCor, cbFonte, toolStripSeparator1, btnAlinharEsquerda, btnAlinharCentro, btnAlinharDireita });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(569, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNegrito
            // 
            btnNegrito.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnNegrito.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNegrito.Image = (Image)resources.GetObject("btnNegrito.Image");
            btnNegrito.ImageTransparentColor = Color.Magenta;
            btnNegrito.Name = "btnNegrito";
            btnNegrito.Size = new Size(23, 22);
            btnNegrito.Text = "N";
            btnNegrito.Click += btnNegrito_Click;
            // 
            // btnSublinhado
            // 
            btnSublinhado.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSublinhado.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSublinhado.Image = (Image)resources.GetObject("btnSublinhado.Image");
            btnSublinhado.ImageTransparentColor = Color.Magenta;
            btnSublinhado.Name = "btnSublinhado";
            btnSublinhado.Size = new Size(23, 22);
            btnSublinhado.Text = "S";
            btnSublinhado.Click += btnSublinhado_Click;
            // 
            // btnItalico
            // 
            btnItalico.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnItalico.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnItalico.Image = (Image)resources.GetObject("btnItalico.Image");
            btnItalico.ImageTransparentColor = Color.Magenta;
            btnItalico.Name = "btnItalico";
            btnItalico.Size = new Size(23, 22);
            btnItalico.Text = "I";
            btnItalico.Click += btnItalico_Click;
            // 
            // btnTachado
            // 
            btnTachado.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnTachado.Font = new Font("Segoe UI", 9F, FontStyle.Strikeout, GraphicsUnit.Point, 0);
            btnTachado.Image = (Image)resources.GetObject("btnTachado.Image");
            btnTachado.ImageTransparentColor = Color.Magenta;
            btnTachado.Name = "btnTachado";
            btnTachado.Size = new Size(23, 22);
            btnTachado.Text = "T";
            btnTachado.Click += btnTachado_Click;
            // 
            // btnCor
            // 
            btnCor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCor.ForeColor = Color.Red;
            btnCor.Image = (Image)resources.GetObject("btnCor.Image");
            btnCor.ImageTransparentColor = Color.Magenta;
            btnCor.Name = "btnCor";
            btnCor.Size = new Size(23, 22);
            btnCor.Text = "A";
            btnCor.Click += btnCor_Click;
            // 
            // cbFonte
            // 
            cbFonte.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFonte.Name = "cbFonte";
            cbFonte.Size = new Size(121, 25);
            cbFonte.SelectedIndexChanged += cbFonte_SelectedIndexChanged;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnAlinharEsquerda
            // 
            btnAlinharEsquerda.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAlinharEsquerda.Image = (Image)resources.GetObject("btnAlinharEsquerda.Image");
            btnAlinharEsquerda.ImageTransparentColor = Color.Magenta;
            btnAlinharEsquerda.Name = "btnAlinharEsquerda";
            btnAlinharEsquerda.Size = new Size(59, 22);
            btnAlinharEsquerda.Text = "Esquerda";
            btnAlinharEsquerda.Click += btnAlinharEsquerda_Click;
            // 
            // btnAlinharCentro
            // 
            btnAlinharCentro.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAlinharCentro.Image = (Image)resources.GetObject("btnAlinharCentro.Image");
            btnAlinharCentro.ImageTransparentColor = Color.Magenta;
            btnAlinharCentro.Name = "btnAlinharCentro";
            btnAlinharCentro.Size = new Size(47, 22);
            btnAlinharCentro.Text = "Centro";
            btnAlinharCentro.Click += btnAlinharCentro_Click;
            // 
            // btnAlinharDireita
            // 
            btnAlinharDireita.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAlinharDireita.Image = (Image)resources.GetObject("btnAlinharDireita.Image");
            btnAlinharDireita.ImageTransparentColor = Color.Magenta;
            btnAlinharDireita.Name = "btnAlinharDireita";
            btnAlinharDireita.Size = new Size(45, 22);
            btnAlinharDireita.Text = "Direita";
            btnAlinharDireita.Click += btnAlinharDireita_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // numTamanho
            // 
            numTamanho.Location = new Point(3, 28);
            numTamanho.Maximum = new decimal(new int[] { 72, 0, 0, 0 });
            numTamanho.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            numTamanho.Name = "numTamanho";
            numTamanho.Size = new Size(63, 23);
            numTamanho.TabIndex = 2;
            numTamanho.Value = new decimal(new int[] { 12, 0, 0, 0 });
            numTamanho.ValueChanged += numTamanho_ValueChanged;
            // 
            // RtfEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numTamanho);
            Controls.Add(toolStrip1);
            Controls.Add(rtb);
            Name = "RtfEditor";
            Size = new Size(569, 417);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTamanho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontDialog fontDialog1;
        private ToolStrip toolStrip1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripButton btnNegrito;
        private ToolStripButton btnSublinhado;
        private ToolStripButton btnItalico;
        private ToolStripButton btnTachado;
        private ToolStripButton btnCor;
        private ToolStripComboBox cbFonte;
        private NumericUpDown numTamanho;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnAlinharEsquerda;
        private ToolStripButton btnAlinharCentro;
        private ToolStripButton btnAlinharDireita;
        public RichTextBox rtb;
    }
}
