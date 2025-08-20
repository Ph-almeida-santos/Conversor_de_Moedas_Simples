using ConversorDeMoedas.Service;

class Program
    {
        public static async Task Main()
        {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");
        var apiService = new Api();
        var taxas = await apiService.ObterTaxasAsync();
        var ExibirMoeda = new ExibirMoeda();
        var ui = new Menu();
        var coletarDados = new ColetarDadosParaConverter();


        int opcao = 0;
            while (opcao != 3)
            {
                ui.ExibirMenu();
                opcao = ui.LerOpcao();

                switch (opcao)
                {
                    case 1:
                        ExibirMoeda.ExibirMoedaETaxa(taxas);
                        break;
                    case 2:
                        coletarDados.ColetarDados(taxas);
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