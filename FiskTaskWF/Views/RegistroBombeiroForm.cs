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
    public partial class RegistroBombeiroForm : Form
    {
        EmpresaView empresa = new EmpresaView();
        public RegistroBombeiroForm()
        {
            InitializeComponent();
            LoadEmpresas();
        }

        public void LoadEmpresas()
        {
            var table = empresa.ReadEmpresasDT();
            dgEmpresas.DataSource = table;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtPesquisa.Text.Replace("'", "''"); // Evitar erros com apóstrofos
            var dataTable = (dgEmpresas.DataSource as DataTable);

            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format(
                    "NOME LIKE '%{0}%' OR CNPJ LIKE '%{0}%' OR CIDADE LIKE '%{0}%'",
                    filtro
                );
            }
        }
        private void dgEmpresas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var Livro = dgEmpresas.Rows[e.RowIndex].Cells["EMPRESA"].Value?.ToString();

                txtLivro.Text = Livro;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var db = new DbBombeiros();
            var newBombeiro = new DbBombeiros
            {
                Livro = int.Parse(txtLivro.Text),
                PROCESSO = txtProcesso.Text,
                OBS = rtbObs.Text,
                DATA_REGISTRO = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            };

            db.CreateBombeiro(newBombeiro);
            MessageBox.Show("Processo registrado com sucesso.", "Registro de Processo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
