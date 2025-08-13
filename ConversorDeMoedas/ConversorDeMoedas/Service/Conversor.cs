using ConversorDeMoedas.Modelo;

namespace ConversorDeMoedas.Service
{
    public class Conversor
    {
        public double Converter(double valor, string moedaOrigem, string moedaDestino, Dictionary<string, double> taxas)
        {
            double valorNaBase = valor / taxas[moedaOrigem];
            double valorConvertido = valorNaBase * taxas[moedaDestino];
            return valorConvertido;
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
