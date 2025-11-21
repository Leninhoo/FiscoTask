using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySqlConnector;
using Dapper;
using System.Data;


namespace FiscoTask.DataBase
{
    public abstract class BancoDados<T> where T : class
    {
        protected static readonly string? stringConnection;
        static BancoDados()
        {
            stringConnection = ConfigurationManager.ConnectionStrings["MinhaConexaoBD"]?.ConnectionString;
            if (string.IsNullOrEmpty(stringConnection))
            {
                System.Windows.Forms.MessageBox.Show("A string de conexão não está configurada corretamente.", "Erro de Conexão", System.Windows.Forms.MessageBoxButtons.OK);
                return;
            }
        }

        // Propriedades abstratas que as classes filhas DEVEM implementar
        protected abstract string NomeTabela { get; }
        protected abstract string CampoCodigo { get; }


        public virtual void Create(string query, object parametros)
        {
            try
            {
                using (var connection = new MySqlConnection(stringConnection))
                {
                    connection.Execute(query, parametros);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Erro ao criar registro: {ex.Message}", "Erro", System.Windows.Forms.MessageBoxButtons.OK);
            }
        }

        public virtual void Update(string query, object parametros)
        {
            try
            {
                using (var connection = new MySqlConnection(stringConnection))
                {
                    connection.Execute(query, parametros);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar {NomeTabela}: {ex.Message}", ex);
            }
        }

        public virtual void Delete(int codigo)
        {
            try
            {
                using (var connection = new MySqlConnection(stringConnection))
                {
                    string query = $"DELETE FROM {NomeTabela} WHERE {CampoCodigo} = @Codigo";
                    connection.Execute(query, new { Codigo = codigo });
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir de {NomeTabela}: {ex.Message}", ex);
            }
        }

        public virtual T GetByCodigo(int codigo)
        {
            try
            {
                using (var connection = new MySqlConnection(stringConnection))
                {
                    string query = $"SELECT * FROM {NomeTabela} WHERE {CampoCodigo} = @Codigo";
                    return connection.QueryFirstOrDefault<T>(query, new { Codigo = codigo });
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar em {NomeTabela}: {ex.Message}", ex);
            }
        }

        public virtual List<T> GetAll()
        {
            try
            {
                using (var connection = new MySqlConnection(stringConnection))
                {
                    string query = $"SELECT * FROM {NomeTabela}";
                    return connection.Query<T>(query).AsList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar todos de {NomeTabela}: {ex.Message}", ex);
            }
        }

        /// Método genérico para executar queries personalizadas que retornam dados
        protected List<T> ExecuteQuery(string query, object parametros = null)
        {
            try
            {
                using (var connection = new MySqlConnection(stringConnection))
                {
                    return connection.Query<T>(query, parametros).AsList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar query: {ex.Message}", ex);
            }
        }

        //Método para retornar DataTable (útil para DataGridView)
        protected DataTable ExecuteQueryDataTable(string query, object parametros = null)
        {
            try
            {
                using (var connection = new MySqlConnection(stringConnection))
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        if (parametros != null)
                        {
                            var propriedades = parametros.GetType().GetProperties();
                            foreach (var prop in propriedades)
                            {
                                command.Parameters.AddWithValue($"@{prop.Name}", prop.GetValue(parametros));
                            }
                        }

                        DataTable dataTable = new DataTable();
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar query DataTable: {ex.Message}", ex);
            }
        }


        //Método para executar comandos sem retorno (INSERT, UPDATE, DELETE personalizados)
        protected int ExecuteCommand(string query, object parametros = null)
        {
            try
            {
                using (var connection = new MySqlConnection(stringConnection))
                {
                    return connection.Execute(query, parametros);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar comando: {ex.Message}", ex);
            }
        }


    }
}
    

