using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FiscoTask
{
    public partial class ModAtosEmpresariaisForm : Form
    {
        dbAtosEmpresariais dbatos = new dbAtosEmpresariais();

        private readonly ConsultaAtosEmpresariaisForm _parentForm;
        private int _id;
        private string _data;
        private string _tipo;
        private string _razao;
        private string _cnpj;
        private string _livro;
        private string _escritorio;
        private string _responsavel_interno;
        private string _protocolo_empresafacil;
        private string _obs;


        public ModAtosEmpresariaisForm(ConsultaAtosEmpresariaisForm parentForm, int id, string data, string tipo, string razao, string cnpj, string livro, string escritorio,
            string responsavel_interno, string protocolo_empresafacil, string obs)
        {
            InitializeComponent();

            _parentForm = parentForm;
            _id = id;
            _data = data;
            _tipo = tipo;
            _razao = razao;
            _cnpj = cnpj;
            _livro = livro;
            _escritorio = escritorio;
            _responsavel_interno = responsavel_interno;
            _protocolo_empresafacil = protocolo_empresafacil;
            _obs = obs;



        }
        private void ModAtosEmpresariaisForm_Load(object sender, EventArgs e)
        {
            txtID.Text = _id.ToString();
            txtData.Text = _data.ToString();
            txtTipo.Text = _tipo.ToString();
            txtRazao.Text = _razao.ToString();
            txtCNPJ.Text = _cnpj.ToString();
            txtLivro.Text = _livro.ToString();
            txtResponsavel.Text = _escritorio.ToString();
            txtResponsavelnterno.Text = _responsavel_interno.ToString();
            txtProtocolo.Text = _protocolo_empresafacil.ToString();
            rtbObs.Text = _obs.ToString();
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

            dbatos.UpdateInsertAtos(Id, txtData.Text, txtTipo.Text, txtRazao.Text, txtCNPJ.Text, txtLivro.Text,
                txtResponsavel.Text, txtResponsavelnterno.Text, txtProtocolo.Text, rtbObs.Text);

            _parentForm.AtosEmpresariaisLoading("ID", "DESC");
            _parentForm.ApagarPesquisa();
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

                _parentForm.AtosEmpresariaisLoading("ID", "DESC");
                _parentForm.ApagarPesquisa();
                this.Close();
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _parentForm.AtosEmpresariaisLoading("ID", "DESC");
            _parentForm.ApagarPesquisa();
            this.Close();

        }


    }
}
