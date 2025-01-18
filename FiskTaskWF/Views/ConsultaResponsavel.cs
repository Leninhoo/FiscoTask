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
    public partial class ConsultaResponsavel : Form
    {
        DbResponsaveis dbresponsaveis = new DbResponsaveis();

        public ConsultaResponsavel()
        {
            InitializeComponent();
            ResponsaveisLoading("NOME", "ASC");
        }

        private void ResponsaveisLoading(string coluna, string ordem)
        {
            var table = dbresponsaveis.ReadResponsaveis();
            table.DefaultView.Sort = $"{coluna} {ordem}";
            dgResponsaveis.DataSource = table;
        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtEmpresa.Text.Replace("'", "''"); // Evitar erros com apóstrofos
            var dataTable = (dgResponsaveis.DataSource as DataTable);

            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format(
                    "NOME LIKE '%{0}%' OR CNPJ LIKE '%{0}%'",
                    filtro
                );
            }
        }

        private void txtResponsaveis_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtResponsaveis.Text.Replace("'", "''"); // Evitar erros com apóstrofos
            var dataTable = (dgResponsaveis.DataSource as DataTable);

            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format(
                    "RESPONSAVEL LIKE '%{0}%'",
                    filtro
                );
            }

        }
    }
}
