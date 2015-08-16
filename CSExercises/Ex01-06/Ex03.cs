using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please input a double precision number");
            Double num = Convert.ToDouble (Console.ReadLine());
            num=num*num;
            Console.WriteLine(num);
        }
    }
}
