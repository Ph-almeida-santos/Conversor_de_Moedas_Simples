using ConversorDeMoedas.Interface;

namespace ConversorDeMoedas.Service
{
    public class Menu : Imenu
    {
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
    }
}
