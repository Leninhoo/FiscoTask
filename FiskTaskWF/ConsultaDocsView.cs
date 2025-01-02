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
    }
}
