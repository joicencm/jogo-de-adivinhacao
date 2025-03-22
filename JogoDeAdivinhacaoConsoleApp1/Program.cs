using System;

namespace JogoDeAdivinhacaoConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] numerosDigitados = new string[100];
            int pontos = 500;

            while (true)
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine("Jogo de Adivinhação");
                Console.WriteLine("---------------------------------------------------------------------------------------------");

                // Escolha de dificuldade
                Console.WriteLine("Nível de dificuldade:");
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine("1 - Fácil (10 tentativas)");
                Console.WriteLine("2 - Normal (5 tentativas)");
                Console.WriteLine("3 - Difícil (3 tentativas)");
                Console.WriteLine("---------------------------------------------------------------------------------------------");

                int totalDeTentativas = 0;

                Console.Write("Digite sua escolha: ");
                string escolhaDeDificuldade = Console.ReadLine();

                if (escolhaDeDificuldade == "1")
                    totalDeTentativas = 10;
                else if (escolhaDeDificuldade == "2")
                    totalDeTentativas = 5;
                else
                    totalDeTentativas = 3;

                // Lógica do jogo
                Random geradorDeNumeros = new Random();
                int numeroSecreto = geradorDeNumeros.Next(1, 21);

                for (int tentativa = 1; tentativa <= totalDeTentativas; tentativa++)
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------------------------------------------------------------------------");
                    Console.WriteLine($"Tentativas {tentativa} de {totalDeTentativas}");
                    Console.WriteLine("---------------------------------------------------------------------------------------------");

                    Console.Write("Digite um número (de 1 a 20) para chutar: ");
                    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                    // Verificar se o número já foi digitado
                    if (Array.Exists(numerosDigitados, n => n == numeroDigitado.ToString()))
                    {
                        Console.WriteLine("---------------------------------------------------------------------------------------------");
                        Console.WriteLine($"Você já chutou o número {numeroDigitado}. Tente outro.");
                        tentativa--;
                    }

                    numerosDigitados[tentativa - 1] = numeroDigitado.ToString();

                    
                    if (numeroDigitado == numeroSecreto)
                    {
                        Console.WriteLine("---------------------------------------------------------------------------------------------");
                        Console.WriteLine("Parabéns, você acertou!");
                        Console.WriteLine("---------------------------------------------------------------------------------------------");
                        break;
                    }
                    else
                    {
                        int penalidade = Math.Abs((numeroDigitado - numeroSecreto) / 2);
                        pontos -= penalidade;
                        Console.WriteLine("---------------------------------------------------------------------------------------------");
                        Console.WriteLine($"Você errou! A diferença entre seu chute e o número secreto foi de {penalidade} pontos.");
                        Console.WriteLine($"Pontuação atual: {pontos} pontos.");
                        Console.WriteLine("---------------------------------------------------------------------------------------------");

                        if (numeroDigitado > numeroSecreto)
                        {
                            Console.WriteLine("O número chutado foi maior que o número secreto!");
                        }
                        else
                        {
                            Console.WriteLine("O número chutado foi menor que o número secreto!");
                        }
                    }

                    Console.WriteLine("Pressione ENTER para continuar!");
                    Console.ReadLine();
                }

                Console.WriteLine($"Sua pontuação final é: {pontos} pontos.");
                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
