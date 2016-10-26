using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuee;
            do
            {


                Console.WriteLine("enter an integer");
                int x = Convert.ToInt32(Console.ReadLine());
                int y;
                int z;
                Console.WriteLine(" number  square   cube");
                for (int i = 0; i <= x; i++)
                {
                    y = i * i;
                    z = i * i * i;
                    Console.WriteLine(i + "        " + y + "           " + z);

                }
                Console.WriteLine("you want to continue y/n ");



                continuee = Console.ReadLine();

            }
            while (continuee =="y");
            }
        }
    }

