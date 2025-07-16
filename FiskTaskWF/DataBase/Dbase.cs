using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Dapper;
using MySqlConnector;
using System.Configuration;



namespace FiscoTask
{
    public class Dbase 
    {
        
        public static readonly string? stringconnection;

        static Dbase()
        {
            stringconnection = ConfigurationManager.ConnectionStrings["MinhaConexaoBD"]?.ConnectionString;

            if (string.IsNullOrEmpty(stringconnection))
            {
                System.Windows.Forms.MessageBox.Show("A string de conexão não está configurada corretamente.", "Erro de Conexão", System.Windows.Forms.MessageBoxButtons.OK);
                return;
            }
        }
        public Dbase() 
        {



        }

    }
}
