using ConversorDeMoedas.Interface;
using ConversorDeMoedas.Service;
using ConversorDeMoedas.Modelo;
class Program
    {
        public static async Task Main()
        {

            var apiService = new Api();
            var taxas = await apiService.ObterTaxasAsync();
            var conversor = new Conversor();
            var ui = new Menu(taxas);
            var moedas = new ExibirMoeda(taxas);


            int opcao = 0;
            while (opcao != 3)
            {
                ui.ExibirMenu();
                opcao = ui.LerOpcao();

                switch (opcao)
                {
                    case 1:
                        moedas.ExibirMoedaETaxa();
                        break;
                    case 2:
                        ui.ColetarDados();
                        
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }