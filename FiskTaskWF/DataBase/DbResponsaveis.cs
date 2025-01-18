using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace FiscoTask
{
    public class DbResponsaveis : Dbase
    {
        public int LIVRO { get; set; }
        public string? ABERTURA { get; set; }
        public string? REGIME { get; set; }
        public string? RESPONSAVEL { get; set; }

        public string? NOME { get; set; }
        public string? CNPJ { get; set; }
        public string? CIDADE { get; set; }


        public DataTable ReadResponsaveis()
        {
            try
            {
                using (var connection = new MySqlConnection(stringconnection))
                {
                    string query = @"
                                    SELECT 
                                        Responsaveis.*, 
                                        vwEmpresas.Nome, 
                                        vwEmpresas.CNPJ, 
                                        vwEmpresas.Cidade
                                    FROM 
                                        Responsaveis
                                    INNER JOIN 
                                        vwEmpresas
                                    ON 
                                        Responsaveis.LIVRO = vwEmpresas.EMPRESA";

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
