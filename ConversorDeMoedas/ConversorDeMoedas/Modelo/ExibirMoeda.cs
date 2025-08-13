using ConversorDeMoedas.Service;

namespace ConversorDeMoedas.Modelo
{
    public class ExibirMoeda
    {
        private Dictionary<string, double>? _todasMoedas { get; set; }
        public ExibirMoeda(Dictionary<string, double> taxas)
        {
            _todasMoedas = taxas;
        }
        private List<string> _moedasNome = new List<string>
        {
            "Dólar Americano",
            "Dólar Australiano",
            "Dólar Canadense",
            "Zloty Polonês",
            "Peso Mexicano",
            "Real Brasileiro"
        };

        public void ExibirMoedaETaxa()
        {
            Console.Clear();
            Console.WriteLine($"Moedas disponíveis para conversão -- Moeda base sobre as taxas -> Libra Esterlina (GBP):");
            foreach (var moeda in _todasMoedas!)
            {
                Console.WriteLine($"{moeda.Key}: {moeda.Value}");
            }
            Console.WriteLine();
            Console.Write("Aperte 'enter' para voltar ao menu principal");
            Console.ReadLine();
            Console.Clear();
        }

        public void ExibirNomeMoeda()
        {
            Console.WriteLine($"Moedas disponíveis para conversão");
            for (int i = 0; i < _todasMoedas.Count;i++)
            {
                string sigla = _todasMoedas.Keys.ElementAt(i);
                string nome = _moedasNome[i];
                Console.WriteLine($"- {sigla} -> {nome}");
            }
        }
    }
}
