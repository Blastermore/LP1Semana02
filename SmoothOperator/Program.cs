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
            
            int n_pro_div = n_pro/2;
            Console.WriteLine(n_pro_div);

            int n_pro_shift = n_pro << 3;
            Console.WriteLine(n_pro_shift);

            int n_pro_xor = n_pro ^ 5;
            Console.WriteLine(n_pro_xor);

            bool n_pro_comp = n_pro > 10;
            Console.WriteLine(n_pro_comp);

        }
    }
}
