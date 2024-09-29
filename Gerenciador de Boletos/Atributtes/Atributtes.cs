using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Boletos.Atributtes
{
    internal class Atributtes
    {
        public int Id { get; set; }
        public DateOnly Data_Vencimento { get; set; }
        public string? Descricao {  get; set; }
        public string path_io { get; set; }
        public Status Status_Boleto { get; set; }
        public Prioridade Prioridade_Boleto { get; set; }
    }

    public enum Status {Pago, Pendente, Vencido }

    public enum Prioridade {Alta, Media, Baixa }
}
