using System;

namespace ข้อ_3_กลางภาค
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Boxes in first tank is");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Boxes in second tank is");
            int Second = int.Parse(Console.ReadLine());
            Console.Write("Boxes in Third tank is");
            int Third = int.Parse(Console.ReadLine());

            int i, n = 1000, sum = first + Second + Third;
            string A, B;
           
            for(i=0; i<n;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine("A turn");
                    Console.WriteLine("which tank");
                    string tank = Console.ReadLine();
                    Console.WriteLine("How many boxes to pickup");
                    int box = int.Parse(Console.ReadLine());

                    if (tank = 1)
                    {
                        first = first - box;
                    }
                    else if (tank = 2)
                    {
                        Second = Second - box;
                    }
                    else if (tank = 3)
                        Third = Third - box;
                    Console.WriteLine("There are the box in first tank {0} left:", first);
                    Console.WriteLine("There are the box in second tank {0} left:", Second;
                    Console.WriteLine("There are the box in first tank {0} left:", Third);
                }else
                {
                    Console.WriteLine("B turn");
                    Console.WriteLine("which tank");
                    string tank = Console.ReadLine();
                    Console.WriteLine("How many boxes to pickup");
                    int box = int.Parse(Console.ReadLine());

                    if (tank = 1)
                    {
                        first = first - box;
                    }
                    else if (tank = 2)
                    {
                        Second = Second - box;
                    }
                    else if (tank = 3)
                        Third = Third - box;
                    Console.WriteLine("There are the box in first tank {0} left:", first);
                    Console.WriteLine("There are the box in second tank {0} left:", Second;
                    Console.WriteLine("There are the box in first tank {0} left:", Third);
                }
                 if(sum==0)
                    if(i%2==0)
                    {
                        Console.WriteLine("The winner is {0}", A);
                    }
                    else
                    {
                        Console.WriteLine("The winner is {0}", B);
                    }
            }        Console.ReadLine();
        }
    }
}
