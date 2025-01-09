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
    public partial class ConsultaIndEmpresa : Form
    {
        private int _EMPRESA;
        private string _NOME;
        private string _CNPJ;
        private string _NOMEFANTASIA;
        private string _ENDERECO;
        private string _NUMERO;
        private string _BAIRRO;
        private string _COMPLEMENTO;
        private string _CIDADE;
        private string _UF;
        private string _CEP;
        private string _REGIME;
        private string _E_MAIL;
        private string _FONE;
        private string _RESPONSAVEL;
        private string _IE;

        public ConsultaIndEmpresa(int empresa, string nome, string cnpj, string nomefantasia, string endereco, string numero,
            string bairro, string complemento, string cidade, string uf, string cep, string regime, string email, string fone,
            string responsavel, string ie)
        {
            InitializeComponent();

            _EMPRESA = empresa;
            _NOME = nome;
            _CNPJ = cnpj;
            _NOMEFANTASIA = nomefantasia;
            _ENDERECO = endereco;
            _NUMERO = numero;
            _BAIRRO = bairro;
            _COMPLEMENTO = complemento;
            _CIDADE = cidade;
            _UF = uf;
            _CEP = cep;
            _REGIME = regime;
            _E_MAIL = email;
            _FONE = fone;
            _RESPONSAVEL = responsavel;
            _IE = ie;
        }

        private void ConsultaIndEmpresa_Load(object sender, EventArgs e)
        {
            txtLivro.Text = _EMPRESA.ToString();
            txtNome.Text = _NOME.ToString();
            txtCNPJ.Text = _CNPJ.ToString();
            txtNomeFantasia.Text = _NOMEFANTASIA.ToString();
            txtRegime.Text = _REGIME.ToString();
            txtEmail.Text = _E_MAIL.ToString();
            txtTelefone.Text = _FONE.ToString();
            txtResponsavel.Text = _RESPONSAVEL.ToString();
            txtIE.Text = _IE.ToString();

            txtEndereco.Text = _ENDERECO.ToString();
            txtNumero.Text = _NUMERO.ToString();
            txtBairro.Text = _BAIRRO.ToString();
            txtComplemento.Text = _COMPLEMENTO.ToString();
            txtCidade.Text = _CIDADE.ToString();
            txtEstado.Text = _UF.ToString();
            txtCEP.Text = _CEP.ToString();

            rtbQualificacao.Text = $"{_NOME}, pessoa jurídica de direito privado inscrita no CNPJ sob n° {_CNPJ}," +
                $"com sede no endereço {_ENDERECO}, n° {_NUMERO}, {_COMPLEMENTO}, bairro {_BAIRRO}, na cidade de {_CIDADE} - {_UF}," +
                $" CEP: {_CEP}";

            var notes = new dbNotas();
            DataTable dt = notes.ReadNota();


            if (int.TryParse(txtLivro.Text, out int livro))
            {
                // Filtre as linhas do DataTable pela ID especificada
                DataRow[] rows = dt.Select($"LIVRO = {livro}");

                if (rows.Length > 0)
                {
                    // Obtenha o conteúdo do campo NOTAS da primeira linha encontrada
                    string nota = rows[0]["NOTAS"]?.ToString() ?? "Nota não disponível";

                    // Exiba apenas o conteúdo do campo NOTAS no RichTextBox
                    rtbNotas.Text = nota;
                }
                else
                {
                    rtbNotas.Text = $"Nenhuma nota encontrada para a ID: {livro}.";
                }
            }
            else
            {
                rtbNotas.Text = "ID inválida. Por favor, insira um número válido.";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var notas = new dbNotas();
            notas.UpdateInsertNotas(int.Parse(txtLivro.Text), rtbNotas.Text);

        }
    }
}
