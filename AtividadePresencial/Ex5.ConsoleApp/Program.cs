using System;

namespace Ex5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Jogo de dados");
            Console.ResetColor();
            Console.WriteLine("=============");
            Console.WriteLine("");

            Console.WriteLine("Informe o nome do jogador 1:");
            Console.ForegroundColor = ConsoleColor.Green;
            string nomeJ1 = Console.ReadLine();
            Console.ResetColor();

            Console.WriteLine("Informe o nome do jogador 2:");
            Console.ForegroundColor = ConsoleColor.Green;
            string nomeJ2 = Console.ReadLine();
            Console.ResetColor();

            int jogadaJ1 = 0;
            int jogadaJ2 = 0;
            int contadorVitoriaJ1 = 0;
            int contadorVitoriaJ2 = 0;
            int contadorDerrotaJ1 = 0;
            int contadorDerrotaJ2 = 0;
            int adicionarRodada = 0;
            for (int i = 0; i < 3 + adicionarRodada; i++)
            {
                Random numeroAleatorioJ1 = new Random();
                jogadaJ1 = numeroAleatorioJ1.Next(1, 6);
                Random numeroAleatorioJ2 = new Random();
                jogadaJ2 = numeroAleatorioJ2.Next(1, 6);

                Console.WriteLine((i+1) + "° Rodada");
                Console.WriteLine(nomeJ1 + ": " + jogadaJ1);
                Console.WriteLine(nomeJ2 + ": " + jogadaJ2);
                if(jogadaJ1 > jogadaJ2)
                {
                    Console.WriteLine("O jogador " + nomeJ1 + " jogou " + jogadaJ1 + " e venceu a " + (i + 1) + "ª rodada!");
                    contadorDerrotaJ2++;
                    contadorVitoriaJ1++;
                }else if (jogadaJ1 < jogadaJ2)
                {
                    Console.WriteLine("O jogador " + nomeJ2 + " jogou " + jogadaJ2 + " e venceu a " + (i + 1) + "ª rodada!");
                    contadorVitoriaJ2++;
                    contadorDerrotaJ1++;
                }
                else
                {
                    Console.WriteLine("Houve empate");
                }
                Console.ReadLine();
            }
            if (contadorVitoriaJ1 == contadorVitoriaJ2)
            {
                adicionarRodada = 1;
            }

            if(contadorVitoriaJ1 > contadorVitoriaJ2)
            {
                Console.WriteLine("Parabéns " + nomeJ1 + ", Você ganhou o jogo!");
            }else if (contadorVitoriaJ1 < contadorVitoriaJ2)
            {
                Console.WriteLine("Parabéns " + nomeJ2 + ", Você ganhou o jogo!");
            }

        }
    }
}
