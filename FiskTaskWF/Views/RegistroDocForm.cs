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
    public partial class RegistroDocForm : Form
    {
        private BindingSource bindingSource = new BindingSource();
        EmpresaView empresaView = new EmpresaView();
        DbDocType DbDocType = new DbDocType();
        private BindingList<EmpresaView> empresasFiltradas = new BindingList<EmpresaView>();

        public RegistroDocForm()
        {
            InitializeComponent();
            Loadempresas();
            LoadDocType();
        }

        private void Loadempresas()
        {
            try
            {
                var empresas = empresaView.ListEmpresas();
                empresasFiltradas = new BindingList<EmpresaView>(empresas.ToList()); // Clona os dados
                dgEmpresas.DataSource = empresasFiltradas; // Exibe no DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar empresas: {ex.Message}");
            }
        }

        private void LoadDocType()
        {
            try
            {
                var doctype = DbDocType.ReadType();
                cbTipoDoc.DataSource = doctype;
                cbTipoDoc.DisplayMember = "TIPO";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar empresas: {ex.Message}");
            }
        }

        private void ApplyFilter(string filtro)
        {
            if (string.IsNullOrEmpty(filtro))
            {
                empresasFiltradas = new BindingList<EmpresaView>(empresaView.BDEmpresas.ToList());
            }
            else
            {
                // Aplica o filtro manualmente
                var filtroEmpresas = empresaView.BDEmpresas
                    .Where(c => c.NOME != null && c.NOME.Contains(filtro, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                empresasFiltradas = new BindingList<EmpresaView>(filtroEmpresas);
            }
            // Atualiza o DataGridView com os dados filtrados
            dgEmpresas.DataSource = empresasFiltradas;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter(txtPesquisa.Text);
        }

        private void dgEmpresas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var value = dgEmpresas.Rows[e.RowIndex].Cells[0].Value;
            txtLivro.Text = value != null ? value.ToString() : string.Empty;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var db = new DbDocuments();
            var NovoDocumento = new DbDocuments
            {
                Livro = int.Parse(txtLivro.Text),
                DtRegistro = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"),
                Vencimentodoc = dtpVencimento.Value,
                Obs = rtbObs.Text,
                Tipo = cbTipoDoc.Text,
            };

            db.CreateDoc(NovoDocumento);
            MessageBox.Show("Documento registrado com sucesso");

            this.Close();

        }

        private void RegistroDocForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}

     
