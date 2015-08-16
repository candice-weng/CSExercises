using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please input an interger");
            int num = Convert.ToInt16(Console.ReadLine());
            num=num*num;
            Console.WriteLine(num);
        }
    }
}
