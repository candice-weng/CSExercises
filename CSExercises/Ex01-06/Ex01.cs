﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please input your name");
            String name = Console.ReadLine();
            Console.WriteLine("Good morning,{0}", name);
            Console.ReadKey();
        }
    }
}
