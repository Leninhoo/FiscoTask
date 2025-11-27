using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscoTask.DataBase
{
    public class DbProcessos : BancoDados<DbProcessos>
    {
        public int Codigo { get; set; }
        public int Empresa { get; set; }
        public string? Situacao { get; set; }
        public string? Andamento { get; set; }
        public string? Filtro { get; set; }
        public string? Obs { get; set; }
        public DateTime Dtregistro { get; set; }
        public DateTime DataModificacao { get; set; }
        public string? TipoProcesso { get; set; }
        public byte[]? Arquivo { get; set; }

        public string? NOME { get; set; }
        public string? CNPJ { get; set; }
        public string? CIDADE { get; set; }

        protected override string NomeTabela => "Processos";
        protected override string CampoCodigo => "Codigo";

        //chama o método da classe base para criar um novo registro
        public void CreateProcesso(DbProcessos dbProcessos)
        {
            string query = @"INSERT INTO Processos
                                        (Codigo, Empresa, Situacao, Andamento, Filtro, Obs, Dtregistro, TipoProcesso, Arquivo)
                                    VALUES
                                        (@Codigo, @Empresa, @Situacao, @Andamento, @Filtro, @Obs, @Dtregistro, @TipoProcesso, @Arquivo)";

            Create(query, new
            {
                dbProcessos.Codigo,
                dbProcessos.Empresa,
                dbProcessos.Situacao,
                dbProcessos.Andamento,
                dbProcessos.Filtro,
                dbProcessos.Obs,
                dbProcessos.Dtregistro,
                dbProcessos.TipoProcesso,
                dbProcessos.Arquivo
            });
        }


        public void UpdateProcesso(DbProcessos dbProcessos)
        {
            string query = @"UPDATE Processos
                                    SET
                                        Codigo = @Codigo,
                                        Empresa = @Empresa,
                                        Situacao = @Situacao,
                                        Andamento = @Andamento,
                                        Filtro = @Filtro,
                                        Obs = @Obs,
                                        DataModificacao = @DataModificacao,
                                        TipoProcesso = @TipoProcesso,
                                        Arquivo = @Arquivo                                        
                                    WHERE Codigo = @Codigo";

            Update(query, new
            {
                dbProcessos.Codigo,
                dbProcessos.Empresa,
                dbProcessos.Situacao,
                dbProcessos.Andamento,
                dbProcessos.Filtro,
                dbProcessos.Obs,
                dbProcessos.DataModificacao,
                dbProcessos.TipoProcesso,
                dbProcessos.Arquivo
            });
        }


        /// Deletar tarefa (usa o método genérico da classe base)
        public void DeleteProcesso(int codigo)
        {
            Delete(codigo);
        }


        public DbProcessos ReadProcessoByCode(int codigo)
        {
            string query = @"
                SELECT
                    Processos.*,
                    vwEmpresas.Nome,
                    vwEmpresas.CNPJ,
                    vwEmpresas.Cidade
                FROM Processos
                INNER JOIN vwEmpresas ON Processos.Empresa = vwEmpresas.EMPRESA
                WHERE Processos.Codigo = @Codigo";

            
            return ReadByCode(codigo, query);
        }

        /// Buscar todas as tarefas como DataTable
        public DataTable ReadProcessos()
        {
            string query = @"
                SELECT
                    Processos.*,
                    vwEmpresas.Nome,
                    vwEmpresas.CNPJ,
                    vwEmpresas.Cidade
                FROM Processos
                INNER JOIN vwEmpresas ON Processos.Empresa = vwEmpresas.EMPRESA";

            return ExecuteQueryDataTable(query);
        }

        public void CarregarComboBox(string tabela, ComboBox comboBox)
        {
            var itens = ReadProcessos();

            var unicos = itens.AsEnumerable()
                .Select(row => row.Field<string>(tabela))
                .Where(tp => !string.IsNullOrWhiteSpace(tp))
                .Distinct()
                .ToList();

            comboBox.Items.Clear();

            foreach (var item in unicos)
            {
                comboBox.Items.Add(item);
            }

        }

               
    }
}
