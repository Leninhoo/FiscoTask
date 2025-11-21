using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FiscoTask.Controls
{
    public partial class RtfEditor : UserControl
    {
        public RtfEditor()
        {
            InitializeComponent();
            ConfiguracaoInicial();
        }

        #region Configurações iniciais
        private void ConfiguracaoInicial()
        {
            rtb = new RichTextBox();
            rtb.Dock = DockStyle.Fill;

            ConfigurarToolStrip();
        }

        private void ConfigurarToolStrip()
        {
            //Fonte
            foreach (FontFamily f in FontFamily.Families) cbFonte.Items.Add(f.Name);

        }
        #endregion

        #region Funções de formatação
        private void AlternarEstilo(FontStyle estilo)
        {
            Font f = rtb.SelectionFont ?? rtb.Font;
            bool tem = (f.Style & estilo) == estilo;
            rtb.SelectionFont = new Font(f, tem ? f.Style & ~estilo : f.Style | estilo);
        }

        private void AlternarNegrito() => AlternarEstilo(FontStyle.Bold);
        private void AlternarItalico() => AlternarEstilo(FontStyle.Italic);
        private void AlternarSublinhado() => AlternarEstilo(FontStyle.Underline);
        private void AlternarTachado() => AlternarEstilo(FontStyle.Strikeout);

        private void AplicarFonte()
        {
            if (cbFonte.SelectedItem == null) return;
            Font f = rtb.SelectionFont ?? rtb.Font;
            rtb.SelectionFont = new Font(cbFonte.SelectedItem.ToString(), f.Size, f.Style);
        }

        #endregion





        private void cbFonte_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFonte();
        }
    }
}

        
