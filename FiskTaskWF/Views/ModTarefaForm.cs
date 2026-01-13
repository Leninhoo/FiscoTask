using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using FiscoTask.Models;

namespace FiscoTask
{
    public partial class ModTarefaForm : Form
    {
        private readonly ConsultaTarefaForm _parentForm;
        private int _Codigo;
        private int _Livro;
        //private string _Tipo;
        private string? _Situacao;
        private string? _Obs;
        private string? _Empresa;
        private string? _CNPJ;
        private string? _Cidade;
        private string? _dtRegistro;
        private bool _Bombeiro;
        private bool _VigilanciaSanitaria;
        private bool _TaxaAlvaraPgto;
        private bool _EntregaTaxaAlvara;
        private bool _Ativo;
        private string? _Fase;

        public ModTarefaForm(ConsultaTarefaForm parentForm, int codigo, int livro, string situacao,
                             string obs, string empresa, string cnpj, string cidade, string dtregistro, bool bombeiro, bool vigilanciasanitaria, bool taxaalvarapgto, bool EntregaTaxaAlvara, string fase, bool ativo)
        {
            InitializeComponent();

            _parentForm = parentForm;
            _Codigo = codigo;
            _Livro = livro;
            //_Tipo = tipo;
            _Situacao = situacao;
            _Obs = obs;
            _Empresa = empresa;
            _CNPJ = cnpj;
            _Cidade = cidade;
            _dtRegistro = dtregistro;
            _Bombeiro = bombeiro;
            _VigilanciaSanitaria = vigilanciasanitaria;
            _TaxaAlvaraPgto = taxaalvarapgto;
            _EntregaTaxaAlvara = EntregaTaxaAlvara;
            _Fase = fase;
            _Ativo = ativo;



        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var db = new DbTarefa();

            // Converte o conteúdo do RichEditControl para bytes (formato .docx)
            byte[] fileData;
            using (MemoryStream ms = new MemoryStream())
            {
                recControl1.Rec.SaveDocument(ms, DevExpress.XtraRichEdit.DocumentFormat.OpenXml);
                fileData = ms.ToArray();
            }

            var tarefaAtualizada = new DbTarefa
            {
                Codigo = _Codigo,
                Empresa = _Livro,
                Fase = cbFase.Text,
                Ativo = cbAtivo.Checked,
                Situacao = CbSituacao.Text,
                Obs = rtbObs.Text,
                Bombeiro = cbBombeiro.Checked,
                VigilanciaSanitaria = cbVigilanciaSanitaria.Checked,
                TaxaAlvaraPgto = cbTaxaAlvaraPgto.Checked,
                EntregaTaxaAlvara = cbEntregaTaxaAlvara.Checked,
                Arquivo = fileData // Atribui o conteúdo do documento ao campo Arquivo

            };

            db.UptadeTarefa(tarefaAtualizada);
            MessageBox.Show("Tarefa atualizada com sucesso.");


            //_parentForm.TarefaLoadind("Codigo", "DESC");
            //_parentForm.ApagarPesquisa();

            //this.Close();
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
                _parentForm.ApagarPesquisa();
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _parentForm.TarefaLoadind("Codigo", "DESC");
            _parentForm.ApagarPesquisa();
            this.Close();
        }

        private void ModTarefaForm_Load(object sender, EventArgs e)
        {
            CarregarComboBox();

            txtId.Text = _Codigo.ToString();
            txtLivro.Text = _Livro.ToString();
            CbSituacao.Text = _Situacao.ToString();
            cbFase.Text = _Fase.ToString();
            rtbObs.Text = _Obs.ToString();
            txtCidade.Text = _Cidade.ToString();
            txtEmpresa.Text = _Empresa.ToString();
            txtCNPJ.Text = _CNPJ.ToString();
            txtDataRegistro.Text = _dtRegistro.ToString();
            cbBombeiro.Checked = _Bombeiro;
            cbVigilanciaSanitaria.Checked = _VigilanciaSanitaria;
            cbTaxaAlvaraPgto.Checked = _TaxaAlvaraPgto;
            cbEntregaTaxaAlvara.Checked = _EntregaTaxaAlvara;
            cbAtivo.Checked = _Ativo;

            //.Text += $" \n\n--------------------------- \n{DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss")} \n";

            CorAtividade();

            registrarBombeiroControl1.NumeroLivro = txtLivro.Text;
            registroDocumentoControl1.NumeroLivro = txtLivro.Text;

            try
            {
                DadosEmpresas();
                DadosResponsavel();
                DadosProcessoBombeiro(txtLivro.Text, "DATA_REGISTRO", "DESC");
                DadosDocumentos(txtLivro.Text, "Vencimentodoc", "DESC");
                Anotacoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados da empresa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void cbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            CorAtividade();
        }

        private void CorAtividade()
        {
            if (cbAtivo.Checked == true)
            {
                cbAtivo.BackColor = Color.Green;
            }
            else
            {
                cbAtivo.BackColor = Color.Transparent;
            }
        }
        private void DadosResponsavel()
        {
            var responsavel = new DbResponsaveis();
            DataTable dt = responsavel.ReadResponsaveis();

            if (int.TryParse(txtLivro.Text, out int livro))
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
                var db = new DbTarefa();
                var tarefa = db.ReadTarefaByCodigo(_Codigo);

                if (tarefa != null && tarefa.Arquivo != null)
                {
                    // Carrega o arquivo existente do banco de dados no RichEditControl
                    byte[] fileData = tarefa.Arquivo;
                    using (MemoryStream ms = new MemoryStream(fileData))
                    {
                        recControl1.Rec.LoadDocument(ms, DevExpress.XtraRichEdit.DocumentFormat.OpenXml);
                    }
                }
                else
                {
                    // Limpa o editor se não houver arquivo no banco
                    recControl1.Rec.CreateNewDocument();
                    MessageBox.Show("Nenhuma anotação encontrada. Um novo documento foi criado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a anotação: " + ex.Message);
            }
        }
        private void DadosProcessoBombeiro(string livro, string coluna, string ordem)
        {
            DbBombeiros dbbombeiros = new DbBombeiros();
            string filtroBombeiro = livro;
            var table = dbbombeiros.ReadBombeiro();
            if (!string.IsNullOrEmpty(filtroBombeiro))
            {
                table.DefaultView.RowFilter = $"LIVRO = '{filtroBombeiro}'";
            }
            table.DefaultView.Sort = $"{coluna} {ordem}";
            dgBombeiro.DataSource = table.DefaultView.ToTable();


        }
        private void DadosDocumentos(string livro, string coluna, string ordem)
        {
            DbDocuments dbdocuments = new DbDocuments();
            string filtro = livro;
            var table = dbdocuments.ReadDocDT();
            if (!string.IsNullOrEmpty(filtro))
            {
                table.DefaultView.RowFilter = $"Livro = '{filtro}'";
            }
            table.DefaultView.Sort = $"{coluna} {ordem}";
            dgDocumentos.DataSource = table.DefaultView.ToTable();


        }
        private void DadosEmpresas()
        {
            var empresas = new EmpresaView();
            DataTable dt = empresas.ReadEmpresasDT();

            if (int.TryParse(txtLivro.Text, out int livro))
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

        private void btnCarimbo_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém o RichEditControl do UserControl
                var richEditControl = recControl1.Rec;

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

        private void button1_Click(object sender, EventArgs e)
        {
            DadosProcessoBombeiro(txtLivro.Text, "DATA_REGISTRO", "DESC");
            DadosDocumentos(txtLivro.Text, "Vencimentodoc", "DESC");
        }

        private void CarregarComboBox()
        {
            ListasComboBox listasComboBox = new ListasComboBox();


            cbFase.DataSource = listasComboBox.Fase();
            CbSituacao.DataSource = listasComboBox.Situacao();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            CbSituacao.SelectedItem = "Encerrado";
            cbFase.SelectedItem = "Pronto";
            cbAtivo.Checked = false;
        }
    }
}
