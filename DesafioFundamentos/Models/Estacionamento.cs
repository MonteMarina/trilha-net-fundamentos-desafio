<<<<<<< HEAD
using System;
using System.Collections.Generic;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal PrecoInicial = 0;
        private decimal PrecoPorHora = 0;
=======
amespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private decimal precoMinutos = 0;
>>>>>>> 11827b76bc4b35dc2e5dd8f0d23abd37ef8142e3
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora, decimal precoMinutos)
        {
<<<<<<< HEAD
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
=======
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            this.precoMinutos = precoMinutos;
>>>>>>> 11827b76bc4b35dc2e5dd8f0d23abd37ef8142e3
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Olá, digite a placa do veículo para estacionar:");
<<<<<<< HEAD
            string placa = Console.ReadLine().ToUpper();

            if (veiculos.Contains(placa))
            {
                Console.WriteLine($"Veículo com a placa {placa} já cadastrado.");
                return;
            }

=======

            string placa = Console.ReadLine();

            // aqui quis limitar a quantidade de caracteres de acordo com a quantidade de caracteres das placas do Brasil.
>>>>>>> 11827b76bc4b35dc2e5dd8f0d23abd37ef8142e3
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

<<<<<<< HEAD
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
=======
    string placa = Console.ReadLine();

    if (veiculos.Contains(placa))
    {
        veiculos.Remove(placa);

        Console.WriteLine($"Veículo com placa {placa} removido com sucesso!");

        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

        if (int.TryParse(Console.ReadLine(), out int horas))
        {
            Console.WriteLine("Agora, digite a quantidade de minutos:");

            if (int.TryParse(Console.ReadLine(), out int minutos))
            {
                decimal valorTotal = precoInicial + (precoPorHora * horas + (precoPorHora / 60) * minutos);
>>>>>>> 11827b76bc4b35dc2e5dd8f0d23abd37ef8142e3

                veiculos.Remove(placa);
            }
            else
            {
<<<<<<< HEAD
                Console.WriteLine($"O veículo de placa {placa} não está estacionado.");
=======
                Console.WriteLine("Quantidade de minutos inválida. Certifique-se de inserir um número válido.");
>>>>>>> 11827b76bc4b35dc2e5dd8f0d23abd37ef8142e3
            }
        }
        else
        {
            Console.WriteLine("Quantidade de horas inválida. Certifique-se de inserir um número válido.");
        }
    }
    else
    {
        Console.WriteLine($"Veículo com placa {placa} não encontrado no estacionamento.");
    }
}
    
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
<<<<<<< HEAD
=======

>>>>>>> 11827b76bc4b35dc2e5dd8f0d23abd37ef8142e3
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

