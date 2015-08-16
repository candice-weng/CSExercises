using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("pLease input a double precision number");
            Double y= Convert.ToDouble(Console.ReadLine());
            y=Math.Pow(y,0.5);
            Decimal x=Convert.ToDecimal(y);
            x=Rounding(decimal,3);
            Console.WriteLine(x);

        }
    }
}
