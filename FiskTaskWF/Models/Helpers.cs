using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscoTask.Models
{
    public class Helpers
    {

        public static string FormatarCNPJs(string cnpj)
        {
            string limpo = cnpj.Replace(".", "").Replace("/", "").Replace("-", "").Trim();
            return limpo;
        }


    }
}
