namespace JogoDeAdivinhacaoConsoleApp1
{
    internal class Program
    {
        //Versão 2: Gerar um número secreto aleatório
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Jogo de Adivinhação");
            Console.WriteLine("--------------------------------------");

            //Logica do jogo
            Random geradorDeNumeros = new Random();

            int numeroSecreto = geradorDeNumeros.Next(1, 21);

            Console.Write("Digite um número (de 1 a 20) para chutar: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Você digitou o nemero: " + numeroDigitado);
            Console.WriteLine("O número secreto é: " + numeroSecreto);

            Console.ReadLine();
        }
    }
}
