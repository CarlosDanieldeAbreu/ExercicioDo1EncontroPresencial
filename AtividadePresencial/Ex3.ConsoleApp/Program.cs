using System;

namespace Ex3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a hora:");
            string strHoraAtual = Console.ReadLine();
            int horaAtual = Convert.ToInt32(strHoraAtual);
            Console.WriteLine("");
            if (horaAtual < 12)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bom dia!!!");
                Console.ResetColor();
            }else if (horaAtual > 12 && horaAtual < 18)
            {
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("Boa tarde!!!");
                Console.ResetColor();
            }else if (horaAtual > 18 && horaAtual < 0 || horaAtual < 24)
            {
                Console.WriteLine("Boa noite!!!");
            }
        }
    }
}
