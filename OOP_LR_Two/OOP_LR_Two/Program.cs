using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq.Expressions;
using System.Xml;

namespace OOP_LR_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, s, k;

            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            try
            {
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
                d = Convert.ToDouble(Console.ReadLine());
                e = Convert.ToDouble(Console.ReadLine());

                if (b - a + 100 == 0 || b - 2 * d == 0)
                {
                    throw new Exception("Error: Attempted to divide by zero");
                }

                if (a - e < 0 || b - a + 100 < 0 || c - e < 0)
                {
                    throw new Exception("Error: Square of the root can`t be returned");
                }

                s = Math.Sqrt(a - e) / (Math.Sqrt(b - a + 100));
                k = Math.Sqrt((c - e) / Math.Abs(b - 2 * d));
                Console.WriteLine("S = " + s);
                Console.WriteLine("K = " + k);

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);            
            }

            

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
            Console.ReadKey();
        }
    }
}
