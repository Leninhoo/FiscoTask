using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Dapper;
using System.ComponentModel;
using System.Data;

namespace FiscoTask
{
    public class EmpresaView : Dbase
    {
        public BindingList<EmpresaView> BDEmpresas { get; set; } = new BindingList<EmpresaView>();
        public int? EMPRESA { get; set; }           // ID único ou identificador da empresa
        public string? NOME { get; set; }          // Razão social ou nome completo
        public string? CNPJ { get; set; }          // Cadastro Nacional da Pessoa Jurídica
        public string? NOMEFANTASIA { get; set; }  // Nome fantasia da empresa
        public string? ENDERECO { get; set; }      // Logradouro
        public string? NUMERO { get; set; }        // Número do endereço
        public string? BAIRRO { get; set; }        // Bairro
        public string? COMPLEMENTO { get; set; }   // Complemento do endereço
        public string? CIDADE { get; set; }        // Cidade
        public string? UF { get; set; }            // Unidade Federativa (estado)
        public string? CEP { get; set; }           // Código Postal
        public string? REGIME { get; set; }        // Regime tributário da empresa
        public string? E_MAIL { get; set; }        // E-mail de contato
        public string? FONE { get; set; }          // Telefone de contato
        public string? RESPONSAVEL { get; set; }   // Nome do responsável
        public string? IE { get; set; }            // Inscrição Estadual

        public BindingList<EmpresaView> ListEmpresas()
        {

            try
            {

                using (var connection = new MySqlConnection(stringconnection))
                {
                    var empresas = connection.Query<EmpresaView>("select * from vwEmpresas");
                    BDEmpresas.Clear();
                    foreach (var empresa in empresas)
                    {
                        BDEmpresas.Add(empresa);
                    }

                    return BDEmpresas;

                }

            }
            catch (Exception ex)
            {                
                MessageBox.Show($"Erro ao listar empresas: {ex.Message}");
                return new BindingList<EmpresaView>();
            }
        }

        public DataTable ReadEmpresasDT()
        {
            try
            {
                using (var connection = new MySqlConnection(stringconnection))
                {
                    string query = "select * from vwEmpresas";

                    DataTable data = new DataTable();

                    using(var adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(data);
                    }

                    return data;
                }

            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }



    }
}

