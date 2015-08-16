using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PLEASE INPUT A DOUBLE PRECISION NUMBER");
            double x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Pow(x,0.5));
            Console.ReadKey();
        }
    }
}
