using System;
namespace inlamning5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
                Console.WriteLine("Skriv in 5 olika namn");
                string[] names = Console.ReadLine().Split(" ");

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine(names[i]);

                }

            }
            catch
            {

                Console.WriteLine("Något är fel, skrev du 5 namn?");
            }

            Console.ReadKey();

        }

    }

}
