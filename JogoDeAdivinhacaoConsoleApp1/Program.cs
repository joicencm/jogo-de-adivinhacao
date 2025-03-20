namespace JogoDeAdivinhacaoConsoleApp1
{
    internal class Program
    {
        //Versão 3: Verificar se o jogador acertou
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Jogo de Adivinhação");
            Console.WriteLine("--------------------------------------------------");

            //Logica do jogo
            Random geradorDeNumeros = new Random();

            int numeroSecreto = geradorDeNumeros.Next(1, 21);

            Console.Write("Digite um número (de 1 a 20) para chutar: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (numeroDigitado == numeroSecreto)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Parabéns, você acertou!");
                Console.WriteLine("--------------------------------------------------");
            }
            else if (numeroDigitado > numeroSecreto)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("O numero digitado foi maior que o nemro secreto!");
                Console.WriteLine("--------------------------------------------------");
            }
            else
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("O numero digitado foi menor que o nemro secreto!");
                Console.WriteLine("--------------------------------------------------");
            }

            Console.ReadLine();
        }
    }
}
