using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculo
{
    public abstract class Veiculos
    {
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public decimal PrecoLocacaoDiaria { get; set; }

        public abstract decimal CalcularCustoLocacao(int dias);

    }
}
