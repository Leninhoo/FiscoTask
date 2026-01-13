using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiscoTask.Models;

namespace FiscoTask
{
    public partial class ConsultaAtosEmpresariaisForm : Form
    {
        dbAtosEmpresariais dbatos = new dbAtosEmpresariais();

        public ConsultaAtosEmpresariaisForm()
        {
            InitializeComponent();
            AtosEmpresariaisLoading("ID", "DESC");
        }


        #region Métodos

        public void AtosEmpresariaisLoading(string coluna, string ordem)
        {
            var table = dbatos.ReadAtosEmpresariais();
            table.DefaultView.Sort = $"{coluna} {ordem}";
            dgAtosEmpresariais.DataSource = table;
        }
        public void ApagarPesquisa()
        {
            txtPesquisa.Clear();
        }
        private void AbrirFormularioAlteracao(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgAtosEmpresariais.Rows[e.RowIndex];

                int ID = Convert.ToInt32(row.Cells["ID"].Value);
                string DATA = row.Cells["DATA"].Value?.ToString() ?? string.Empty;
                string TIPO = row.Cells["TIPO"].Value?.ToString() ?? string.Empty;
                string RAZAO = row.Cells["RAZAO"].Value?.ToString() ?? string.Empty;
                string CNPJ = row.Cells["CNPJ"].Value?.ToString() ?? string.Empty;
                string LIVRO = row.Cells["LIVRO"].Value?.ToString() ?? string.Empty;
                string ESCRITORIO = row.Cells["ESCRITORIO"].Value?.ToString() ?? string.Empty;
                string RESPONSAVEL_INTERNO = row.Cells["RESPONSAVEL_INTERNO"].Value?.ToString() ?? string.Empty;
                string PROTOCOLO_EMPRESAFACIL = row.Cells["PROTOCOLO_EMPRESAFACIL"].Value?.ToString() ?? string.Empty;
                string OBS = row.Cells["OBS"].Value?.ToString() ?? string.Empty;

                var formDetalhes = new ModAtosEmpresariaisForm(
                    this,
                    ID,
                    DATA,
                    TIPO,
                    RAZAO,
                    CNPJ,
                    LIVRO,
                    ESCRITORIO,
                    RESPONSAVEL_INTERNO,
                    PROTOCOLO_EMPRESAFACIL,
                    OBS);

                formDetalhes.ShowDialog();
            }
        }
        private void FiltroPesquisa()
        {
            string filtro = txtPesquisa.Text.Replace("'", "''"); // Evitar erros com apóstrofos
            var dataTable = (dgAtosEmpresariais.DataSource as DataTable);

            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format(
                    "RAZAO LIKE '%{0}%' OR CNPJ LIKE '%{0}%' OR LIVRO LIKE '%{0}%'",
                    filtro
                );
            }
        }
        private void ExportarDadosParaExcel()
        {
            ExportExcel.ExportarParaExcel(dgAtosEmpresariais);
        }

        #endregion





        private void txtPesquisa_TextChanged(object sender, EventArgs e) => FiltroPesquisa();
        private void btnAtualizar_Click(object sender, EventArgs e) => AtosEmpresariaisLoading("ID", "DESC");
        private void dgAtosEmpresariais_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => AbrirFormularioAlteracao(e);
        private void btnExport_Click(object sender, EventArgs e) => ExportarDadosParaExcel();

    }
}
