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
    public partial class ConsultaTarefaForm : Form
    {

        DbTarefa dbtarefa = new DbTarefa();


        public ConsultaTarefaForm()
        {
            InitializeComponent();

            TarefaLoadind();
        }


        private void TarefaLoadind()
        {
            var table = dbtarefa.ReadTarefaDT();
            dgTarefas2.DataSource = table;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtPesquisa.Text.Replace("'", "''"); // Evitar erros com apóstrofos
            var dataTable = (dgTarefas2.DataSource as DataTable);

            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format(
                    "NOME LIKE '%{0}%' OR CNPJ LIKE '%{0}%' OR CIDADE LIKE '%{0}%'",
                    filtro
                );
            }
        }

        private void txtAtualizar_Click(object sender, EventArgs e)
        {
            TarefaLoadind();
        }

        private void dgTarefas2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgTarefas2.Rows[e.RowIndex];

                int codigo = Convert.ToInt32(row.Cells["Codigo"].Value);
                int livro = Convert.ToInt32(row.Cells["Empresa"].Value);
                string nome = row.Cells["NOME"].Value?.ToString() ?? string.Empty;
                string cnpj = row.Cells["CNPJ"].Value?.ToString() ?? string.Empty;
                string cidade = row.Cells["CIDADE"].Value?.ToString() ?? string.Empty;
                string tipo = row.Cells["Tipo"].Value?.ToString() ?? string.Empty;
                string situacao = row.Cells["Situacao"].Value?.ToString() ?? string.Empty;
                string obs = row.Cells["Obs"].Value?.ToString() ?? string.Empty;
                string dtregistro = row.Cells["Dtregistro"].Value?.ToString() ?? string.Empty;


                var formDetalhes = new ModTarefaForm(
                    codigo,
                    livro,
                    tipo,
                    situacao,
                    obs,
                    nome,
                    cnpj,
                    cidade,
                    dtregistro                    
                    );
                
                formDetalhes.ShowDialog();
                
            }
        }
    }
}
