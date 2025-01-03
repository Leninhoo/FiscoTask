using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            var NewTarefa = new DbTarefa
            {
                Empresa = int.Parse(txtLivro.Text),
                Tipo = cbTipo.Text,
                Situacao = cbSituacao.Text,
                Obs = rtbObs.Text,
                Dtregistro = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")

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
    }
}
