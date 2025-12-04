using FiscoTask.DataBase;
using FiscoTask.Models;
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
            CarregarComboBox();


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
                var ufEmpresa = dgPesquisaEmpresa.Rows[e.RowIndex].Cells["UF"].Value?.ToString();

                txtID.Text = livroId;
                txtRazao.Text = nomeEmpresa;
                txtCNPJ.Text = cnpjEmpresa;
                txtCnpjLimpo.Text = Helpers.FormatarCNPJs(cnpjEmpresa ?? "");
                txtCidade.Text = $"{cidadeEmpresa} - {ufEmpresa}";
            }
        }



        private void btnCarimbo_Click(object sender, EventArgs e)
        {
            try
            {

                // Define o texto do carimbo (pode ser personalizado)
                string carimbo = $"--------------------------- \n{DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss")} \n";
                rtfEditor.rtb.SelectedText = carimbo;
                rtfEditor.rtb.Focus();
                rtfEditor.rtb.SelectionStart = rtfEditor.rtb.Text.Length; //cursor para o final do texto.

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
            // Converte o conteúdo do RichEditControl para bytes (formato .docx)
            byte[] fileData;
            using (MemoryStream ms = new MemoryStream())
            {
                rtfEditor.rtb.SaveFile(ms, RichTextBoxStreamType.RichText);
                fileData = ms.ToArray();
            }
            var NewProcesso = new DbProcessos
            {
                Empresa = int.Parse(txtID.Text),
                Situacao = cbSituacao.Text,
                Andamento = cbAndamento.Text,
                Dtregistro = DateTime.Now,
                TipoProcesso = cbTipo.Text,
                Arquivo = fileData
            };

            dbProcessos.CreateProcesso(NewProcesso);
            MessageBox.Show("Processo registrado com sucesso!");

            LimparFormulario();

        }

        private void LimparFormulario()
        {
            txtPesquisa.Clear();
            txtID.Clear();
            txtRazao.Clear();
            txtCNPJ.Clear();
            txtCnpjLimpo.Clear();
            txtCidade.Clear();
            cbSituacao.SelectedItem = -1;
            cbSituacao.Text = "";
            cbTipo.SelectedItem = -1;
            cbTipo.Text = "";
            cbAndamento.SelectedItem = -1;
            cbAndamento.Text = "";
            rtfEditor.rtb.Clear();

            dbProcessos.CarregarComboBox("TipoProcesso", cbTipo);

            CarregarComboBox();

            txtPesquisa.Focus();
        }

        private void CarregarComboBox()
        {
            ListasComboBox listas = new ListasComboBox();
            cbAndamento.DataSource = listas.AndamentosProcesso();
            cbSituacao.DataSource = listas.Situacao();
        }
    }
}
