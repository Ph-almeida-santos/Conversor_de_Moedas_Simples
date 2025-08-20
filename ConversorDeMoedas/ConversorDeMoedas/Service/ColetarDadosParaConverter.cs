using ConversorDeMoedas.Interface;

namespace ConversorDeMoedas.Service
{
    public class ColetarDadosParaConverter : IconversorDeMoeda
    {
        ConversorDeMoeda _conversor = new ConversorDeMoeda();
        public void ColetarDados(Dictionary<string, double> taxas)
        {
            double valor;
            string origem, destino;
            Console.Clear();
            while (true)
            {
                Console.Write("Quantidade a ser convertida: ");
                if (double.TryParse(Console.ReadLine(), out valor) && valor > 0)
                    break;
                Console.WriteLine("Valor inválido.");
            }

            while (true)
            {
                Console.Write("Moeda de origem (sigla 3 letras): ");
                origem = Console.ReadLine()!.ToUpper();
                if (taxas.ContainsKey(origem))
                    break;
                Console.WriteLine("Moeda inválida. Tente digitar somente a sigla");
            }
            while (true)
            {
                Console.Write("Moeda de destino (sigla 3 letras): ");
                destino = Console.ReadLine()!.ToUpper();
                if (taxas.ContainsKey(destino))
                    break;
                Console.WriteLine("Moeda inválida. Tente digitar somente a sigla");
            }
            _conversor.Converter(valor, origem, destino, taxas);
        }
    }
}
