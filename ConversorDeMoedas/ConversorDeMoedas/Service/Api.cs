using ConversorDeMoedas.Modelo;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConversorDeMoedas.Service
{
    public class Api
    {
        [JsonPropertyName("rates")]
        public Dictionary<string, double>? TodasMoedas { get; set; }
        private readonly string _accessKey = "codigo da api";

        public async Task<Dictionary<string, double>> ObterTaxasAsync()
        {
            using HttpClient cliente = new HttpClient();
            string resposta = await cliente.GetStringAsync($"http://api.exchangeratesapi.io/v1/latest?access_key={_accessKey}&symbols=USD,AUD,CAD,PLN,MXN,BRL");
            var moedas = JsonSerializer.Deserialize<Api>(resposta);
            return moedas.TodasMoedas;
        }
    }
}
