    using FiscoTask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace FiscoTask
{
    public partial class ConsultaDocsView : UserControl
    {

        DbDocuments dbdocuments = new DbDocuments();


        public ConsultaDocsView()
        {
            InitializeComponent();

            LoadDocuments("IdDoc", "DESC");
            LoadVencendo("Vencimentodoc", "ASC");

        }

        private void LoadDocuments(string coluna, string ordem)
        {

            var documentos = dbdocuments.ReadDocDT();
            documentos.DefaultView.Sort = $"{coluna} {ordem}";
            dgConsultaDocumentos.DataSource = documentos;
        }


        private void LoadVencendo(string coluna, string ordem)
        {
            var documentos = dbdocuments.ReadDocDT();

            // Converter DataTable para Enumerable (LINQ)
            var rows = documentos.AsEnumerable()
                .Where(row =>
                    row.Field<DateTime>("Vencimentodoc") >= DateTime.Now &&
                    row.Field<DateTime>("Vencimentodoc") <= DateTime.Now.AddDays(30))
                .OrderBy(row => row.Field<DateTime>(coluna)); // Ordena pela coluna especificada

            // Recriar DataTable com os dados filtrados
            DataTable documentosFiltrados = rows.Any() ? rows.CopyToDataTable() : documentos.Clone();

            // Atualizar o DataGrid
            dgVencendo.DataSource = documentosFiltrados;

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtPesquisa.Text.Replace("'", "''"); // Evitar erros com apóstrofos
            var dataTable = (dgConsultaDocumentos.DataSource as DataTable);

            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format(
                    "NOME LIKE '%{0}%' OR CNPJ LIKE '%{0}%' OR CIDADE LIKE '%{0}%'",
                    filtro
                );
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDocuments("IdDoc", "DESC");
            LoadVencendo("Vencimentodoc", "ASC");
        }

        private void dgConsultaDocumentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgConsultaDocumentos.Rows[e.RowIndex];

                // Extrai os dados da linha, com tratamento para valores nulos
                int idDoc = Convert.ToInt32(row.Cells["Id"].Value);
                int livro = Convert.ToInt32(row.Cells["Livro"].Value);
                string dtRegistro = row.Cells["DtRegistro"].Value?.ToString() ?? string.Empty;
                DateTime vencimentoDoc = Convert.ToDateTime(row.Cells["Vencimentodoc"].Value);
                string obs = row.Cells["Obs"].Value?.ToString() ?? string.Empty;
                string tipo = row.Cells["Tipo"].Value?.ToString() ?? string.Empty;
                string nome = row.Cells["NOME"].Value?.ToString() ?? string.Empty;
                string cnpj = row.Cells["CNPJ"].Value?.ToString() ?? string.Empty;
                string cidade = row.Cells["CIDADE"].Value?.ToString() ?? string.Empty;

                // Passa os dados para o formulário secundário
                var formDetalhes = new ModDocForm(
                    idDoc,
                    livro,
                    dtRegistro,
                    vencimentoDoc,
                    obs,
                    tipo,
                    nome,
                    cnpj,
                    cidade
                );
                formDetalhes.ShowDialog();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportExcel.ExportarParaExcel(dgConsultaDocumentos);
        }

        private void btnExportarVencendo_Click(object sender, EventArgs e)
        {
            ExportExcel.ExportarParaExcel(dgVencendo);
        }

        private void dgVencendo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgVencendo.Rows[e.RowIndex];

                // Extrai os dados da linha, com tratamento para valores nulos
                int idDoc = Convert.ToInt32(row.Cells["IdDoc1"].Value);
                int livro = Convert.ToInt32(row.Cells["Livro1"].Value);
                string dtRegistro = row.Cells["DtRegistro1"].Value?.ToString() ?? string.Empty;
                DateTime vencimentoDoc = Convert.ToDateTime(row.Cells["Vencimentodoc1"].Value);
                string obs = row.Cells["Obs1"].Value?.ToString() ?? string.Empty;
                string tipo = row.Cells["Tipo1"].Value?.ToString() ?? string.Empty;
                string nome = row.Cells["NOME1"].Value?.ToString() ?? string.Empty;
                string cnpj = row.Cells["CNPJ1"].Value?.ToString() ?? string.Empty;
                string cidade = row.Cells["CIDADE1"].Value?.ToString() ?? string.Empty;

                // Passa os dados para o formulário secundário
                var formDetalhes = new ModDocForm(
                    idDoc,
                    livro,
                    dtRegistro,
                    vencimentoDoc,
                    obs,
                    tipo,
                    nome,
                    cnpj,
                    cidade
                );
                formDetalhes.ShowDialog();
            }
        }
    }
}
