using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gerenciador_de_Boletos.Quantidade___boletos
{
    internal abstract class Abstract_Contagem
    {
        protected abstract int Contagem_Boletos(int Numero);
        protected virtual int Contagem_Boletos() { return 0; }
    }
}
