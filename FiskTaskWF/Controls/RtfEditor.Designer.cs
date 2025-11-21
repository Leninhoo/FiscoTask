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
            colorDialog1 = new ColorDialog();
            toolStrip1 = new ToolStrip();
            btnNegrito = new ToolStripButton();
            btnSublinhado = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            cbFonte = new ToolStripComboBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // rtb
            // 
            rtb.BackColor = SystemColors.Window;
            rtb.Location = new Point(3, 94);
            rtb.Name = "rtb";
            rtb.Size = new Size(711, 363);
            rtb.TabIndex = 0;
            rtb.Text = "";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNegrito, btnSublinhado, toolStripButton3, toolStripButton4, toolStripButton5, cbFonte });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(719, 25);
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
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "I";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.Font = new Font("Segoe UI", 9F, FontStyle.Strikeout, GraphicsUnit.Point, 0);
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 22);
            toolStripButton4.Text = "T";
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(23, 22);
            toolStripButton5.Text = "toolStripButton5";
            // 
            // cbFonte
            // 
            cbFonte.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFonte.Name = "cbFonte";
            cbFonte.Size = new Size(121, 25);
            cbFonte.SelectedIndexChanged += cbFonte_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // RtfEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toolStrip1);
            Controls.Add(rtb);
            Name = "RtfEditor";
            Size = new Size(719, 460);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private ToolStrip toolStrip1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripButton btnNegrito;
        private ToolStripButton btnSublinhado;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripComboBox cbFonte;
    }
}
