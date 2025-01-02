using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscoTask
{
    public class DbDocType : Dbase
    {
        public BindingList<DbDocType> BDdoctype { get; set; } = new BindingList<DbDocType>();
        public string? TIPO { get; set; }



        public BindingList<DbDocType> ReadType()
        {
            try
            {
                using (var connection = new MySqlConnection(stringconnection))
                {
                    string query = @"SELECT * FROM DocType";


                    var doctypes = connection.Query<DbDocType>(query).ToList();
                    BDdoctype.Clear();
                    foreach (var doctype in doctypes)
                    {
                        BDdoctype.Add(doctype);
                    }

                    return BDdoctype;
                }

            }
            catch (Exception ex)
            {
                return new BindingList<DbDocType>();
            }

        }



    }
}
