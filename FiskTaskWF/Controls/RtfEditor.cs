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
using System.Runtime.CompilerServices;

namespace FiscoTask.Controls
{
    public partial class RtfEditor : UserControl
    {
        public RtfEditor()
        {
            InitializeComponent();
            ConfiguracaoInicial();


        }

        //Conteúdo RTF com formatação preservada.
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ConteudoRTF
        {            
            get => rtb.Rtf;
            set
            {
                rtb.Rtf = value ?? string.Empty; // ?? evita null
                SincronizarBotoes(); // Atualiza botões após carregar
            }
        }

        //Conteúdo texto simples, sem formatação.
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ConteudoTexto
        {
            get => rtb.Text;
            set
            {
                rtb.Text = value ?? string.Empty; // ?? evita null
                SincronizarBotoes(); // Atualiza botões após carregar
            }
        }

        #region Configurações iniciais
        private void ConfiguracaoInicial()
        {
            // rtb.Dock = DockStyle.Fill;
            ConfigurarToolStrip();
        }

        private void ConfigurarToolStrip()
        {
            //Fonte
            foreach (FontFamily f in FontFamily.Families) cbFonte.Items.Add(f.Name);


        }
        #endregion


        private void SincronizarBotoes()
        {
            //Função para alterar o estado UI conforme o texto selecionado e sua formatação.
            Font fonteAtual = rtb.SelectionFont ?? rtb.Font;
            btnNegrito.Checked = (fonteAtual.Style & FontStyle.Bold) == FontStyle.Bold;
            btnItalico.Checked = (fonteAtual.Style & FontStyle.Italic) == FontStyle.Italic;
            btnSublinhado.Checked = (fonteAtual.Style & FontStyle.Underline) == FontStyle.Underline;
            btnTachado.Checked = (fonteAtual.Style & FontStyle.Strikeout) == FontStyle.Strikeout;
            cbFonte.SelectedItem = fonteAtual.FontFamily.Name;
            numTamanho.Value = (decimal)fonteAtual.Size;
        }


        #region Funções de formatação
        private void AlternarEstilo(FontStyle estilo)
        {
            Font fonteAtual = rtb.SelectionFont ?? rtb.Font; // Fonte da seleção ou padrão
            bool temEstilo = (fonteAtual.Style & estilo) == estilo; // Verifica bit
            FontStyle novoEstilo = temEstilo ? (fonteAtual.Style & ~estilo) : (fonteAtual.Style | estilo);
            rtb.SelectionFont = new Font(fonteAtual, novoEstilo); // Aplica!

            SincronizarBotoes(); // Atualiza botões
        }

        private void AlterarCor()
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    rtb.SelectionColor = cd.Color;
                }
            }
        }

        private void AlternarNegrito() => AlternarEstilo(FontStyle.Bold);
        private void AlternarItalico() => AlternarEstilo(FontStyle.Italic);
        private void AlternarSublinhado() => AlternarEstilo(FontStyle.Underline);
        private void AlternarTachado() => AlternarEstilo(FontStyle.Strikeout);

        private void AplicarFonte()
        {
            if (cbFonte.SelectedItem == null) return; // Evita erro

            Font fonteAtual = rtb.SelectionFont ?? rtb.Font;
            string nomeNovaFonte = cbFonte.SelectedItem.ToString();
            rtb.SelectionFont = new Font(nomeNovaFonte, fonteAtual.Size, fonteAtual.Style);

            SincronizarBotoes(); // Atualiza botões
        }

        private void AplicarTamanho()
        {
            if (numTamanho.Value == 0) return;
            Font fonteAtual = rtb.SelectionFont ?? rtb.Font;
            rtb.SelectionFont = new Font(fonteAtual.FontFamily, (float)numTamanho.Value, fonteAtual.Style);

            SincronizarBotoes(); // Atualiza botões
        }

        #endregion





        #region Eventos de formatação

        //Aqui concentro os eventos.

        private void cbFonte_SelectedIndexChanged(object sender, EventArgs e) => AplicarFonte();
        private void btnNegrito_Click(object sender, EventArgs e) => AlternarNegrito();
        private void btnSublinhado_Click(object sender, EventArgs e) => AlternarSublinhado();
        private void btnItalico_Click(object sender, EventArgs e) => AlternarItalico();
        private void btnTachado_Click(object sender, EventArgs e) => AlternarTachado();
        private void numTamanho_ValueChanged(object sender, EventArgs e) => AplicarTamanho();
        private void rtb_SelectionChanged(object sender, EventArgs e) => SincronizarBotoes();
        private void btnCor_Click(object sender, EventArgs e) => AlterarCor();
        private void btnAlinharEsquerda_Click(object sender, EventArgs e) => rtb.SelectionAlignment = HorizontalAlignment.Left;
        private void btnAlinharCentro_Click(object sender, EventArgs e) => rtb.SelectionAlignment = HorizontalAlignment.Center;
        private void btnAlinharDireita_Click(object sender, EventArgs e) => rtb.SelectionAlignment = HorizontalAlignment.Right;

        #endregion



    }
}

        
