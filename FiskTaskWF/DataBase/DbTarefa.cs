using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Dapper;
using System.Data;

namespace FiscoTask
{
    public class DbTarefa : Dbase
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

        public string NOME { get; set; }
        public string CNPJ { get; set; }
        public string CIDADE { get; set; }

        



        public void CreateTarefa (DbTarefa dbTarefa)
        {
            try
            {
                using (var connection = new MySqlConnection(stringconnection))
                {
                    string query = @"
                                    INSERT INTO Tarefas
                                        (Empresa, Situacao, Obs, Dtregistro, Tipo, Bombeiro, VigilanciaSanitaria, TaxaAlvaraPgto, EntregaTaxaAlvara)
                                    VALUES
                                        ( @Empresa, @Situacao, @Obs, @Dtregistro, @Tipo, @Bombeiro, @VigilanciaSanitaria, @TaxaAlvaraPgto, @EntregaTaxaAlvara)";

                    connection.Execute(query, new
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

                    });

                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir Tarefa: {ex.Message}");
            }
        }

        public void UptadeTarefa(DbTarefa dbTarefa)
        {
            try
            {
                using (var connection = new MySqlConnection(stringconnection))
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
                                        EntregaTaxaAlvara = @EntregaTaxaAlvara
                                    WHERE Codigo = @Codigo";

                    connection.Execute(query, new
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

                    });

                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Atualizar Tarefa: {ex.Message}");
            }

        }
        

        public void DeleteTarefa(int codigo)
        {
            try
            {
                using (var connection = new MySqlConnection(stringconnection))
                {
                    string query = @"DELETE FROM Tarefas WHERE Codigo = @Codigo";

                    connection.Execute(query, new { Codigo = codigo });

                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir Tarefa: {ex.Message}");
            }
        }

      
        public DataTable ReadTarefaDT()
        {
            try
            {
                using (var connection = new MySqlConnection(stringconnection))
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

                    DataTable data = new DataTable();
                    using (var adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(data);
                        
                    }

                    return data;

                }
            }
            catch
            {
                return new DataTable();

            }

        }

    }
}
