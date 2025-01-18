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
    public partial class ConsultaSociosForm : Form
    {
        DbSocio dbsocio = new DbSocio();

        public ConsultaSociosForm()
        {
            InitializeComponent();
            LoadSocios("SOCIO", "ASC");
        }

        private void LoadSocios(string coluna, string ordem)
        {
            var table = dbsocio.ReadSocio();
            table.DefaultView.Sort = $"{coluna} {ordem}";
            dgSocios.DataSource = table;
        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtEmpresa.Text.Replace("'", "''"); // Evitar erros com apóstrofos
            var dataTable = (dgSocios.DataSource as DataTable);

            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format(
                    "NOME LIKE '%{0}%' OR CNPJ LIKE '%{0}%' OR CIDADE LIKE '%{0}%'",
                    filtro
                );
            }
        }

        private void txtSocio_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtSocio.Text.Replace("'", "''"); // Evitar erros com apóstrofos
            var dataTable = (dgSocios.DataSource as DataTable);

            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format(
                    "SOCIO LIKE '%{0}%'",
                    filtro
                );
            }
        }


    }
}
