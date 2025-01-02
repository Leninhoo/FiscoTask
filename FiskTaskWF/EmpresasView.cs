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
        private BindingSource bindingSource = new BindingSource();
        EmpresaView empresaView = new EmpresaView();
        private BindingList<EmpresaView> empresasFiltradas = new BindingList<EmpresaView>();


        public EmpresasView()
        {
            InitializeComponent();

            Loadempresas();

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

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
    }
}
