using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySqlConnector;
using System.Data;

namespace FiscoTask
{
    public class dbNotas : Dbase
    {
        public int LIVRO { get; set; }
        public string? NOTAS { get; set; }

        public string NOME { get; set; }
        public string CNPJ { get; set; }
        public string CIDADE { get; set; }

        public void UpdateInsertNotas(int livros, string notas)
        {
            try
            {
                int livro = livros; // Obtém o valor do LIVRO do TextBox
                string nota = notas;        // Obtém o valor das NOTAS do RichTextBox

                using (var connection = new MySqlConnection(stringconnection))
                {
                    string query = @"
                INSERT INTO NOTES (LIVRO, NOTAS)
                VALUES (@LIVRO, @NOTAS)
                ON DUPLICATE KEY UPDATE
                    NOTAS = VALUES(NOTAS);";

                    // Executa o comando SQL
                    connection.Execute(query, new { LIVRO = livro, NOTAS = notas });
                }

                MessageBox.Show("Nota salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable ReadNota()
        {
            try
            {
                using(var connection = new MySqlConnection(stringconnection))
                {
                    string query = @"
                                    SELECT 
                                        NOTES.*, 
                                        vwEmpresas.Nome, 
                                        vwEmpresas.CNPJ, 
                                        vwEmpresas.Cidade
                                    FROM 
                                        NOTES
                                    INNER JOIN 
                                        vwEmpresas
                                    ON 
                                        NOTES.LIVRO = vwEmpresas.EMPRESA";
                    DataTable dt = new DataTable();
                    using (var adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dt);
                    }
                    return dt;
                }
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }
    }
}
