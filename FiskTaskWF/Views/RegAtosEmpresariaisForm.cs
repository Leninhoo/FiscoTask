using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiscoTask
{
    public partial class RegAtosEmpresariaisForm : Form
    {
        dbAtosEmpresariais dbatos = new dbAtosEmpresariais();

        public RegAtosEmpresariaisForm()
        {
            InitializeComponent();
        }




        private void cbTipo_Enter(object sender, EventArgs e)
        {
            var dados = dbatos.PreencherComboBoxTipo();

            cbTipo.DataSource = dados;
            cbTipo.DisplayMember = "TIPO";
            cbTipo.ValueMember = "TIPO";    // Usa o campo ID como valor
        }

        private void cbEscitorio_Enter(object sender, EventArgs e)
        {
            var dados = dbatos.PreencherComboBoxEscritorio();

            cbEscitorio.DataSource = dados;
            cbEscitorio.DisplayMember = "ESCRITORIO";
            cbEscitorio.ValueMember = "ESCRITORIO";
        }

        private void cbResponsavel_Enter(object sender, EventArgs e)
        {
            var dados = dbatos.PreencherComboBoxResponsavel();

            cbResponsavel.DataSource = dados;
            cbResponsavel.DisplayMember = "RESPONSAVEL_INTERNO";
            cbResponsavel.ValueMember = "RESPONSAVEL_INTERNO";

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int Id;
            if (txtID.Text == "")
            {
                Id = 0;
            }
            else
            {
                Id = int.Parse(txtID.Text);
            }

            dbatos.UpdateInsertAtos(Id, txtData.Text, cbTipo.Text, txtRazao.Text, txtCNPJ.Text, txtLivro.Text,
                cbEscitorio.Text, cbResponsavel.Text, txtProtocolo.Text, rtbObs.Text);


            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Não há registro selecionado para exclusão");
            }
            else
            {
                var dialogResut = MessageBox.Show("Deseja realmente cancelar este registro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); ;

                if (dialogResut == DialogResult.Yes)
                {
                    dbatos.DeleteAtos(int.Parse(txtID.Text));
                }


                this.Close();
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
