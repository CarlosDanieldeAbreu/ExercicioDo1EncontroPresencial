using System;

namespace Ex4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int media = 0;
            int soma = 0;
            int contadorPositivos = 0;
            int contadorNegativos = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe o " + (i+1) + "° número inteiro:");
                string strValores = Console.ReadLine();
                int valores = Convert.ToInt32(strValores);
                soma += valores;
                if(valores < 0)
                {
                    contadorNegativos++;
                }else if(valores >= 0)
                {
                    contadorPositivos++;
                }
            }
            media = soma / (contadorNegativos + contadorPositivos);
            
            Console.WriteLine("A média aritmética dos valores é: " + media);
            Console.WriteLine("A quantidade de valores positivos é: " + contadorPositivos);
            Console.WriteLine("A quantidade de valores negativos é: " + contadorNegativos);
        }
    }
}
