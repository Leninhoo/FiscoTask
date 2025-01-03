using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace FiscoTask
{
    public partial class ModDocForm : Form
    {
        private int _idDoc;
        private int _livro;
        private string _dtRegistro;
        private DateTime _vencimentoDoc;
        private string _obs;
        private string _tipo;
        private string _nome;
        private string _cnpj;
        private string _cidade;


        public ModDocForm(int idDoc, int livro, string dtRegistro, DateTime vencimentoDoc,
        string obs, string tipo, string nome, string cnpj, string cidade)
        {
            InitializeComponent();

            _idDoc = idDoc;
            _livro = livro;
            _dtRegistro = dtRegistro;
            _vencimentoDoc = vencimentoDoc;
            _obs = obs;
            _tipo = tipo;
            _nome = nome;
            _cnpj = cnpj;
            _cidade = cidade;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModDocForm_Load(object sender, EventArgs e)
        {
            txtId.Text = _idDoc.ToString();
            txtLivro.Text = _livro.ToString();
            dtpVencimento.Value = _vencimentoDoc;
            rtbObs.Text = _obs;
            txtTipo.Text = _tipo;
            txtEmpresa.Text = _nome;
            txtCNPJ.Text = _cnpj;
            txtCidade.Text = _cidade;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new DbDocuments();
                var documentoAtualizado = new DbDocuments
                {
                    IdDoc = _idDoc, // Usa o ID do documento atual
                    Livro = _livro,
                    Tipo = _tipo,
                    Obs = rtbObs.Text,
                    Vencimentodoc = dtpVencimento.Value
                };

                // Atualiza o documento no banco
                db.UpdateDoc(documentoAtualizado);

                MessageBox.Show("Documento atualizado com sucesso!");
                this.Close(); // Fecha o formulário após salvar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o documento: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir definitivamente este registro de documento?", 
                "EXCLUSÃO DE REGISTRO",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var db = new DbDocuments();
                db.DeleteDoc(_idDoc);
                MessageBox.Show($"O Registro foi definitivamente apagado.");
                this.Close();
            }
            

            
        }
    }
}
