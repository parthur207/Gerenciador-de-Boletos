using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Boletos.DB.IFuncions_db
{
    internal interface IDirectory_db
    {

        void Query_All_db() { }

        void Query_Not_Pagos_db() { }

        void Query_Pagos_db() { }

        void Query_Expirados_db() { }


        void Delete_Boleto_db() { }

        void Delete_Expirados_db() { }

        void Delete_All_db() { }

        void Delete_Pagos_db() {  }

        void Update_Boleto_db() { }

    }
}
