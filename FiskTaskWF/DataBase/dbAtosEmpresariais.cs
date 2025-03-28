using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;
using Dapper;


namespace FiscoTask
{
    public class dbAtosEmpresariais : Dbase
    {

        public int ID { get; set; }
        public string? DATA { get; set; }
        public string? TIPO { get; set; }
        public string? RAZAO { get; set; }
        public string? CNPJ { get; set; }
        public string? LIVRO { get; set; }
        public string? ESCRITORIO { get; set; }
        public string? RESPONSAVEL_INTERNO { get; set; }
        public string? PROTOCOLO_EMPRESAFACIL { get; set; }
        public string? OBS { get; set; }

        public void UpdateInsertAtos(int id, string data, string tipo, string razao, string cnpj, string livro, string escritorio, 
            string responsavel_interno, string protocolo_empresafacil, string obs)
        {
            try
            {
                int _id = id;
                string _data = data;
                string _tipo = tipo;
                string _razao = razao;
                string _cnpj = cnpj;
                string _livro = livro;
                string _escritorio = escritorio;
                string _responsavel_interno = responsavel_interno;
                string _protocolo_empresafacil = protocolo_empresafacil;
                string _obs = obs;

                

                using (var connection = new MySqlConnection(stringconnection))
                {
                    string query = @"
                                    INSERT INTO AtosEmpresariais (ID, DATA, TIPO, RAZAO, CNPJ, LIVRO, ESCRITORIO, RESPONSAVEL_INTERNO, PROTOCOLO_EMPRESAFACIL, OBS)
                                    VALUES (@ID, @DATA, @TIPO, @RAZAO, @CNPJ, @LIVRO, @ESCRITORIO, @RESPONSAVEL_INTERNO, @PROTOCOLO_EMPRESAFACIL, @OBS)
                                    ON DUPLICATE KEY UPDATE
                                        DATA = VALUES(DATA),
                                        TIPO = VALUES(TIPO),
                                        RAZAO = VALUES(RAZAO),
                                        CNPJ = VALUES(CNPJ),
                                        LIVRO = VALUES(LIVRO),
                                        ESCRITORIO = VALUES(ESCRITORIO),
                                        RESPONSAVEL_INTERNO = VALUES(RESPONSAVEL_INTERNO),
                                        PROTOCOLO_EMPRESAFACIL = VALUES(PROTOCOLO_EMPRESAFACIL),
                                        OBS = VALUES(OBS);";

                    // Executa o comando SQL
                    connection.Execute(query, new {
                        ID = _id,
                        DATA = _data,
                        TIPO = _tipo,
                        RAZAO = _razao,
                        CNPJ = _cnpj,
                        LIVRO = _livro,
                        ESCRITORIO = _escritorio,
                        RESPONSAVEL_INTERNO = _responsavel_interno,
                        PROTOCOLO_EMPRESAFACIL = _protocolo_empresafacil,
                        OBS = _obs

                         });
                }

                MessageBox.Show("Ato empresarial salvo!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable ReadAtosEmpresariais()
        {
            try
            {
                using (var connection = new MySqlConnection(stringconnection))
                {
                    string query = @"SELECT * FROM AtosEmpresariais";

                    DataTable data = new DataTable();
                    using (var adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(data);

                    }

                    return data;

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Erro: {ex.Message}");
                return new DataTable();

            }

        }
        public DataTable PreencherComboBoxTipo()
        {
            try
            {
                using (var connection = new MySqlConnection(stringconnection))
                {
                    string query = @"SELECT DISTINCT TIPO FROM AtosEmpresariais";

                    DataTable data = new DataTable();
                    using (var adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(data);

                    }

                    return data;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                return new DataTable();

            }

        }

        public DataTable PreencherComboBoxEscritorio()
        {
            try
            {
                using (var connection = new MySqlConnection(stringconnection))
                {
                    string query = @"SELECT DISTINCT ESCRITORIO FROM AtosEmpresariais";

                    DataTable data = new DataTable();
                    using (var adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(data);

                    }

                    return data;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                return new DataTable();

            }

        }

        public DataTable PreencherComboBoxResponsavel()
        {
            try
            {
                using (var connection = new MySqlConnection(stringconnection))
                {
                    string query = @"SELECT DISTINCT RESPONSAVEL_INTERNO FROM AtosEmpresariais";

                    DataTable data = new DataTable();
                    using (var adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(data);

                    }

                    return data;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                return new DataTable();

            }

        }

        public void DeleteAtos(int ID)
        {
            try
            {
                using (var connection = new MySqlConnection(stringconnection))
                {
                    string query = @"DELETE FROM AtosEmpresariais WHERE ID = @ID";

                    connection.Execute(query, new { ID = ID });

                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir Tarefa: {ex.Message}");
            }
        }
    }
}
