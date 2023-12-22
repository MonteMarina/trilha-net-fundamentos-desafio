namespace DesafioFundamentos.Models
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
            Console.WriteLine("Olá, digite a placa do veículo para estacionar:");

            string placa = Console.ReadLine();

            // aqui quis limitar a quantidade de caracteres de acordo com a quantidade de caracteres das placas do Brasil.
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

            string placa = Console.ReadLine();

            if (veiculos.Contains(placa))
            {
                veiculos.Remove(placa);

                Console.WriteLine($"Veículo com placa {placa} removido com sucesso!");

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                if (int.TryParse(Console.ReadLine(), out int horas))
                {
                    decimal valorTotal = precoInicial + (precoPorHora * horas);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
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