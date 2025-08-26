using DevExpress.CodeParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscoTask.Models
{
    public class ListasComboBox
    {
        public List<string> Fase()
        {
            List<string> fases = new List<string>
            {
                "Aguardando terceiro",
                "Pendêcia empresa",
                "Para avaliar",
                "Solicitar Vigilância",
                "Aguardando redação do PGPCD",
                "Fazer redação do PGPCD",
                "Encaminhar para vigilância",
                "Vigilância solicitada",
                "Solicitar Bombeiro",
                "Aguardando pagamento bombeiro",
                "Aguardando baixa bombeiro",
                "Aguardando prefeitura",
                "Emissão taxa de alvará",
                "Ag.pagamento taxa de alvará",
                "Solicitar alvará",
                "Ag.prefeitura emitir alvará",
                "Pegar alvará físico na prefeitura",
                "Baixa de empresa",
                "Pronto"


            };

            return fases;
        }

        public List<string> Situacao()
        {
            List<string> situacoes = new List<string>
            {
                "Em andamento",
                "Encerrado",
                "Suspenso"
            };

            return situacoes;
        }


    }
}
