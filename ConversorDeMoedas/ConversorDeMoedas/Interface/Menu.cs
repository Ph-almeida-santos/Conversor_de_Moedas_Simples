using ConversorDeMoedas.Modelo;
using ConversorDeMoedas.Service;
using System;

namespace ConversorDeMoedas.Interface
{
    public class Menu
    {
        private Dictionary<string, double> _taxas;
        private ExibirMoeda ExibirMoeda;
        private Conversor Conversor = new Conversor();

        public Menu(Dictionary<string, double> taxas)
        {
            _taxas = taxas;
            ExibirMoeda = new ExibirMoeda(_taxas);
        }
        public void ExibirMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Exibir Moedas Disponíveis");
            Console.WriteLine("2 - Converter Moeda");
            Console.WriteLine("3 - Sair");
        }
        public int LerOpcao()
        {
            Console.Write("Digite uma opção: ");
            if (int.TryParse(Console.ReadLine(), out int opcao))
                return opcao;
            return 0;
        }
        public void ColetarDados()
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
            ExibirMoeda.ExibirNomeMoeda();

            while (true)
            {
                Console.Write("Moeda de origem (sigla 3 letras): ");
                origem = Console.ReadLine()!.ToUpper();
                if (_taxas.ContainsKey(origem))
                    break;
                Console.WriteLine("Moeda inválida. Por favor insira somente 3 caracteres");
            }
            while (true)
            { 
                Console.Write("Moeda de destino (sigla 3 letras): ");
                destino = Console.ReadLine()!.ToUpper();
                if (_taxas.ContainsKey(destino))
                    break;
                Console.WriteLine("Moeda inválida. Por favor insira somente 3 caracteres");
            }
            double resultado = Conversor.Converter(valor, origem, destino, _taxas);
            Conversor.ExibirResultado(valor, origem, destino, resultado);
        }
    }
}
