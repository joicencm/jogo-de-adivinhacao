
namespace JogoDeAdivinhacaoConsoleApp1
{
    internal class Program
    {
        //Versão1: Estrutura básica e entrada do usuário
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Jogo de Adivinhação");
            Console.WriteLine("--------------------------------------");

            //Logica do jogo
            Console.Write("Digite um número para chutar: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Você digitou o nemero: " + numeroDigitado);

            Console.ReadLine();
        }
    }
}
