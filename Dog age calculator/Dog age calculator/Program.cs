using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ben Shaw

namespace Day_time_taxi_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int human_years = 0;
            int age = 0;

            Console.WriteLine("Enter a negative number to exit the program while inputing the age of the dog");
            Console.ReadKey();
            Console.Clear();
            while (true)
            {
                human_years = 0;
                age = 0;
                try
                {
                    Console.Write("Enter amount of years that has passed: ");
                    human_years = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (human_years < 0)
                    {
                        Console.WriteLine("The program will now exit");
                        Console.ReadKey();
                        return;
                    }
                    else
                    {
                        //15 first year
                        //10 second year
                        //7 each year after

                        for (int i = 0; i < human_years; i++)
                        {
                            if (i == 0)
                            {
                                age = age + 15;
                            }
                            else if (i == 1)
                            {
                                age = age + 10;
                            }
                            else
                            {
                                age = age + 7;
                            }
                        }

                    }


                    Console.WriteLine("Their age in dog years is "+age+" years old");
                    Console.ReadKey();
                }

                catch
                {
                    Console.WriteLine("An error has occured somewhere the program will restart");
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }

    }
}
