using System;

namespace primos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un numero");
            int a = Int32.Parse(Console.ReadLine());
            bool primo = true;

            if (a >= 1000)
            {
                Console.WriteLine("Error");

            }

            for (int i = 2; i <= a; i++)
            {
                for (int j = 2; j <= a; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        primo = false;
                        break;

                    }

                }
                if (primo)
                {
                    Console.WriteLine(i);
                }

                primo = true;
            }
            Console.ReadKey();
        }
    }

}


