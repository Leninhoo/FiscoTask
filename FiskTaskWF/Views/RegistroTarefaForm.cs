using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiscoTask
{
    public partial class RegistroTarefaForm : Form
    {

        EmpresaView empresaView = new EmpresaView();
        public RegistroTarefaForm()
        {
            InitializeComponent();
            LoadEmpresas();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var db = new DbTarefa();

            // Converte o conteúdo do RichEditControl para bytes (formato .docx)
            byte[] fileData;
            using (MemoryStream ms = new MemoryStream())
            {
                recControl1.Rec.SaveDocument(ms, DevExpress.XtraRichEdit.DocumentFormat.OpenXml);
                fileData = ms.ToArray();
            }

            var NewTarefa = new DbTarefa
            {
                Empresa = int.Parse(txtLivro.Text),
                Tipo = cbTipo.Text,
                Situacao = cbSituacao.Text,
                //Obs = rtbObs.Text,
                Dtregistro = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                Arquivo = fileData, // Atribui o conteúdo do documento ao campo Arquivo

            }; 

            db.CreateTarefa(NewTarefa);
            MessageBox.Show("Tarefa registrada com sucesso.", "Registro de Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void dgPesquisaEmpresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var livroId = dgPesquisaEmpresa.Rows[e.RowIndex].Cells["Empresa"].Value?.ToString();

                txtLivro.Text = livroId;
            }
        }

        private void btnCarimbo_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém o RichEditControl do UserControl
                var richEditControl = recControl1.Rec;

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

        private void CarregarNotas()
        {
            recControl1.Rec.CreateNewDocument();
            btnCarimbo_Click(null, null);


        }

        private void RegistroTarefaForm_Load(object sender, EventArgs e)
        {
            CarregarNotas();
        }
    }
}
