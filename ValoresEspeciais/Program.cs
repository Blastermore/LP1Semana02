using System;
using System.Security.Cryptography.X509Certificates;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dc_max = decimal.MaxValue;
            decimal dc_min = decimal.MinValue;
            Console.WriteLine($"Decimal max value is: {dc_max}");
            Console.WriteLine($"Decimal min value is: {dc_min}");

            float flt_max = float.MaxValue;
            float flt_min = float.MinValue;
            Console.WriteLine($"Float max value is: {flt_max}");
            Console.WriteLine($"Float min value is: {flt_min}");

            double dble_max = float.MaxValue;
            double dble_min = float.MinValue;
            Console.WriteLine($"Double max value is: {dble_max}");
            Console.WriteLine($"Double min value is: {dble_min}");

            byte bt_max = byte.MaxValue;
            byte bt_min = byte.MinValue;
            Console.WriteLine($"Byte max value is: {bt_max}");
            Console.WriteLine($"Byte min value is: {bt_min}");

            sbyte sbt_max = sbyte.MaxValue;
            sbyte sbt_min = sbyte.MinValue;
            Console.WriteLine($"SByte max value is: {sbt_max}");
            Console.WriteLine($"SByte min value is: {sbt_min}");

            short shrt_max = short.MaxValue;
            short shrt_min = short.MinValue;
            Console.WriteLine($"Short max value is: {shrt_max}");
            Console.WriteLine($"Short min value is: {shrt_min}");

            ushort ushrt_max = ushort.MaxValue;
            ushort ushrt_min = ushort.MinValue;
            Console.WriteLine($"uShort max value is: {ushrt_max}");
            Console.WriteLine($"uShort min value is: {ushrt_min}");

            int integral_max = int.MaxValue;
            int integral_min = int.MinValue;
            Console.WriteLine($"Integral max value is: {integral_max}");
            Console.WriteLine($"Integral min value is: {integral_min}");

            uint uintegral_max = uint.MaxValue;
            uint uintegral_min = uint.MinValue;
            Console.WriteLine($"uIntegral max value is: {uintegral_max}");
            Console.WriteLine($"uIntegral min value is: {uintegral_min}");

            long lng_max = long.MaxValue;
            long lng_min = long.MinValue;
            Console.WriteLine($"Long max value is: {lng_max}");
            Console.WriteLine($"Long min value is: {lng_min}");

            ulong ulng_max = ulong.MaxValue;
            ulong ulng_min = ulong.MinValue;
            Console.WriteLine($"uLong max value is: {ulng_max}");
            Console.WriteLine($"uLong min value is: {ulng_min}");

            char chr_max = char.MaxValue;
            char chr_min = char.MinValue;
            Console.WriteLine($"Character max value is: {chr_max}");
            Console.WriteLine($"Character min value is: {chr_min}");

            double x = double.PositiveInfinity;
            double y = double.NegativeInfinity;
            float z = float.NaN;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);


            Console.WriteLine(uintegral_max + 1);
            Console.WriteLine(flt_max + 1);
            Console.WriteLine(2*flt_max);

        }
    }
}
