using System;
using System.Collections.Generic;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal PrecoInicial = 0;
        private decimal PrecoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Olá, digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine().ToUpper();

            if (placa.Length == 7)
            {
                veiculos.Add(placa);
                Console.WriteLine($"Veículo com a placa {placa} adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Placa digitada incorretamente, tente novamente");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine().ToUpper();

            if (veiculos.Contains(placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a quantidade de minutos que o veículo permaneceu estacionado:");
                int minutos = Convert.ToInt32(Console.ReadLine());

                if ((minutos <= 60 && horas == 0) || (minutos == 0 && horas == 1))
                {
                    Console.WriteLine($"Veículo com placa {placa} removido com sucesso! e o preço foi: R${PrecoInicial:F2}");
                }
                else if (horas >= 1 && minutos >= 1)
                {
                    decimal valorCobrado = PrecoInicial + (horas * PrecoPorHora);
                    Console.WriteLine($"Valor cobrado pelo veículo de placa {placa}: R${valorCobrado:F2}");
                }
                else if (horas > 1 && minutos == 0)
                {
                    decimal valorCobrado = PrecoInicial + (horas - 1) * PrecoPorHora;
                    Console.WriteLine($"Valor cobrado pelo veículo de placa {placa}: R${valorCobrado:F2}");
                }

                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine($"O veículo de placa {placa} não está estacionado.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
