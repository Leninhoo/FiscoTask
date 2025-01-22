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
    public partial class ModTarefaForm : Form
    {
        private readonly ConsultaTarefaForm _parentForm;
        private int _Codigo;
        private int _Livro;
        private string _Tipo;
        private string _Situacao;
        private string _Obs;
        private string _Empresa;
        private string _CNPJ;
        private string _Cidade;
        private string _dtRegistro;

        public ModTarefaForm(ConsultaTarefaForm parentForm, int codigo, int livro, string tipo, string situacao,
                             string obs, string empresa, string cnpj, string cidade, string dtregistro)
        {
            InitializeComponent();

            _parentForm = parentForm;
            _Codigo = codigo;
            _Livro = livro;
            _Tipo = tipo;
            _Situacao = situacao;
            _Obs = obs;
            _Empresa = empresa;
            _CNPJ = cnpj;
            _Cidade = cidade;
            _dtRegistro = dtregistro;


        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var db = new DbTarefa();
            var tarefaAtualizada = new DbTarefa
            {
                Codigo = _Codigo,
                Empresa = _Livro,
                Tipo = cbTipo.Text,
                Situacao = cbSituacao.Text,
                Obs = rtbObs.Text,
            };

            db.UptadeTarefa(tarefaAtualizada);
            MessageBox.Show("Tarefa atualizada com sucesso.");

            
            _parentForm.TarefaLoadind("Codigo", "DESC");

            this.Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realment exluir esta tarefa?", 
                "EXCLUSÃO DE TAREFA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var db = new DbTarefa();
                db.DeleteTarefa(_Codigo);
                MessageBox.Show($"O Registro foi definitivamente apagado.");
                _parentForm.TarefaLoadind("Codigo", "DESC");
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _parentForm.TarefaLoadind("Codigo", "DESC");
            this.Close();
        }

        private void ModTarefaForm_Load(object sender, EventArgs e)
        {
            txtId.Text = _Codigo.ToString();
            txtLivro.Text = _Livro.ToString();
            cbTipo.Text = _Tipo.ToString();
            cbSituacao.Text = _Situacao.ToString();
            rtbObs.Text = _Obs.ToString();
            txtCidade.Text = _Cidade.ToString();
            txtEmpresa.Text = _Empresa.ToString();
            txtCNPJ.Text = _CNPJ.ToString();
            txtDataRegistro.Text = _dtRegistro.ToString();

            rtbObs.Text += $" \n--------------------------- \n{DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss")} \n";
        }
    }
}
