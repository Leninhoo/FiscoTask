using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscoTask
{
    internal class DbTarefa : Dbase
    {
        public BindingList<DbTarefa> BdTarefas { get; set; } = new BindingList<DbTarefa>();
        public int Codigo { get; set; }
        public int Empresa { get; set; }
        public string Situacao { get; set; }
        public string Obs { get; set; }
        public string Dtregistro { get; set; }
        public string Tipo { get; set; }

        public void CreateTarefa (DbTarefa dbTarefa)
        {

        }

        public void UptadeTarefa(DbTarefa dbTarefa)
        {

        }

        public void DeleteTarefa(DbTarefa dbTarefa)
        {

        }

        public BindingList<DbTarefa> ReadTarefa(DbTarefa dbTarefa)
        {
            return BdTarefas;
        }

    }
}
