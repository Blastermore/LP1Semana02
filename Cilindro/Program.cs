using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Um valor para a altura do cilindro");
            string a = Console.ReadLine();

            Console.WriteLine("Insira um valor para o raio do cilindro");
            string r = Console.ReadLine();

            float a_pro = float.Parse(a);
            float r_pro = float.Parse(r);
            float PI = MathF.PI;

            float V = MathF.PI * MathF.Pow(r_pro,2) * a_pro;
            float Sa = 2 * PI * r_pro * (r_pro + a_pro);

            Console.WriteLine($"O volume do cilindro é. {V}");
            Console.WriteLine($"A área de superfície do cilindro é: {Sa}");
        }
    }
}
