using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HelloWorld
{
    class Program
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

        [TestFixture]
        class Testing
        {
            [Test]
            public void Test()
            {
                var a = return1();
                Assert.AreEqual(1,a);
            }
        }
    }

    
}
