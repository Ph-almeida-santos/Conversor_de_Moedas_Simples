namespace ConversorDeMoedas.Service
{
    public class ExibirMoeda
    {
        public void ExibirMoedaETaxa(Dictionary<string, double> todasMoedas)
        {
            Console.Clear();
            Console.WriteLine($"Moedas disponíveis para conversão -- Moeda base sobre as taxas -> Libra Esterlina (GBP):");
            foreach (var moeda in todasMoedas!)
            {
                Console.WriteLine($"{moeda.Key}: {moeda.Value}");
            }
            Console.WriteLine();
            Console.Write("Aperte 'enter' para voltar ao menu principal");
            Console.ReadLine();
            Console.Clear();
        }
        public void ExibirResultado(double valor, string origem, string destino, double valorConvertido)
        {
            Console.WriteLine($"{valor} {origem} equivalem a {valorConvertido:F2} {destino}");
            Console.WriteLine("Aperte 'enter' para voltar ao menu principal");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
