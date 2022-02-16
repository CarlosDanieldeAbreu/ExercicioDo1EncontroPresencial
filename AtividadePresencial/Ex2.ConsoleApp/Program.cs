using System;

namespace Ex2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a largura do retângulo:");
            string strLargura = Console.ReadLine();
            int largura = Convert.ToInt32(strLargura);
            Console.WriteLine("Informe a altura do retângulo:");
            string strAltura = Console.ReadLine();
            int altura = Convert.ToInt32(strAltura);

            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < largura; j++)
                {
                    if(i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("A");
                        Console.ResetColor();
                    }
                    if(i % 2 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("B");
                        Console.ResetColor();
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
