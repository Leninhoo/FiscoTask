using FiscoTask.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiscoTask.Models;

namespace FiscoTask.Views
{
    public partial class ConsultaProcessoForm : Form
    {
        DbProcessos dbProcessos = new DbProcessos();

        public ConsultaProcessoForm()
        {
            InitializeComponent();
            AtualizarFormulario();
        }

        public void AtualizarFormulario()
        {
            CarregarProcessos("DataModificacao", "DESC");
            dbProcessos.CarregarComboBox("TipoProcesso", cbTipo);
            dbProcessos.CarregarComboBox("Situacao", cbSituacao);
            dbProcessos.CarregarComboBox("Andamento", cbAndamento);
            ContarProcessos();

            cbSituacao.SelectedItem = -1;
            cbSituacao.Text = "";
            cbTipo.SelectedItem = -1;
            cbTipo.Text = "";
            cbAndamento.SelectedItem = -1;
            cbAndamento.Text = "";
            txtPesquisa.Clear();
            cbPendentes.Checked = false;

        }

        public void CarregarProcessos(string coluna, string ordem)
        {
            try
            {
                var processos = dbProcessos.ReadProcessos();
                processos.DefaultView.Sort = $"{coluna} {ordem}";
                dgProcessos.DataSource = processos;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar processos: {ex.Message}");
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtPesquisa.Text.Replace("'", "''"); // Evitar erros com apóstrofos
            var dataTable = (dgProcessos.DataSource as DataTable);

            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format(
                    "NOME LIKE '%{0}%' OR CIDADE LIKE '%{0}%'",
                    filtro
                );
            }
        }



        #region Filtros ComboBox
        private void cbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? filtro = cbSituacao.Text.Replace("'", "''"); // Evitar erros com apóstrofos
            var dataTable = (dgProcessos.DataSource as DataTable);

            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format(
                    "Situacao LIKE '%{0}%'", filtro
                );
            }

            cbTipo.SelectedItem = -1;
            cbTipo.Text = "";
            cbAndamento.SelectedItem = -1;
            cbAndamento.Text = "";
        }

        private void cbAndamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? filtro = cbAndamento.Text.Replace("'", "''"); // Evitar erros com apóstrofos
            var dataTable = (dgProcessos.DataSource as DataTable);

            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format(
                    "Andamento LIKE '%{0}%'", filtro
                );
            }

            cbTipo.SelectedItem = -1;
            cbTipo.Text = "";
            cbSituacao.SelectedItem = -1;
            cbSituacao.Text = "";
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? filtro = cbTipo.Text.Replace("'", "''"); // Evitar erros com apóstrofos
            var dataTable = (dgProcessos.DataSource as DataTable);

            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format(
                    "TipoProcesso LIKE '%{0}%'", filtro
                );
            }

            cbAndamento.SelectedItem = -1;
            cbAndamento.Text = "";
            cbSituacao.SelectedItem = -1;
            cbSituacao.Text = "";
        }
        #endregion


        private void dgProcessos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int codigoProcesso = Convert.ToInt32(dgProcessos.Rows[e.RowIndex].Cells["Codigo"].Value);
                ModProcessoForm modForm = new ModProcessoForm(this, codigoProcesso);
                //modForm.CarregarProcesso(codigoProcesso);
                modForm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtualizarFormulario();
        }

        private void ContarProcessos()
        {
            int rowCount = ((DataTable)dgProcessos.DataSource).DefaultView.ToTable().Select("Situacao = 'Em Andamento'").Length;
            lblQuantidade.Text = $"A quantidade de processos ativos é de: {rowCount}";

        }

        private void FiltrarSituacao(string filtro)
        {
            var tabela = (DataTable)dgProcessos.DataSource;
            if (tabela == null) return;

            string stringFiltro = $"Situacao <> '{filtro}'";

            tabela.DefaultView.RowFilter = stringFiltro;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            var ExportExcel = new ExportExcel();
            ExportExcel.ExportarParaExcel(dgProcessos);
        }

        private void cbPendentes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPendentes.Checked)
            {
                FiltrarSituacao("Encerrado");
            }
            else
            {
                AtualizarFormulario();
            }
        }
    }
}
