using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please input your salary");
            double salary = Convert.ToDouble(Console.ReadLine());
            Double totalincome = salary * (1 + 0.1 + 0.03);
            Console.WriteLine("your total income is {0}", totalincome);
            Console.ReadKey();

        }
    }
}
