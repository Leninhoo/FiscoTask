using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySqlConnector;
using System.Data;
using System.Reflection;

namespace FiscoTask
{
    public class DbSocio : Dbase
    {

        public int ID { get; set; }
        public int? EMPRESA { get; set; }
        public string? CPF { get; set; }
        public string? RG { get; set; }
        public string? SOCIO { get; set; }
        public string? ENDERECO { get; set; }
        public string? BAIRRO { get; set; }
        public string? CEP { get; set; }
        public string? FONE { get; set; }
        public decimal? CAPITAL { get; set; }
        public string? FUNCAO { get; set; }
        public string? ASSINA { get; set; }
        public string? DATA_NASCIMENTO { get; set; }
        public string? DATA_ADMISSAO { get; set; }
        public string? DATA_DESLIGAMENTO { get; set; }
        public string? DT_ALT_SOC { get; set; }
        public string? DT_FIM_SOC { get; set; }
        public string? FUNDO_INVEST { get; set; }
        public double? PERC_CAP_VOT { get; set; }
        public string? CPF_REP_LEG { get; set; }
        public int? QUALIFICACAO { get; set; }
        public int? QUALIF_REP_LEG { get; set; }
        public double? DIST_LUCRO { get; set; }
        public double? IR { get; set; }
        public double? PRO_LABORE { get; set; }
        public byte[]? BIN_ASSINATURA { get; set; }
        public string? SIGNATARIO { get; set; }

        public string NOME { get; set; }
        public string CNPJ { get; set; }
        public string CIDADE { get; set; }


        public DataTable ReadSocio()
        {
            try
            {
                using (var connection = new MySqlConnection(stringconnection))
                {

                    string query = @"
                                    SELECT 
                                        SOCIOS.*,
                                        vwEmpresas.Nome, 
                                        vwEmpresas.CNPJ, 
                                        vwEmpresas.Cidade
                                    FROM 
                                        SOCIOS
                                    INNER JOIN 
                                        vwEmpresas
                                    ON 
                                        SOCIOS.EMPRESA = vwEmpresas.EMPRESA";

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
                MessageBox.Show(ex.Message);
                return new DataTable();

            }

        }

        public void InserirSociosNoBanco(List<DbSocio> socios)
        {
            try
            {
                using var connection = new MySqlConnection(stringconnection);
                connection.Open();

                connection.Execute("DELETE FROM SOCIOS");





                string sql = $@"INSERT INTO SOCIOS (
                                    EMPRESA,
                                    CPF,
                                    RG,
                                    SOCIO,
                                    ENDERECO,
                                    BAIRRO,
                                    CEP,
                                    FONE,
                                    CAPITAL,
                                    FUNCAO,
                                    ASSINA,
                                    DATA_NASCIMENTO,
                                    DATA_ADMISSAO,
                                    DATA_DESLIGAMENTO,
                                    DT_ALT_SOC,
                                    DT_FIM_SOC,
                                    FUNDO_INVEST,
                                    PERC_CAP_VOT,
                                    CPF_REP_LEG,
                                    QUALIFICACAO,
                                    QUALIF_REP_LEG,
                                    DIST_LUCRO,
                                    IR,
                                    PRO_LABORE,
                                    BIN_ASSINATURA,
                                    SIGNATARIO
                                )
                                VALUES (
                                    @EMPRESA,
                                    @CPF,
                                    @RG,
                                    @SOCIO,
                                    @ENDERECO,
                                    @BAIRRO,
                                    @CEP,
                                    @FONE,
                                    @CAPITAL,
                                    @FUNCAO,
                                    @ASSINA,
                                    @DATA_NASCIMENTO,
                                    @DATA_ADMISSAO,
                                    @DATA_DESLIGAMENTO,
                                    @DT_ALT_SOC,
                                    @DT_FIM_SOC,
                                    @FUNDO_INVEST,
                                    @PERC_CAP_VOT,
                                    @CPF_REP_LEG,
                                    @QUALIFICACAO,
                                    @QUALIF_REP_LEG,
                                    @DIST_LUCRO,
                                    @IR,
                                    @PRO_LABORE,
                                    @BIN_ASSINATURA,
                                    @SIGNATARIO
                                );
                                ";

                foreach (var socio in socios)
                {
                    connection.Execute(sql, socio);
                }

                MessageBox.Show("Empresas inseridas com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
