using Dapper;
using MySqlConnector;
using System;
using System.IO;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Runtime.InteropServices;
using System.Data.Odbc;
using System.Linq;
using System.Globalization;
using System.Text;
using FiscoTask.DataBase;

namespace FiscoTask.Views
{
    public partial class UpdateDataBase : Form
    {
        public UpdateDataBase()
        {
            InitializeComponent();
        }



        Empresas empresas = new Empresas();
        DbSocio socio = new DbSocio();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            rtbLog.Text = ConexaoFDB();
        }

        public string ConexaoFDB()
        {
            string connectionString = @"ServerType=1;User=SYSDBA;Password=masterkey;Database=C:\Programing\Banco de dados\Fisconorte\CADASTRO.FDB;Dialect=3;Charset=NONE;";
            string? resultado;
            using (FbConnection connection = new FbConnection(connectionString))
            {
                try
                {

                    connection.Open();
                    resultado = "Conectado ao banco de dados com sucesso!";
                    connection.Close();
                }
                catch (FbException fbEx)
                {
                    resultado = $"Erro Firebird: {fbEx.Message}\n";
                    resultado += $"Código do Erro: {fbEx.ErrorCode}\n";
                    resultado += $"Stack Trace: {fbEx.StackTrace}\n";
                    if (fbEx.InnerException != null)
                        resultado += $"Inner Exception: {fbEx.InnerException.Message}\n";
                }
                catch (Exception ex)
                {
                    resultado = $"Erro Geral: {ex.Message}\n";
                    resultado += $"Stack Trace: {ex.StackTrace}\n";

                }

                return resultado;
            }

        }

        private void btnAtualizarBanco_Click(object sender, EventArgs e)
        {
            var firebird = new DbFirebird();
            var empresasFirebird = firebird.BuscarEmpresasDoFirebird(txtCaminho.Text);
            empresas.InserirEmpresasNoBanco(empresasFirebird);

            var sociosFirebird = firebird.BuscarSociosDoFirebird(txtCaminho.Text);
            socio.InserirSociosNoBanco(sociosFirebird);
        }



        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Selecione o arquivo de banco de dados";
            file.Multiselect = false;
            file.Filter = "Banco de Dados (*.fdb)|*.fdb";


            if (file.ShowDialog() == DialogResult.OK)
            {
                txtCaminho.Text = file.FileName;
            }



        }
    }
}
