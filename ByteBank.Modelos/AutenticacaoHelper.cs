using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    //Essa classe pertence somente a biblioteca, por tanto só será vista por membros da biblioteca.
    //Projetos externos não conseguirão vê-la.
    //Para ela ter as características citadas acima, a palavra internal deve ser utilizada como seu modificador de acesso.
    //Obs: Se nenhum modificador for escrito para a classe, ela atribuí o internal como padrão.
    //internal class AutenticacaoHelper
    
    class AutenticacaoHelper
    {
        public bool CompararaSenhas(string senhaVerdadeira, string senhaTentativa) 
        {
            return senhaVerdadeira == senhaTentativa;
        }
    }
}
