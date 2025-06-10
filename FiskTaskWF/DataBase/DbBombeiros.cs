using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Dapper;
using System.Data;

namespace FiscoTask
{
    public class DbBombeiros :Dbase
    {
        public int Id { get; set; }
        public int Livro { get; set; }
        public string? PROCESSO { get; set; }
        public string? OBS { get; set; }
        public string? DATA_REGISTRO { get; set; }

        public string? NOME { get; set; }
        public string? CNPJ { get; set; }
        public string? CIDADE { get; set; }

        public void CreateBombeiro (DbBombeiros bombeiro)
        {
            try
            {
                using(var connection = new MySqlConnection(stringconnection))
                {
                    string query = @"
                                    INSERT INTO Bombeiros
                                        (Livro, PROCESSO, OBS, DATA_REGISTRO)
                                    VALUES
                                        ( @Livro, @PROCESSO, @OBS, @DATA_REGISTRO)";

                    connection.Execute(query, new
                    {
                        bombeiro.Livro,
                        bombeiro.PROCESSO,
                        bombeiro.OBS,
                        bombeiro.DATA_REGISTRO
                    });
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir a Processo: {ex.Message}");
            }
        }

        public void UpdateBombeiro(DbBombeiros bombeiro)
        {
            try
            {
                using (var connection = new MySqlConnection(stringconnection))
                {
                    string query = @"
                                    UPDATE Bombeiros
                                    SET
                                        OBS = @OBS
                                    WHERE Id = @Id";

                    connection.Execute(query, new
                    {
                        bombeiro.Id,
                        bombeiro.Livro,
                        bombeiro.PROCESSO,
                        bombeiro.OBS,
                        bombeiro.DATA_REGISTRO
                    });
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar a Processo: {ex.Message}");
            }
        }

        public void DeleteBombeiro(int bombeiro)
        {
            try
            {
                using (var connection = new MySqlConnection(stringconnection))
                {
                 
                    string query = @"DELETE FROM Bombeiros WHERE Id = @Id";

                    connection.Execute(query, new { Id = bombeiro });
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao deletar a Processo: {ex.Message}");

            }
        }

        public DataTable ReadBombeiro()
        {
            try
            {
                using(var connection = new MySqlConnection(stringconnection))
                {
                    string query = @"
                                    SELECT 
                                        Bombeiros.*, 
                                        vwEmpresas.Nome, 
                                        vwEmpresas.CNPJ, 
                                        vwEmpresas.Cidade
                                    FROM 
                                        Bombeiros
                                    INNER JOIN 
                                        vwEmpresas
                                    ON 
                                        Bombeiros.Livro = vwEmpresas.EMPRESA";
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
