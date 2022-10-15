using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do véiculo para remover:");
            string placa = Console.ReadLine();
            

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estaciconado:");
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = 0;
                valorTotal = precoInicial+precoPorHora*horas;
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo{placa} foi removido e o preço total foi de: {valorTotal} R$");
            }
            else
            {
                Console.WriteLine("Não temos registro da placa digitada. Favor verificar se digitou corretamente");
            }
        } 
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            //implementar laço de repetição para listar as
            {
                foreach (var placas in veiculos)
                {
                Console.WriteLine($"Os veículos estacionados são: {placas}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos neste estacionamento");
            }
        }

           
    }
}