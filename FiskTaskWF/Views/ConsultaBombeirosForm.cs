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
    public partial class ConsultaBombeirosForm : Form
    {
        DbBombeiros dbbombeiros = new DbBombeiros();

        public ConsultaBombeirosForm()
        {
            InitializeComponent();
            BombeiroLoading("Id", "DESC");
        }

        private void BombeiroLoading(string coluna, string ordem)
        {
            var table = dbbombeiros.ReadBombeiro();
            table.DefaultView.Sort = $"{coluna} {ordem}";
            dgBombeiros.DataSource = table;
            
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtPesquisa.Text.Replace("'", "''"); // Evitar erros com apóstrofos
            var dataTable = (dgBombeiros.DataSource as DataTable);

            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format(
                    "NOME LIKE '%{0}%' OR CNPJ LIKE '%{0}%' OR CIDADE LIKE '%{0}%'",
                    filtro
                );
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            BombeiroLoading("Id", "DESC");
        }

        private void dgBombeiros_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgBombeiros.Rows[e.RowIndex];

                int id = Convert.ToInt32(row.Cells["Id"].Value);
                int livro = Convert.ToInt32(row.Cells["Livro"].Value);
                string PROCESSO = row.Cells["PROCESSO"].Value?.ToString() ?? string.Empty;
                string OBS = row.Cells["OBS"].Value?.ToString() ?? string.Empty;
                string DATA_REGISTRO = row.Cells["DATA_REGISTRO"].Value?.ToString() ?? string.Empty;
                string NOME = row.Cells["NOME"].Value?.ToString() ?? string.Empty;
                string CNPJ = row.Cells["CNPJ"].Value?.ToString() ?? string.Empty;
                string CIDADE = row.Cells["CIDADE"].Value?.ToString() ?? string.Empty;

                var formDetalhes = new ModBombeiroForm(
                    id,
                    livro,
                    PROCESSO,
                    OBS,
                    DATA_REGISTRO,
                    NOME,
                    CNPJ,
                    CIDADE
                    );

                formDetalhes.ShowDialog();
            }
        }
    }
}
