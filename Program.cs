using System;

namespace concluding
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("\nNumber of cities : ");
            num = int.Parse(Console.ReadLine());
            int numcity = 0;

            Console.WriteLine("");

            do
            {
                string namecity;
                Console.Write("City name :");
                namecity = Console.ReadLine();

                numcity = numcity + 1;

            } while (numcity < num);

            Console.WriteLine("");

            int numcity1 = 0, numcity2 = 0, numcity3 = 0;
            do
            {
                
                numcity = num;

                numcity = numcity - numcity1;
                do
                {
                    
                    numcity1 = numcity - 1;
                    numcity2 = numcity2 + 1;

                    string phase;
                    Console.Write("Input phase :");
                    phase = Console.ReadLine();

                } while (numcity < numcity1);

                numcity3 = numcity3 + 1;

            } while (numcity3  < num);
        }
    }
}