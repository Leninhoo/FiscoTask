using DevExpress.DataAccess.Native.Data;
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
    public partial class EmpresasView : UserControl
    {

        EmpresaView empresaView = new EmpresaView();



        public EmpresasView()
        {
            InitializeComponent();

            Loadempresas("NOME", "ASC");

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Loadempresas(string coluna, string ordem)
        {
            var table = empresaView.ReadEmpresasDT();
            table.DefaultView.Sort = $"{coluna} {ordem}";
            dgEmpresas.DataSource = table;

            txtLivro.Clear();
            txtPesquisa.Clear();
        }



        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtPesquisa.Text.Replace("'", "''"); // Evitar erros com apóstrofos
            var dataTable = (dgEmpresas.DataSource as System.Data.DataTable);

            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format(
                    "NOME LIKE '%{0}%' OR CNPJ LIKE '%{0}%' OR CIDADE LIKE '%{0}%'",
                    filtro
                );
            }
        }

        private void dgEmpresas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgEmpresas.Rows[e.RowIndex];

            int EMPRESA = Convert.ToInt32(row.Cells["EMPRESA"].Value);
            string NOME = row.Cells["NOME"].Value?.ToString() ?? string.Empty;
            string CNPJ = row.Cells["CNPJ"].Value?.ToString() ?? string.Empty;
            string NOMEFANTASIA = row.Cells["NOMEFANTASIA"].Value?.ToString() ?? string.Empty;
            string ENDERECO = row.Cells["ENDERECO"].Value?.ToString() ?? string.Empty;
            string NUMERO = row.Cells["NUMERO"].Value?.ToString() ?? string.Empty;
            string BAIRRO = row.Cells["BAIRRO"].Value?.ToString() ?? string.Empty;
            string COMPLEMENTO = row.Cells["COMPLEMENTO"].Value?.ToString() ?? string.Empty;
            string CIDADE = row.Cells["CIDADE"].Value?.ToString() ?? string.Empty;
            string UF = row.Cells["UF"].Value?.ToString() ?? string.Empty;
            string CEP = row.Cells["CEP"].Value?.ToString() ?? string.Empty;
            string REGIME = row.Cells["REGIME"].Value?.ToString() ?? string.Empty;
            string E_MAIL = row.Cells["E_MAIL"].Value?.ToString() ?? string.Empty;
            string FONE = row.Cells["FONE"].Value?.ToString() ?? string.Empty;
            string RESPONSAVEL = row.Cells["RESPONSAVEL"].Value?.ToString() ?? string.Empty;
            string IE = row.Cells["IE"].Value?.ToString() ?? string.Empty;

            var formDetalhes = new ConsultaIndEmpresa(
                EMPRESA,
                NOME,
                CNPJ,
                NOMEFANTASIA,
                ENDERECO,
                NUMERO,
                BAIRRO,
                COMPLEMENTO,
                CIDADE,
                UF,
                CEP,
                REGIME,
                E_MAIL,
                FONE,
                RESPONSAVEL,
                IE
                );

            formDetalhes.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Loadempresas("NOME", "ASC");
        }


        private void btnPesquisaLivro_Click(object sender, EventArgs e)
        {
            string filtro = txtLivro.Text.Trim();

            if (int.TryParse(filtro, out int id))
            {
                var dataTable = (dgEmpresas.DataSource as System.Data.DataTable);

                if (dataTable != null)
                {
                    dataTable.DefaultView.RowFilter = $"EMPRESA = {id}";
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido para o ID da empresa.");
            }
        }
    }
}
