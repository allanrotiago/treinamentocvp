using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo
{
    public class Moto : Veiculos
    {
        public string TipoMotor { get; set; }
        public int Cilindrada { get; set; }

        public override decimal CalcularCustoLocacao(int dias)
        {
            decimal custoTotal = PrecoLocacaoDiaria * dias;
            return custoTotal;
        }
    }
}
