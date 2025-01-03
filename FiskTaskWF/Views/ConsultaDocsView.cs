    using FiscoTask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace FiscoTask
{
    public partial class ConsultaDocsView : UserControl
    {
        private BindingSource bindingSource = new BindingSource();
        DbDocuments dbdocuments = new DbDocuments();
        private BindingList<DbDocuments> documentosFiltrados = new BindingList<DbDocuments>();

        public ConsultaDocsView()
        {
            InitializeComponent();

            LoadDocuments();

        }

        private void LoadDocuments()
        {
            try
            {
                var documentos = dbdocuments.ReadDoc();
                documentosFiltrados = new BindingList<DbDocuments>(documentos.ToList()); // Clona os dados
                dgConsultaDocumentos.DataSource = documentosFiltrados; // Exibe no DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar empresas: {ex.Message}");
            }
        }

        private void ApplyFilter(string filtro)
        {
            if (string.IsNullOrEmpty(filtro))
            {
                documentosFiltrados = new BindingList<DbDocuments>(dbdocuments.BDDocuments.ToList());
            }
            else
            {
                // Aplica o filtro manualmente
                var FiltroDocumentos = dbdocuments.BDDocuments
                    .Where(c => c.NOME != null && c.NOME.Contains(filtro, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                documentosFiltrados = new BindingList<DbDocuments>(FiltroDocumentos);
            }
            // Atualiza o DataGridView com os dados filtrados
            dgConsultaDocumentos.DataSource = documentosFiltrados;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter(txtPesquisa.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDocuments();
        }

        private void dgConsultaDocumentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgConsultaDocumentos.Rows[e.RowIndex];

                // Extrai os dados da linha, com tratamento para valores nulos
                int idDoc = Convert.ToInt32(row.Cells["IdDoc"].Value);
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
    }
}
