using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Reflection;

namespace FiscoTask
{
    
    public class Empresas : Dbase
    {


        #region Propriedades da tabela

        public int? EMPRESA { get; set; }
        public string? NOME { get; set; }
        public string? ENDERECO { get; set; }
        public string? BAIRRO { get; set; }
        public string? CIDADE { get; set; }
        public string? UF { get; set; }
        public string? CEP { get; set; }
        public string? FONE { get; set; }
        public string? CNPJ { get; set; }
        public string? IE { get; set; }
        public string? E_MAIL { get; set; }
        public string? CNAE { get; set; }
        public string? NATESTAB { get; set; }
        public string? RESPONSAVEL { get; set; }
        public string? CPF { get; set; }
        public DateTime? INI_ATIVIDADE { get; set; }
        public string? INDUSTRIA { get; set; }
        public string? COMERCIO { get; set; }
        public string? SERVICO { get; set; }
        public string? ENTIDADE { get; set; }
        public string? ESCOLA { get; set; }
        public string? REGIME { get; set; }
        public string? MICRO { get; set; }
        public string? PEQUENOPORTE { get; set; }
        public string? NENHUMA { get; set; }
        public string? ICMS { get; set; }
        public string? ISS { get; set; }
        public string? ICMS_ISS { get; set; }
        public int? CODIGOLIVRO { get; set; }
        public string? PROT1 { get; set; }
        public string? PROT2 { get; set; }
        public string? PROT3 { get; set; }
        public string? PROT4 { get; set; }
        public string? PROTGRPR { get; set; }
        public int? VEN_PROT1 { get; set; }
        public int? VEN_PROT2 { get; set; }
        public int? VEN_PROT3 { get; set; }
        public int? VEN_PROT4 { get; set; }
        public int? VEN_PROTGRPR { get; set; }
        public int? CODIGOCT { get; set; }
        public int? TABMUN { get; set; }
        public string? DDD { get; set; }
        public string? PRE_ESCOLA { get; set; }
        public string? NUMERO { get; set; }
        public string? COMPLEMENTO { get; set; }
        public string? FAX { get; set; }
        public string? REGISTROJUNTA { get; set; }
        public DateTime? DATAREGISTRO { get; set; }
        public string? SOCIEDADEANONIMA { get; set; }
        public string? ENCERRATRIMESTR { get; set; }
        public string? BALANCOSOCIAL { get; set; }
        public string? CLASSIFICACAO { get; set; }
        public string? ARREDONDASAL { get; set; }
        public int? NPROPRIETARIOS { get; set; }
        public int? SINDICATO { get; set; }
        public string? FPAS { get; set; }
        public decimal? PERCEMPRESA { get; set; }
        public string? CODSAT { get; set; }
        public decimal? PERCSAT { get; set; }
        public decimal? PERCFERIAS { get; set; }
        public decimal? CAPITAL { get; set; }
        public string? LEI9601 { get; set; }
        public string? HRSABINICIO { get; set; }
        public string? HRSABFINAL { get; set; }
        public string? HRSABDESCANSO { get; set; }
        public string? DATA1DECCAGED { get; set; }
        public string? ALTERENDERECO { get; set; }
        public string? DATAALTEREND { get; set; }
        public string? SIMPLESFOLHA { get; set; }
        public string? CODTERCEIROS { get; set; }
        public decimal? PERCTERCEIROS { get; set; }
        public DateTime? DATABAIXA { get; set; }
        public string? ENCERRATRIMESTRE { get; set; }
        public string? CONTADOR { get; set; }
        public string? REFLEXODSR { get; set; }
        public string? PGTO_SALARIO_MESMO_MES { get; set; }
        public string? IDENTIFICACAO_SINDICATO { get; set; }
        public string? DIRF { get; set; }
        public string? IPI { get; set; }
        public string? CMC { get; set; }
        public string? CONTADORCRC { get; set; }
        public string? CONTADORCAT { get; set; }
        public int? REGIMETRIBUTARIO { get; set; }
        public double? ESTOQUE12 { get; set; }
        public string? CUPOMFISCAL { get; set; }
        public string? SUBSTITUICAO { get; set; }
        public string? TRANSPORTADORA { get; set; }
        public string? SIMPLES { get; set; }
        public string? CONVENIO { get; set; }
        public string? CONT_PAGRECE { get; set; }
        public int? VCTOGRPR { get; set; }
        public string? TIPO_INSCRICAO { get; set; }
        public string? CONTROLAR_SF { get; set; }
        public string? PRIDECCAGED { get; set; }
        public string? NOMECONTADOR { get; set; }
        public string? IESUB { get; set; }
        public string? CPFCONTADOR { get; set; }
        public string? DESC_VT_DIAS_UTEIS { get; set; }
        public string? CLASS_CLIENTE { get; set; }
        public string? CLASS_FORNECEDOR { get; set; }
        public DateTime? VENCIMENTO_AIDF { get; set; }
        public string? TABMUNEST { get; set; }
        public string? CNAE1 { get; set; }
        public string? BASE_30_DIAS { get; set; }
        public string? REDUZ_ALIQ_IR { get; set; }
        public string? INTEGRA_CONTABILIDADE { get; set; }
        public string? DARF_MENSAL { get; set; }
        public string? REGIME_FED_2007 { get; set; }
        public string? COD_SEGURANCA { get; set; }
        public string? NOMEFANTASIA { get; set; }
        public string? COOPERATIVA { get; set; }
        public string? ATIVIDADE_SERVICO { get; set; }
        public decimal? VALORHONORARIO { get; set; }
        public decimal? MULTA { get; set; }
        public decimal? JUROS { get; set; }
        public decimal? DESCONTO { get; set; }
        public int? VENCIMENTO { get; set; }
        public string? VENC_MESMO_MES { get; set; }
        public decimal? CAPITALATUALIZADO { get; set; }
        public decimal? PERC_SALARIO_MINIMO { get; set; }
        public int? ROTA { get; set; }
        public string? COD_MUN_IBGE { get; set; }
        public int? BANCO_BOLETO { get; set; }
        public string? ECF { get; set; }
        public string? CONSTRUTORA { get; set; }
        public int? DIA_FECHA_PONTO { get; set; }
        public DateTime? CONTROLE_VT { get; set; }
        public string? TIPO_ISS { get; set; }
        public string? SENHA_INSS { get; set; }
        public string? QUALIFICACAO_PJ { get; set; }
        public string? IMPRIMIR_VT { get; set; }
        public DateTime? DATA_CONTRATO_CONTABIL { get; set; }
        public int? MES_REAJUSTE { get; set; }
        public int? ANO_REAJUSTADO { get; set; }
        public string? IND_PERFIL { get; set; }
        public string? SUFRAMA { get; set; }
        public string? CNES { get; set; }
        public string? RETER_ISS { get; set; }
        public string? PASSOU_PRODUTO { get; set; }
        public string? DSR_SOMENTE_DESCANSO { get; set; }
        public int? VERBA_CARPON_ATRASO { get; set; }
        public string? DESCONTAR_DSR_FALTA { get; set; }
        public string? DESCONTAR_DSR_ATRASO { get; set; }
        public int? VERBA_CARPON_FALTA { get; set; }
        public int? VERBA_CARPON_DSR { get; set; }
        public int? VERBA_CARPON_IJ { get; set; }
        public int? VERBA_CARPON_ADNOT { get; set; }
        public string? MARCAR_INTERVALOS { get; set; }
        public string? BANCO_DE_HORAS { get; set; }
        public int? DIA_FECHAMENTO_CP { get; set; }
        public string? PER_APURACAO_HE { get; set; }
        public string? INTERVALOS_ALTERNADOS { get; set; }
        public int? TOLERANCIA_ATRASO_MIN { get; set; }
        public int? TOLERANCIA_HE_MIN { get; set; }
        public TimeSpan? AD_NOT_INICIO { get; set; }
        public TimeSpan? AD_NOT_TERMINO { get; set; }
        public DateTime? BANCO_DE_HORAS_INICIO { get; set; }
        public int? BANCO_DE_HORAS_MESES_APUR { get; set; }
        public string? INFORMAR_INC_DARF { get; set; }
        public string? SO_HABILITADO { get; set; }
        public string? NAO_GERAR_SPED { get; set; }
        public string? NAO_USA_LIVRO { get; set; }
        public string? NAO_USA_FOLHA { get; set; }
        public string? NAO_USA_CONTABILIDADE { get; set; }
        public string? NAO_USA_ADMINISTRADOR { get; set; }
        public string? E_MAIL_SO { get; set; }
        public int? EMPRESA_OUTROS_SISTEMAS { get; set; }
        public string? COD_CONT_PREV_REC_BRU { get; set; }
        public string? SENHA_SITE_CONTABILIDADE { get; set; }
        public int? EMPRESA_CT { get; set; }
        public int? FILIAL_CT { get; set; }
        public DateTime? DATA_INTEGRAR_ON_LINE { get; set; }
        public string? SENHA_SITE { get; set; }
        public string? SMS_01 { get; set; }
        public string? SMS_02 { get; set; }
        public string? SENHA_SITE_FOLHA { get; set; }
        public string? CRED_IPI_PIS_COF { get; set; }
        public int? TABELA_NCM { get; set; }
        public DateTime? DATA_INTEGRAR_FP { get; set; }
        public string? INTEGRAR_FP_DPTO { get; set; }
        public string? TAB_NCM_ICMS { get; set; }
        public string? TAB_NCM_PIS_COF { get; set; }
        public string? AIDF_NUMERO { get; set; }
        public string? AIDF_ANO { get; set; }
        public DateTime? DATA_INTEGRAR_ON_LINE_FP { get; set; }
        public string? NAO_UTILIZA_PACOTEGUIAS { get; set; }
        public string? EPP_ME { get; set; }
        public string? IMPORTAR_FP_POR_DPTO { get; set; }
        public string? IMPORTAR_FP_SIMP { get; set; }
        public int? VERBA_CARPON_DSRDESCONTADO { get; set; }
        public string? CLASSTRIB { get; set; }
        public string? TP_COOPERATIVA { get; set; }
        public string? NR_PROCESSO_RAT { get; set; }
        public string? TP_PROCESSO_RAT { get; set; }
        public string? NR_PROCESSO_FAP { get; set; }
        public string? TP_PROCESSO_FAP { get; set; }
        public string? SIGLA_MIN { get; set; }
        public string? NR_CERTIF_ISE { get; set; }
        public DateTime? DATA_EMI_CERTIF { get; set; }
        public DateTime? VENC_CERTIF { get; set; }
        public string? NR_PROT_RENOV_CERT { get; set; }
        public DateTime? DT_PROT_RENOV_CERT { get; set; }
        public DateTime? DT_DIA_OF { get; set; }
        public string? PAG_DIA_OF { get; set; }
        public string? BANCO_DEPOSITO { get; set; }
        public string? AGENCIA_DEPOSITO { get; set; }
        public string? TP_CONTA_DEPOSITO { get; set; }
        public string? NR_CONTA_DEPOSITO { get; set; }
        public string? FINANC_FGTS { get; set; }
        public string? DEB_FGTS { get; set; }
        public string? AVISO_SMS { get; set; }
        public string? AGENDA_REC_FGTS { get; set; }
        public string? RECIBO_ESOCIAL { get; set; }
        public string? STATUS_ESOCIAL { get; set; }
        public string? SOCIO_OSTENSIVO { get; set; }
        public string? FUSAO { get; set; }
        public DateTime? DATA_FUSAO { get; set; }
        public string? MD5_1000 { get; set; }
        public string? IND_ATIV_FINAN { get; set; }
        public string? INI_MES_ANO_CRED_PIS { get; set; }
        public string? ICMS_TRANSP_LOGIN { get; set; }
        public string? ICMS_TRANSP_SENHA { get; set; }
        public string? ICMS_TRANSP_CODACESSO { get; set; }
        public string? ANEXO_VI { get; set; }
        public string? SEGURO_DESEMPREGO_LOGIN { get; set; }
        public string? SEGURO_DESEMPREGO_SENHA { get; set; }
        public DateTime? NASCIMENTO_RESP { get; set; }
        public string? DIA_VCTO_ICMS { get; set; }
        public string? REGISTRO_ELETRONICO { get; set; }
        public string? SIAFI { get; set; }
        public string? MULT_TAB_RUBRICAS { get; set; }
        public string? DESC_AMB_TRAB { get; set; }
        public string? PROCURADOR_FP { get; set; }
        public string? CPF_PROCURADOR_FP { get; set; }
        public DateTime? DATA_NASC_EMPREGADOR { get; set; }
        public string? COD_ESOCIAL_DOM { get; set; }
        public string? SEN_ESOCIAL_DOM { get; set; }
        public string? IMP_FOL_FUN { get; set; }
        public int? CONTA_MULTA_JUROS { get; set; }
        public DateTime? ENVIO_EVENTO_INICIAL { get; set; }
        public int? VERBA_CARPON_HENOT { get; set; }
        public int? VERBA_CARPON_DSR_FERIADO { get; set; }
        public string? EMISSOR_LIBERADO { get; set; }
        public string? ENT_EDUC { get; set; }
        public string? N_REG_EMP_TRAB_TEMP { get; set; }
        public string? COD_ECAC { get; set; }
        public string? SENHA_ECAC { get; set; }
        public string? SERIE_CERTIFICADO { get; set; }
        public string? SENHA_CERTIFICADO { get; set; }
        public string? CAIXA_ALTA_LV { get; set; }
        public string? IMP_NOME_CLI_FOR { get; set; }
        public DateTime? VENCIMENTO_CERTIFICADO { get; set; }
        public string? E_MAIL_2 { get; set; }
        public string? CAMINHO_CERTIFICADO { get; set; }
        public string? PREFIXO_E_SOCIAL { get; set; }
        public string? E_SOCIAL_PRODUCAO { get; set; }
        public string? REINF_PRODUCAO { get; set; }
        public string? TAB_DEPENDENTES_ONLINE { get; set; }
        public string? TAB_DEPENDENTES_ONLINE_URL { get; set; }
        public string? TAB_DEPENDENTES_ONLINE_MD5 { get; set; }
        public string? REINF_OBRIGADO { get; set; }
        public string? RETENCAO_CAIXA { get; set; }
        public string? CAEPF { get; set; }
        public string? GRUPO_E_SOCIAL { get; set; }
        public string? PORTE { get; set; }
        public string? IND_OBRIG_ENTREGAR_ECD { get; set; }
        public string? GERA_PARCELA_ENTRADA { get; set; }
        public string? LANCAR_FOLHA_DPTO { get; set; }
        public string? SOMA_PER_INS_ADIANTAMENTO { get; set; }
        public string? CREDITA_ST_ICMS { get; set; }
        public string? CLASSIFICACAO_INDUSTRIA { get; set; }
        public byte[]? OBSERVACAO { get; set; }
        public string? REP_LEGAL { get; set; }
        public string? TOKEN { get; set; }
        public string? SUSPENDE_FERIAS { get; set; }
        public string? SUSPENDE_13 { get; set; }
        public string? REDUZIDO_13 { get; set; }
        public string? LANCAR_ATESTADO { get; set; }
        public DateTime? EXCLUIR_ICMS_DO_PIS_COF { get; set; }
        public DateTime? API_ENVIO { get; set; }
        public DateTime? UPDATED_AT { get; set; }
        public string? API_ID { get; set; }
        public string? LGPD_FUNCIONARIO { get; set; }
        public string? EXCLUIR_ICMS_ENT { get; set; }
        public string? EXCLUIR_ICMS_SAI { get; set; }
        public DateTime? DATA_CHEGADA_ESCRITORIO { get; set; }
        public string? NIMBLY_APP { get; set; }
        public string? NIMBLY_CN { get; set; }
        public string? NIMBLY_HASH { get; set; }
        public string? NIMBLY_IDUSR { get; set; }
        public string? NIMBLY_USR { get; set; }
        public string? CNPJ_MATRIZ { get; set; }
        public DateTime? BH_SALDO_ANTERIOR { get; set; }
        public string? BH_HOLERITE { get; set; }
        public string? UPLOAD_TAREFA { get; set; }
        public int? PAR_INT_FIS { get; set; }
        public DateTime? SOMA_ICMSST_PIS_COF { get; set; }

        #endregion

        public void InserirEmpresasNoBanco(List<Empresas> empresas)
        {
            try
            {
                using var connection = new MySqlConnection(stringconnection);
                connection.Open();

                connection.Execute("DELETE FROM EMPRESA");

                var props = typeof(Empresas).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                            .Where(p => p.CanRead && p.CanWrite)
                                            .ToList();

                var campos = props.Select(p => p.Name).ToList();

                string camposInsert = string.Join(",", campos);
                string valoresInsert = string.Join(",", campos.Select(c => "@" + c));

                string sql = $@"INSERT INTO EMPRESA ({camposInsert}) VALUES ({valoresInsert});";

                foreach (var empresa in empresas)
                {
                    connection.Execute(sql, empresa);
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
