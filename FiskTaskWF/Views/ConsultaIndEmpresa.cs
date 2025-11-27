using FiscoTask.DataBase;
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
        DbSocio dbsocio = new DbSocio();
        private readonly ConsultaCNPJ consultacnpj = new ConsultaCNPJ();


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
                $" com sede no endereço {_ENDERECO}, n° {_NUMERO}, {_COMPLEMENTO}, bairro {_BAIRRO}, na cidade de {_CIDADE} - {_UF}," +
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
                    string ApiCNPJ = rows[0]["InfoCNPJ"]?.ToString() ?? "informações naõ registradas no Banco de dados";

                    // Exiba apenas o conteúdo do campo NOTAS no RichTextBox
                    rtbNotas.Text = nota;
                    rtbInfoCNPJ.Text = ApiCNPJ;
                }
                else
                {
                    rtbNotas.Text = $"Nenhuma nota encontrada para a ID: {livro}.";
                    rtbInfoCNPJ.Text = $"informações não registradas no Banco de dados para a ID: {livro}.";
                }
            }
            else
            {
                rtbNotas.Text = "ID inválida. Por favor, insira um número válido.";
                rtbInfoCNPJ.Text = $"inválida. Por favor, insira um número válido.";
            }

            var responsavel = new DbResponsaveis();
            DataTable dt1 = responsavel.ReadResponsaveis();

            if (int.TryParse(txtLivro.Text, out int livro1))
            {
                // Filtre as linhas do DataTable pela ID especificada
                DataRow[] rows = dt1.Select($"LIVRO = {livro1}");

                if (rows.Length > 0)
                {
                    // Obtenha o conteúdo do campo NOTAS da primeira linha encontrada
                    string resp = rows[0]["RESPONSAVEL"]?.ToString() ?? "Nota não disponível";

                    // Exiba apenas o conteúdo do campo NOTAS no RichTextBox
                    txtResponsavelInterno.Text = resp;
                }
                else
                {
                    txtResponsavelInterno.Text = "Nenhum responsável cadastrado.";
                }
            }
            else
            {
                rtbNotas.Text = "ID inválida. Por favor, insira um número válido.";
            }

            AtualizarInformacoes();


        }

        private void AtualizarInformacoes()
        {
            DadosProcessoBombeiro(txtLivro.Text, "DATA_REGISTRO", "DESC");
            DadosDocumentos(txtLivro.Text, "Vencimentodoc", "DESC");
            DadosTarefas(txtLivro.Text, "Dtregistro", "DESC");
            DadosProcessos(txtLivro.Text, "DataModificacao", "DESC");

            LoadSocios("SOCIO", "ASC", txtLivro.Text);
            DescobrirEscritorio(int.Parse(txtLivro.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var notas = new dbNotas();
            notas.UpdateInsertNotas(int.Parse(txtLivro.Text), rtbNotas.Text, rtbInfoCNPJ.Text);

        }

        private void LoadSocios(string coluna, string ordem, string livro)
        {
            string filtroempresa = livro;
            var table = dbsocio.ReadSocio();
            if (!string.IsNullOrEmpty(filtroempresa))
            {
                table.DefaultView.RowFilter = $"EMPRESA = '{filtroempresa}'";
            }
            table.DefaultView.Sort = $"{coluna} {ordem}";
            dgSocios.DataSource = table.DefaultView.ToTable();
        }

        private void DescobrirEscritorio(int livro)
        {
            if (livro <= 0)
            {
                lblEscritorio.Text = "EMPRESA CADASTRADA NO ESCRITÓRIO DO PETÉ";
            }
            else
            {
                lblEscritorio.Text = "EMPRESA CADASTRADA NA FISCONORTE";
            }
        }

        private async void btnInfoCNPJ_Click(object sender, EventArgs e)
        {
            string cnpj = txtCNPJ.Text.Trim().Replace(".", "").Replace("/", "").Replace("-", "");

            if (cnpj.Length != 14)
            {
                MessageBox.Show("CNPJ inválido! Insira um CNPJ com 14 números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            rtbInfoCNPJ.Clear();
            rtbInfoCNPJ.Text = "Buscando...";

            EmpresaAPI? empresa = await consultacnpj.BuscarEmpresaCNPJ(cnpj);

            string canesSecundarios = empresa.cnaes_secundarios != null && empresa.cnaes_secundarios.Count > 0
                ? string.Join(", ", empresa.cnaes_secundarios.Select(c => $"{c.codigo} - {c.descricao}")) : "Nenhum CNAE secundário encontrado.";

            string QSA = empresa.qsa != null && empresa.qsa.Count > 0
                ? string.Join("\n", empresa.qsa.Select(s => $"{s.nome_socio} - {s.qualificacao_socio}")) : "Nenhum sócio cadastrado.";



            if (empresa != null)
            {
                rtbInfoCNPJ.Text = $"Razão Social: {empresa.razao_social}\n" +
                                    $"Nome Fantasia: {empresa.nome_fantasia}\n" +

                                    "\n" +
                                    "CNAE PRINCIPAL \n" +
                                    "\n" +
                                    $"CNAE: {empresa.cnae_fiscal}\n" +
                                    $"Descrição: {empresa.cnae_fiscal_descricao}\n" +

                                    "\n" +
                                    "CNAEs  SECUNDÁRIOS \n" +
                                    "\n" +

                                    $"CNAEs Secundários: {canesSecundarios}\n" +

                                    "\n" +
                                    "SÓCIOS REGISTRADOS NA RECEITA \n" +
                                    "\n" +

                                    $"Sócios: {QSA}\n" +

                                    "\n" +
                                    "ENDEREÇO \n" +
                                    "\n" +


                                    $"Município: {empresa.municipio} - {empresa.uf}\n" +
                                    $"Rua: {empresa.logradouro}\n" +
                                    $"Número: {empresa.numero}\n" +
                                    $"Complemento: {empresa.complemento}\n" +
                                    $"Bairro: {empresa.bairro}\n" +
                                    $"CEP: {empresa.cep}\n" +
                                    $"Número: {empresa.numero}\n" +

                                    "\n" +
                                    "CONTATOS \n" +
                                    "\n" +

                                    $"Fax: {empresa.ddd_fax} - Telefone 1 {empresa.ddd_telefone_1} - Telefone 2 {empresa.ddd_telefone_2}\n" +

                                    "\n" +
                                    "OUTRAS INFORMAÇÕES \n" +
                                    "\n" +

                                    $"Início Atividade: {empresa.data_inicio_atividade}\n" +
                                    $"Situação Cadastral: {empresa.situacao_cadastral} com data de {empresa.data_situacao_cadastral} \n" +
                                    $"Opção pelo simples: {empresa.opcao_pelo_simples} - Data: {empresa.data_opcao_pelo_simples} - Data da Exclusão: {empresa.data_exclusao_do_simples}\n" +
                                    $"Opção pelo MEI: {empresa.opcao_pelo_mei} - Data: {empresa.data_opcao_pelo_mei} - Data da Exclusão: {empresa.data_exclusao_do_mei}\n" +
                                    $"Capital Social: {empresa.capital_social}\n" +
                                    $"Porte da empresa: {empresa.codigo_porte} - {empresa.porte} - {empresa.descricao_porte}\n"

                                    ;
            }
            else
            {
                rtbInfoCNPJ.Text = "Empresa não encontrada.";
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

        private void DadosTarefas(string livro, string coluna, string ordem)
        {
            DbTarefa dbtarefa = new DbTarefa();
            string filtro = livro;
            var table = dbtarefa.ReadTarefaDT();
            if (!string.IsNullOrEmpty(filtro))
            {
                table.DefaultView.RowFilter = $"EMPRESA = '{filtro}'";
            }
            table.DefaultView.Sort = $"{coluna} {ordem}";
            dgTarefas.DataSource = table.DefaultView.ToTable();
        }

        private void DadosProcessos(string livro, string coluna, string ordem)
        {
            DbProcessos dbprocessos = new DbProcessos();
            string filtro = livro;
            var table = dbprocessos.ReadProcessos();
            if (!string.IsNullOrEmpty(filtro))
            {
                table.DefaultView.RowFilter = $"Empresa = {filtro}";
            }
            table.DefaultView.Sort = $"{coluna} {ordem}";
            dgProcessos.DataSource = table.DefaultView.ToTable();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultaIndEmpresa_Load(null, null);
        }
    }
}
