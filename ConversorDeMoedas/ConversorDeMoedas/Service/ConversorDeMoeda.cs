namespace ConversorDeMoedas.Service
{
    public class ConversorDeMoeda
    {
        ExibirMoeda exibir = new ExibirMoeda();
        public void Converter(double valor, string moedaOrigem, string moedaDestino, Dictionary<string, double> taxas)
        {
            double valorNaBase = valor / taxas[moedaOrigem];
            double valorConvertido = valorNaBase * taxas[moedaDestino];
            exibir.ExibirResultado(valor, moedaOrigem, moedaDestino, valorConvertido);
        }
    }
}
