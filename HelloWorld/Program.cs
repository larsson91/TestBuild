﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HelloWorld
{
    public class Program
    {
        public static int return1()
        {
            return 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var a = return1();


            Console.ReadLine();
        }
    }

    
}
