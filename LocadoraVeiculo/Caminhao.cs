using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo
{
    public class Caminhao : Veiculos
    {
        public decimal CapacidadeCarga {  get; set; }

        public override decimal CalcularCustoLocacao(int dias)
        {
            decimal custoTotal = PrecoLocacaoDiaria * dias;
            return custoTotal;
        }
    }
}
