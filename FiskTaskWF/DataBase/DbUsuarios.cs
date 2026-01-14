using System;
using System.Collections.Generic;
using System.Text;

namespace FiscoTask.DataBase
{
    internal class DbUsuarios : BancoDados<DbUsuarios>
    {

        protected override string NomeTabela => "Usuarios";
        protected override string CampoCodigo => "Id";

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public int NivelAcesso { get; set; }




    }
}
