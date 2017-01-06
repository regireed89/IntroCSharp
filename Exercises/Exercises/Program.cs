using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> Fizz = new List<string>();
            //for (int i = 0; i <= 100; i++)
            //{

            //    string a = i.ToString();
            //    Fizz.Add(a);
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        a = "FizzBuzz";
            //        Console.WriteLine(a);
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        a = "Fizz";
            //        Console.WriteLine(a);
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        a = "Buzz";
            //        Console.WriteLine(a);
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.ReadLine();
            //}
            rps();
        }


        public static void rps()
        {
            int x = 9;
            while (x != 0)
            {
                Random random = new Random();
                int b = random.Next(1, 4);
                x = Convert.ToInt32(Console.ReadLine());
                Console.Clear(); 
                if (x == 1)
                {
                    Console.WriteLine("You choose rock");
                    if (b == 1)
                    {
                        Console.WriteLine("Computer choose rock");
                        Console.WriteLine("its a tie");
                    }
                    else if (b == 2)
                    {
                        Console.WriteLine("Computer choose paper");
                        Console.WriteLine("you lose");
                    }
                    else if (b == 3)
                    {
                        Console.WriteLine("Computer choose scissor");
                        Console.WriteLine("you win");
                    }
                }
                else if (x == 2)
                {
                    Console.WriteLine("You choose paper");
                    if (b == 1)
                    {
                        Console.WriteLine("Computer choose rock");
                        Console.WriteLine("you lose");
                    }
                    else if (b == 2)
                    {
                        Console.WriteLine("Computer choose paper");
                        Console.WriteLine("its a tie");
                    }
                    else if (b == 3)
                    {
                        Console.WriteLine("Computer choose scissor");
                        Console.WriteLine("you win");
                    }
                }
                else if (x == 3)
                {
                    Console.WriteLine("You choose scissor");
                    if (b == 1)
                    {
                        Console.WriteLine("Computer choose rock");
                        Console.WriteLine("you lose");
                    }
                    else if (b == 2)
                    {
                        Console.WriteLine("Computer choose paper");
                        Console.WriteLine("you win");
                    }
                    else if (b == 3)
                    {
                        Console.WriteLine("Computer choose scissor");
                        Console.WriteLine("its a tie");
                    }
                }
                else
                {
                    Console.WriteLine("wrong input");
                }
            }




            Console.ReadLine();


        }

    }
}






