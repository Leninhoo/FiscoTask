using FiscoTask.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiscoTask.Views
{
    public partial class ModProcessoForm : Form
    {
        private readonly ConsultaProcessoForm _parentForm;
        private int _codigoProcesso;
        DbProcessos dbProcessos = new DbProcessos();


        public ModProcessoForm(ConsultaProcessoForm parentForm, int codigoProcesso)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _codigoProcesso = codigoProcesso;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _parentForm.AtualizarFormulario();
            this.Close();
        }

        public void CarregarProcesso(int codigoProcesso)
        {
            // Lógica para carregar os dados do processo com base no código fornecido
            // e preencher os campos do formulário.

            dbProcessos.CarregarComboBox("TipoProcesso", cbTipo);
            dbProcessos.CarregarComboBox("Situacao", cbSituacao);
            dbProcessos.CarregarComboBox("Andamento", cbAndamento);

            txtIdProcesso.Text = codigoProcesso.ToString();

            dbProcessos = dbProcessos.ReadProcessoByCode(codigoProcesso);
            if (dbProcessos != null)
            {
                txtEmpresa.Text = dbProcessos.Empresa.ToString();
                cbSituacao.Text = dbProcessos.Situacao;
                cbAndamento.Text = dbProcessos.Andamento;
                cbTipo.Text = dbProcessos.TipoProcesso;
                txtCNPJ.Text = dbProcessos.CNPJ;
                txtCidade.Text = dbProcessos.CIDADE;
                txtDataRegistro.Text = dbProcessos.Dtregistro;
            }
            DadosEmpresas();
            DadosResponsavel();
            Anotacoes();
        }


        private void DadosEmpresas()
        {
            var empresas = new EmpresaView();
            DataTable dt = empresas.ReadEmpresasDT();

            if (int.TryParse(txtEmpresa.Text, out int livro))
            {
                DataRow[] rows = dt.Select($"EMPRESA = {livro}");

                if (rows.Length > 0)
                {
                    string endereço = rows[0]["ENDERECO"]?.ToString() ?? "Não encontrado";
                    string numero = rows[0]["NUMERO"]?.ToString() ?? "Não encontrado";
                    string bairro = rows[0]["BAIRRO"]?.ToString() ?? "Não encontrado";
                    string complemento = rows[0]["COMPLEMENTO"]?.ToString() ?? "Não encontrado";
                    string cidade = rows[0]["CIDADE"]?.ToString() ?? "Não encontrado";
                    string uf = rows[0]["UF"]?.ToString() ?? "Não encontrado";
                    string cep = rows[0]["CEP"]?.ToString() ?? "Não encontrado";


                    txtEndereco.Text = endereço;
                    txtNumero.Text = numero;
                    txtBairro.Text = bairro;
                    txtComplemento.Text = complemento;
                    txtCidade1.Text = cidade;
                    txtEstado.Text = uf;
                    txtCEP.Text = cep;


                }
                else
                {
                    txtEndereco.Text = "Não encontrado";
                    txtNumero.Text = "Não encontrado";
                    txtBairro.Text = "Não encontrado";
                    txtComplemento.Text = "Não encontrado";
                    txtCidade1.Text = "Não encontrado";
                    txtEstado.Text = "Não encontrado";
                    txtCEP.Text = "Não encontrado";
                }
            }
            else
            {
                txtEndereco.Text = $"Nenhuma info encontrada para {livro}";
                txtNumero.Text = $"Nenhuma info encontrada para {livro}";
                txtBairro.Text = $"Nenhuma info encontrada para {livro}";
                txtComplemento.Text = $"Nenhuma info encontrada para {livro}";
                txtCidade1.Text = $"Nenhuma info encontrada para {livro}";
                txtEstado.Text = $"Nenhuma info encontrada para {livro}";
                txtCEP.Text = $"Nenhuma info encontrada para {livro}";
            }
        }
        private void DadosResponsavel()
        {
            var responsavel = new DbResponsaveis();
            DataTable dt = responsavel.ReadResponsaveis();

            if (int.TryParse(txtEmpresa.Text, out int livro))
            {
                DataRow[] rows = dt.Select($"LIVRO = {livro}");
                if (rows.Length > 0)
                {
                    string resp = rows[0]["RESPONSAVEL"]?.ToString() ?? "Não encontrado";

                    txtResponsavel.Text = resp;
                }
                else
                {
                    txtResponsavel.Text = "Não encontrado";
                }
            }
            else
            {
                txtResponsavel.Text = $"Nenhuma info encontrada para {livro}";
            }
        }
        private void Anotacoes()
        {
            try
            {
                var db = new DbProcessos();
                var processo = db.ReadProcessoByCode(_codigoProcesso);

                if (processo != null && processo.Arquivo != null)
                {
                    // Carrega o arquivo existente do banco de dados no RichEditControl
                    byte[] fileData = processo.Arquivo;
                    using (MemoryStream ms = new MemoryStream(fileData))
                    {
                        recArquivo.Rec.LoadDocument(ms, DevExpress.XtraRichEdit.DocumentFormat.OpenXml);
                    }
                }
                else
                {
                    // Limpa o editor se não houver arquivo no banco
                    recArquivo.Rec.CreateNewDocument();
                    MessageBox.Show("Nenhuma anotação encontrada. Um novo documento foi criado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a anotação: " + ex.Message);
            }
        }

        private void btnCarimbo_Click(object sender, EventArgs e)

        {
            try
            {
                // Obtém o RichEditControl do UserControl
                var richEditControl = recArquivo.Rec;

                // Define o texto do carimbo (pode ser personalizado)
                string carimbo = $"--------------------------- \n{DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss")} \n";
                // Insere o texto na posição atual do cursor
                richEditControl.Document.InsertText(richEditControl.Document.CaretPosition, carimbo);
                richEditControl.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar carimbo: " + ex.Message);
            }
        }

        private void ModProcessoForm_Load(object sender, EventArgs e)
        {
            CarregarProcesso(_codigoProcesso);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                dbProcessos.DeleteProcesso(_codigoProcesso);
                MessageBox.Show("Processo deletado com sucesso.");
                _parentForm.AtualizarFormulario();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar o processo: " + ex.Message);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                dbProcessos.UpdateProcesso(new DbProcessos
                {
                    Codigo = _codigoProcesso,
                    Empresa = int.Parse(txtEmpresa.Text),
                    Situacao = cbSituacao.Text,
                    Andamento = cbAndamento.Text,
                    TipoProcesso = cbTipo.Text,
                    Dtregistro = txtDataRegistro.Text,
                    Arquivo = ObterArquivoComoByteArray()
                });
                MessageBox.Show("Processo salvo com sucesso.");
                _parentForm.AtualizarFormulario();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o processo: " + ex.Message);
            }


        }

        private byte[] ObterArquivoComoByteArray()
        {
            byte[] filedata;
            using (MemoryStream ms = new MemoryStream())
            {
                recArquivo.Rec.SaveDocument(ms, DevExpress.XtraRichEdit.DocumentFormat.OpenXml);
                filedata = ms.ToArray();
                return filedata;
            }
        }
    }
}
