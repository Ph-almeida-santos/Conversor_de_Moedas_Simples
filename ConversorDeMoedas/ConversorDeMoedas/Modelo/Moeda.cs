using System.Text.Json.Serialization;

namespace ConversorDeMoedas.Modelo
{
    public class Moeda
    {
        [JsonPropertyName("rates")]
        public Dictionary<string, double> Taxas { get; set; } = new();
    }
}
