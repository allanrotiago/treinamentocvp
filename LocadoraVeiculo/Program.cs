namespace LocadoraVeiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro
            {
                Modelo = "Fusca",
                AnoFabricacao = 1979,
                CapacidadePassageiros = 4,
                NumeroPortas = 2,
                PrecoLocacaoDiaria = 100
            };

            Moto moto = new Moto
            { 
                Modelo = "CG 150",
                AnoFabricacao = 2000,
                Cilindrada = 150,
                TipoMotor = "4 tempos",
                PrecoLocacaoDiaria = 50

            };

            Caminhao caminhao = new Caminhao
            {
                Modelo = "Ford Cargo",
                AnoFabricacao = 2010,
                CapacidadeCarga = 200,
                PrecoLocacaoDiaria = 300
            };

            Console.WriteLine($"Custo de locacao para carro: Modelo {carro.Modelo}; Preço Diária: {carro.PrecoLocacaoDiaria}; Valor Total: {carro.CalcularCustoLocacao(4)} ");
            Console.WriteLine($"Custo de locacao para moto: Modelo {moto.Modelo}; Preço Diária: {moto.PrecoLocacaoDiaria}; Valor Total: {moto.CalcularCustoLocacao(5)} ");
            Console.WriteLine($"Custo de locacao para caminhão: Modelo {caminhao.Modelo}; Preço Diária: {caminhao.PrecoLocacaoDiaria}; Valor Total: {caminhao.CalcularCustoLocacao(7)} ");
        }
    }
}
