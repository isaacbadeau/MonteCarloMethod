using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool test = true;
            while(test)
            {
                try
                {
                    Console.Write("Enter a positive value: ");
                    
                    string input = Console.ReadLine();

                    if (input == "quit")
                        test = false;

                    Random random = new Random();

                    Coords[] coors = new Coords[Convert.ToInt32(input)];

                    int counter = 0;

                    for (int x = 0; x < Convert.ToInt32(input); x++)
                    {
                        coors[x] = new Coords(random);

                        if (coors[x].Hypo() <= 1)
                        {
                            counter++;
                        }
                    }

                    double z = Convert.ToDouble(counter);
                    double y = Convert.ToDouble(input);

                    double avg = (z / y) * 4.0;

                    Console.WriteLine($"\nEstimate:\t\t{avg}");
                    Console.WriteLine($"Actual:\t\t\t{Math.PI}");
                    Console.WriteLine($"Difference:\t\t{Math.PI-avg}\n");
                }
                catch(Exception)
                {}
            }
        }
    }
}
