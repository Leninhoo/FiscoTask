using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using FiscoTask;
using System.ComponentModel;
using MySqlConnector;
using System.Data;

namespace FiscoTask
{
    public class DbDocuments : Dbase
    {
        public BindingList<DbDocuments> BDDocuments { get; set; }  = new BindingList<DbDocuments>();
        public int IdDoc { get; set; }
        public int Livro { get; set; }
        public string? DtRegistro { get; set; }
        public DateTime Vencimentodoc { get; set; }
        public string? Obs { get; set; }
        public string? Tipo { get; set; }
        public string? Exercicio { get; set; }
        public string? Link { get; set; }
        public int Soli_atua { get; set; }

        public string? NOME { get; set; }
        public string? CNPJ { get; set; }
        public string? CIDADE { get; set; }




        public void CreateDoc(DbDocuments doc)
        {
            try
            {
                using (var connection = new MySqlConnection(stringconnection))
                {
                    string query = @"
                                    INSERT INTO DOC
                                        (Livro, DtRegistro, Vencimentodoc, Obs, Tipo)
                                    VALUES
                                        (@Livro, @DtRegistro, @Vencimentodoc, @Obs, @Tipo)";

                    connection.Execute(query, new
                    {
                        doc.Livro,
                        doc.DtRegistro,
                        doc.Vencimentodoc,
                        doc.Obs,
                        doc.Tipo,

                    });
                    
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir documento: {ex.Message}");
            }

        }

        public void UpdateDoc(DbDocuments doc)
        {
            try
            {
                using (var connection = new MySqlConnection(stringconnection))
                {
                    string query = @"
                                    UPDATE DOC
                                    SET
                                        Livro = @Livro,
                                        Vencimentodoc = @Vencimentodoc,
                                        Obs = @Obs,
                                        Tipo = @Tipo
                                    WHERE IdDoc = @IdDoc";

                    connection.Execute(query, new
                    {
                        doc.Livro,
                        doc.Vencimentodoc,
                        doc.Obs,
                        doc.Tipo,
                        doc.IdDoc

                    });

                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Atualizar documento: {ex.Message}");
            }

        }

        public void DeleteDoc(int idDoc)
        {
            try
            {
                using (var connection = new MySqlConnection(stringconnection))
                {
                    string query = @"DELETE FROM DOC WHERE IdDoc = @IdDoc";

                    connection.Execute(query, new { IdDoc = idDoc });

                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir documento: {ex.Message}");
            }

        }

        public BindingList<DbDocuments> ReadDoc()
        {
            try
            {
                using (var connection = new MySqlConnection(stringconnection))
                {
                    string query = @"
                                    SELECT 
                                        DOC.*, 
                                        vwEmpresas.Nome, 
                                        vwEmpresas.CNPJ, 
                                        vwEmpresas.Cidade
                                    FROM 
                                        DOC
                                    INNER JOIN 
                                        vwEmpresas
                                    ON 
                                        DOC.Livro = vwEmpresas.EMPRESA";

                    var documentos = connection.Query<DbDocuments>(query).ToList();
                    BDDocuments.Clear();
                    foreach (var documento in documentos)
                    {
                        BDDocuments.Add(documento);
                    }

                    return BDDocuments;
                }

            }
            catch (Exception ex)
            {
                return new BindingList<DbDocuments>();
            }

        }

        public DataTable ReadDocDT()
        {
            try
            {
                using (var connection = new MySqlConnection(stringconnection))
                {
                    string query = @"
                                    SELECT 
                                        DOC.*, 
                                        vwEmpresas.Nome, 
                                        vwEmpresas.CNPJ, 
                                        vwEmpresas.Cidade
                                    FROM 
                                        DOC
                                    INNER JOIN 
                                        vwEmpresas
                                    ON 
                                        DOC.Livro = vwEmpresas.EMPRESA";

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
