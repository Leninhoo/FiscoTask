using System;
using System.Collections.Generic;
using System.Text;

namespace FiscoTask.DataBase
{
    public  class DbNovosAtosEmpresariais : BancoDados<DbNovosAtosEmpresariais>
    {




        public int Id { get; set; }
        public string? Empresario { get; set; }
        public string? CpfEmpresario { get; set; }
        public string? CNPJ { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataModificacao { get; set; }
        public byte[]? ArquivoComentarios { get; set; }
        public string? NomePretendidoEmpresa { get; set; }
        public string? Fase { get; set; }
        public string? Situacao { get; set; }
        public string? TipoAtoEmpresarial { get; set; }


        protected override string NomeTabela => "NovosAtosEmpresariais";
        protected override string CampoCodigo => "Id";
    }
}
