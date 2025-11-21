using FiscoTask.DataBase;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiscoTask.Views
{
    public partial class RegistroProcesso : Form
    {
        DbProcessos dbProcessos = new DbProcessos();
        EmpresaView empresaView = new EmpresaView();
        public RegistroProcesso()
        {
            InitializeComponent();
            LoadEmpresas();
            dbProcessos.CarregarComboBox("TipoProcesso", cbTipo);
            dbProcessos.CarregarComboBox("Situacao", cbSituacao);
            dbProcessos.CarregarComboBox("Andamento", cbAndamento);
        }

        public void LoadEmpresas()
        {
            var table = empresaView.ReadEmpresasDT();
            dgPesquisaEmpresa.DataSource = table;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtPesquisa.Text.Replace("'", "''"); // Evitar erros com apóstrofos
            var dataTable = (dgPesquisaEmpresa.DataSource as DataTable);

            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format(
                    "NOME LIKE '%{0}%' OR CNPJ LIKE '%{0}%' OR CIDADE LIKE '%{0}%'",
                    filtro
                );
            }
        }

        private void dgPesquisaEmpresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var livroId = dgPesquisaEmpresa.Rows[e.RowIndex].Cells["EMPRESA"].Value?.ToString();
                var nomeEmpresa = dgPesquisaEmpresa.Rows[e.RowIndex].Cells["NOME"].Value?.ToString();
                var cnpjEmpresa = dgPesquisaEmpresa.Rows[e.RowIndex].Cells["CNPJ"].Value?.ToString();
                var cidadeEmpresa = dgPesquisaEmpresa.Rows[e.RowIndex].Cells["CIDADE"].Value?.ToString();

                txtID.Text = livroId;
                txtRazao.Text = nomeEmpresa;
                txtCNPJ.Text = cnpjEmpresa;
                txtCidade.Text = cidadeEmpresa;
            }
        }



        private void btnCarimbo_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém o RichEditControl do UserControl
                var richEditControl = recArquivo.Rec;

                // Define o texto do carimbo (pode ser personalizado)
                string carimbo = $"--------------------------- \n{DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss")} \n";
                // Insere o texto na posição atual do cursor
                richEditControl.Document.InsertText(richEditControl.Document.CaretPosition, carimbo);
                richEditControl.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar carimbo: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var dbProcessos = new DbProcessos();
            // Converte o conteúdo do RichEditControl para bytes (formato .docx)
            byte[] fileData;
            using (MemoryStream ms = new MemoryStream())
            {
                recArquivo.Rec.SaveDocument(ms, DevExpress.XtraRichEdit.DocumentFormat.OpenXml);
                fileData = ms.ToArray();
            }
            var NewProcesso = new DbProcessos
            {
                Empresa = int.Parse(txtID.Text),
                Situacao = cbSituacao.Text,
                Andamento = cbAndamento.Text,
                Dtregistro = DateTime.Now.ToString("yyyy-MM-dd"),
                TipoProcesso = cbTipo.Text,
                Arquivo = fileData
            };

            dbProcessos.CreateProcesso(NewProcesso);
            MessageBox.Show("Processo registrado com sucesso!");
            this.Close();

        }
    }
}
