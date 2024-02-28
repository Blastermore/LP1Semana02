using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número inteiro não-negativo:");
            string n = Console.ReadLine();

            sbyte n_pro  = sbyte.Parse(n);

            Console.WriteLine(--n_pro);
            Console.WriteLine(++n_pro);


        }
    }
}
