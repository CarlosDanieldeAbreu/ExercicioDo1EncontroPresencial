using System;

namespace Ex1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a largura do retângulo:");
            string strLargura = Console.ReadLine();
            int Largura = Convert.ToInt32(strLargura);
            Console.WriteLine("Informe a altura do retângulo:");
            string strAltura = Console.ReadLine();
            int Altura = Convert.ToInt32(strAltura);

            for(int i = 0; i < Altura; i++)
            {
                for(int j = 0; j < Largura; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}
