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
    public partial class ModBombeiroForm : Form
    {
        private int _Id;
        private int _Livro;
        private string _PROCESSO;
        private string _OBS;
        private string _DATA_REGISTRO;
        private string _NOME;
        private string _CNPJ;
        private string _CIDADE;
        public ModBombeiroForm(int id, int livro, string processo,
            string obs, string dataRegistro, string nome, string cnpj, string cidade)
        {
            InitializeComponent();
            _Id = id;
            _Livro = livro;
            _PROCESSO = processo;
            _OBS = obs;
            _DATA_REGISTRO = dataRegistro;
            _NOME = nome;
            _CNPJ = cnpj;
            _CIDADE = cidade;
        }

        private void ModBombeiroForm_Load(object sender, EventArgs e)
        {
            txtID.Text = _Id.ToString();
            txtLivro.Text = _Livro.ToString();
            txtProcesso.Text = _PROCESSO.ToString();
            rtbObs.Text = _OBS.ToString();
            txtDataRegistro.Text = _DATA_REGISTRO.ToString();
            txtNOME.Text = _NOME.ToString();
            txtCNPJ.Text = _CNPJ.ToString();
            txtCIDADE.Text = _CIDADE.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente apagar este processo?", "EXCLUSÃO DE PROCESSO BOMBEIRO",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var db = new DbBombeiros();
                db.DeleteBombeiro(_Id);
                MessageBox.Show($"O Registro foi definitivamente apagado.");
                this.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var db = new DbBombeiros();
            var atualizarBombeiro = new DbBombeiros
            {
                Id = Convert.ToInt32(_Id),
                OBS = rtbObs.Text

            };
            db.UpdateBombeiro(atualizarBombeiro);
            MessageBox.Show("Tarefa atualizada com sucesso.");
        }
    }
}
