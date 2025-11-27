using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Dapper;
using System.Data;
using FiscoTask.DataBase;

namespace FiscoTask
{
    public class DbTarefa : BancoDados<DbTarefa>
    {
        public int Codigo { get; set; }
        public int Empresa { get; set; }
        public string Situacao { get; set; }
        public string Obs { get; set; }
        public string Dtregistro { get; set; }
        public string Tipo { get; set; }
        public bool Bombeiro { get; set; }
        public bool VigilanciaSanitaria { get; set; }
        public bool TaxaAlvaraPgto { get; set; }
        public bool EntregaTaxaAlvara { get; set; }
        public string? Fase { get; set; }
        public bool Ativo { get; set; }
        public byte[]? Arquivo { get; set; } 

        public string? NOME { get; set; }
        public string? CNPJ { get; set; }
        public string? CIDADE { get; set; }

        
        protected override string NomeTabela => "Tarefas";
        protected override string CampoCodigo => "Codigo";


        public void CreateTarefa (DbTarefa dbTarefa)
        {
            string query = @"
                                    INSERT INTO Tarefas
                                        (Empresa, Situacao, Obs, Dtregistro, Tipo, Bombeiro, VigilanciaSanitaria, TaxaAlvaraPgto, EntregaTaxaAlvara, Fase, Ativo, Arquivo)
                                    VALUES
                                        ( @Empresa, @Situacao, @Obs, @Dtregistro, @Tipo, @Bombeiro, @VigilanciaSanitaria, @TaxaAlvaraPgto, @EntregaTaxaAlvara, @Fase, @Ativo, @Arquivo)";

            Create(query, new
                {
                dbTarefa.Empresa,
                dbTarefa.Situacao,
                dbTarefa.Obs,
                dbTarefa.Dtregistro,
                dbTarefa.Tipo,
                dbTarefa.Bombeiro,
                dbTarefa.VigilanciaSanitaria,
                dbTarefa.TaxaAlvaraPgto,
                dbTarefa.EntregaTaxaAlvara,
                dbTarefa.Fase,
                dbTarefa.Ativo,
                dbTarefa.Arquivo
            });

        }

        public void UptadeTarefa(DbTarefa dbTarefa)
        {
            string query = @"
                                    UPDATE Tarefas
                                    SET
                                        Empresa = @Empresa,
                                        Situacao = @Situacao,
                                        Obs = @Obs,
                                        Tipo = @Tipo,
                                        Bombeiro = @Bombeiro,
                                        VigilanciaSanitaria = @VigilanciaSanitaria,
                                        TaxaAlvaraPgto = @TaxaAlvaraPgto,
                                        EntregaTaxaAlvara = @EntregaTaxaAlvara,
                                        Fase = @Fase,
                                        Ativo = @Ativo,
                                        Arquivo = @Arquivo
                                    WHERE Codigo = @Codigo";
            Update(query, new
            {
                dbTarefa.Codigo,
                dbTarefa.Empresa,
                dbTarefa.Situacao,
                dbTarefa.Obs,
                dbTarefa.Tipo,
                dbTarefa.Bombeiro,
                dbTarefa.VigilanciaSanitaria,
                dbTarefa.TaxaAlvaraPgto,
                dbTarefa.EntregaTaxaAlvara,
                dbTarefa.Fase,
                dbTarefa.Ativo,
                dbTarefa.Arquivo
            });

        }
        

        public void DeleteTarefa(int codigo)
        {
            Delete(codigo);
        }

      
        public DataTable ReadTarefaDT()
        {
            string query = @"
                                    SELECT 
                                        Tarefas.*, 
                                        vwEmpresas.Nome, 
                                        vwEmpresas.CNPJ, 
                                        vwEmpresas.Cidade
                                    FROM 
                                        Tarefas
                                    INNER JOIN 
                                        vwEmpresas
                                    ON 
                                        Tarefas.Empresa = vwEmpresas.EMPRESA";
            return ExecuteQueryDataTable(query);

        }
        public DbTarefa ReadTarefaByCodigo(int codigo)
        {
            string query = @"
                SELECT
                    Tarefas.*,
                    vwEmpresas.Nome,
                    vwEmpresas.CNPJ,
                    vwEmpresas.Cidade
                FROM
                    Tarefas
                INNER JOIN
                    vwEmpresas
                ON
                    Tarefas.Empresa = vwEmpresas.EMPRESA
                WHERE
                    Tarefas.Codigo = @Codigo";

            return ReadByCode(codigo, query);
        }


    }
}
