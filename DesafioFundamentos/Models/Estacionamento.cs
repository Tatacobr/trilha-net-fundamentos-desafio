namespace DesafioFundamentos.Models{
    public class Estacionamento{
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<Veiculo> veiculos = new List<Veiculo>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora){
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo(){
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            this.veiculos.Add(new Veiculo(Console.ReadLine().ToUpper(), DateTime.Now));
        }

        public void RemoverVeiculo(){
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine().ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.Placa == placa)){
                Veiculo veiculo = veiculos.Find(v => v.Placa == placa);

                TimeSpan aux = DateTime.Now.AddHours(40) - veiculo.Entrada;
                int horas = Convert.ToInt32(aux.TotalHours);
                decimal valorTotal = this.precoInicial + (this.precoPorHora * horas);

                Console.WriteLine($"Tempo total estacionado: {horas}");
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else{
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos(){
            // Verifica se há veículos no estacionamento
            if (veiculos.Any()){
                Console.WriteLine("Os veículos estacionados são:");
                veiculos.ForEach( v => {
                    Console.WriteLine($"Placa: {v.Placa} - Data: {v.Entrada.ToString("dd/MM/yyyy")} Horario: {v.Entrada.ToString("HH:mm")}");
                });

            }
            else{
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
