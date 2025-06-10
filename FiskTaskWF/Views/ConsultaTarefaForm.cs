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

            TarefaLoadind("Codigo", "DESC");
        }


        public void TarefaLoadind(string coluna, string ordem)
        {
            var table = dbtarefa.ReadTarefaDT();
            table.DefaultView.Sort = $"{coluna} {ordem}";
            dgTarefas2.DataSource = table;

            int rowCount = ((DataTable)dgTarefas2.DataSource).DefaultView.ToTable().Select("Situacao = 'Em Andamento'").Length;
            lblTarefasPendentes.Text = $"O número de tarefas pendentes no total é de: {rowCount}";

            int rowCountAtivo = ((DataTable)dgTarefas2.DataSource).DefaultView.ToTable().Select("Ativo = true").Length;
            lblTarefasAtivas.Text = $"O número de tarefas ativas no total é de: {rowCountAtivo}";

        }
        public void ApagarPesquisa()
        {
            txtPesquisa.Clear();
        }




        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtPesquisa.Text.Replace("'", "''"); // Evitar erros com apóstrofos
            var dataTable = (dgTarefas2.DataSource as DataTable);

            if (cbEmAndamento.Checked == true)
            {

                if (dataTable != null)
                {
                    dataTable.DefaultView.RowFilter = string.Format(
                        "(NOME LIKE '%{0}%' OR CNPJ LIKE '%{0}%' OR CIDADE LIKE '%{0}%') AND Situacao LIKE 'Em andamento'",
                        filtro
                    );
                }
            }
            else
            {
                if (dataTable != null)
                {
                    dataTable.DefaultView.RowFilter = string.Format(
                        "NOME LIKE '%{0}%' OR CNPJ LIKE '%{0}%' OR CIDADE LIKE '%{0}%'",
                        filtro
                    );
                }

            }
        }

        private void txtAtualizar_Click(object sender, EventArgs e)
        {
            TarefaLoadind("Codigo", "DESC");
            cbSituacao.SelectedItem = -1;
            cbSituacao.Text = "";
            cbTipo.SelectedItem = -1;
            cbTipo.Text = "";

        }


        private void cbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? filtro = cbSituacao.Text.Replace("'", "''"); // Evitar erros com apóstrofos
            var dataTable = (dgTarefas2.DataSource as DataTable);

            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format(
                    "Fase LIKE '%{0}%'", filtro
                );
            }

            cbTipo.SelectedItem = -1;
            cbTipo.Text = "";
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? filtro = cbTipo.Text.Replace("'", "''"); // Evitar erros com apóstrofos
            var dataTable = (dgTarefas2.DataSource as DataTable);

            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format(
                    "Situacao LIKE '%{0}%'", filtro
                );
            }
            cbSituacao.SelectedItem = -1;
            cbSituacao.Text = "";
        }

        private void btnFitroAlvara_Click(object sender, EventArgs e)
        {
            var dataTable = (dgTarefas2.DataSource as DataTable);
            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format("Ativo = true");
            }
            cbSituacao.SelectedItem = -1;
            cbSituacao.Text = "";
            cbTipo.SelectedItem = -1;
            cbTipo.Text = "";
        }

        private void btnOutrosPendentes_Click(object sender, EventArgs e)
        {
            var dataTable = (dgTarefas2.DataSource as DataTable);
            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format("Tipo <> 'Alvará' AND Situacao <> 'Encerrado'");
                cbSituacao.SelectedItem = -1;
                cbSituacao.Text = "";
                cbTipo.SelectedItem = -1;
                cbTipo.Text = "";
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportExcel.ExportarParaExcel(dgTarefas2);
        }

        private void dgTarefas2_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgTarefas2.Rows[e.RowIndex];

                int codigo = Convert.ToInt32(row.Cells["Codigo"].Value);
                int livro = Convert.ToInt32(row.Cells["Empresa"].Value);
                string nome = row.Cells["NOME"].Value?.ToString() ?? string.Empty;
                string cnpj = row.Cells["CNPJs"].Value?.ToString() ?? string.Empty;
                string cidade = row.Cells["CIDADE"].Value?.ToString() ?? string.Empty;
                //string tipo = row.Cells["Tipo"].Value?.ToString() ?? string.Empty;
                string situacao = row.Cells["Situacao"].Value?.ToString() ?? string.Empty;
                string obs = row.Cells["Obs"].Value?.ToString() ?? string.Empty;
                string dtregistro = row.Cells["Dtregistro"].Value?.ToString() ?? string.Empty;
                bool bombeiro = Convert.ToBoolean(row.Cells["Bombeiro"].Value);
                bool vigilanciasanitaria = Convert.ToBoolean(row.Cells["VigilanciaSanitaria"].Value);
                bool taxaalvarapgto = Convert.ToBoolean(row.Cells["TaxaAlvaraPgto"].Value);
                bool entregataxaalvara = Convert.ToBoolean(row.Cells["EntregaTaxaAlvara"].Value);
                string fase = row.Cells["Fase"].Value?.ToString() ?? string.Empty;
                bool ativo = Convert.ToBoolean(row.Cells["Ativo"].Value);

                var formDetalhes = new ModTarefaForm(
                    this,
                    codigo,
                    livro,
                    situacao,
                    obs,
                    nome,
                    cnpj,
                    cidade,
                    dtregistro,
                    bombeiro,
                    vigilanciasanitaria,
                    taxaalvarapgto,
                    entregataxaalvara,
                    fase,
                    ativo
                );

                formDetalhes.ShowDialog();
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(() =>
            {
                FiltroDocumentos(e);
            }));
        }

        private void FiltroDocumentos(ItemCheckEventArgs e)
        {
            var tabela = (dgTarefas2.DataSource as DataTable);
            if (tabela == null) return;

            List<string> filtros = new List<string>();
            string filtroSituacao = "Situacao <> 'Encerrado'";

            for (int i = 0; i < clbDocumentos.Items.Count; i++)
            {
                string? item = clbDocumentos.Items[i].ToString();
                bool isChecked = clbDocumentos.GetItemChecked(i);

                // Ajusta o estado do item que está sendo alterado
                if (i == e.Index)
                {
                    isChecked = (e.NewValue == CheckState.Checked);
                }

                string clausula = "";
                if (isChecked)
                {
                    if (item == "Bombeiro")
                    {
                        clausula = "Bombeiro = true";
                    }
                    else if (item == "Vigilância Sanitária")
                    {
                        clausula = "VigilanciaSanitaria = true";
                    }
                    else if (item == "Taxa de alvará paga")
                    {
                        clausula = "TaxaAlvaraPgto = true";
                    }
                    else if (item == "Taxa de Alvará Entregue")
                    {
                        clausula = "EntregaTaxaAlvara = true";
                    }

                    if (!string.IsNullOrEmpty(clausula))
                    {
                        filtros.Add(clausula);
                    }
                }
            }

            string filtroDocumentos = "";
            if (filtros.Count > 0)
            {
                filtroDocumentos = "(" + string.Join(" OR ", filtros) + ")";
            }

            string filtroFinal = filtroSituacao;
            if (!string.IsNullOrEmpty(filtroDocumentos))
            {
                filtroFinal += " AND " + filtroDocumentos;
            }

            tabela.DefaultView.RowFilter = filtroFinal;
        }

    }
}
