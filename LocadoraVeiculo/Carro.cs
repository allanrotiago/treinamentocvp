using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo
{
    public class Carro : Veiculos
    {
        public int NumeroPortas { get; set; }  
        public int CapacidadePassageiros { get; set; }

        public override decimal CalcularCustoLocacao(int dias)
        {
            decimal custoTotal = PrecoLocacaoDiaria * dias;
            return custoTotal;
        }
    }
}
