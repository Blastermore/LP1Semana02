using System;

namespace MasterAndPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number Master insert number: ");
            string n = Console.ReadLine();
            int n_pro = int.Parse(n);

            if (n_pro < 0 || n_pro > 100 )
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                for (int i = 0; i < 100; i++)
                    Console.WriteLine();
                
                while (true)
                {
                    Console.Write("Player insert number: ");
                    string n_player = Console.ReadLine();
                    int n_player_pro = int.Parse(n_player);

                    if (0 < n_player_pro && n_player_pro < 100)
                    {
                        if (n_player_pro > n_pro)
                        {
                            Console.WriteLine("The correct number is " + 
                            $"lower than {n_player_pro}.");
                        }
                        else if (n_player_pro < n_pro)
                        {
                            Console.WriteLine("The correct number is " + 
                            $"higher than {n_player_pro}.");
                        }
                        else
                        {
                            Console.WriteLine("Player wins!");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid number! Try again!");
                    }
                }
            }
        }
    }
}
