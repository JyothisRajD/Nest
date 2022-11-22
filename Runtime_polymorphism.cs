using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Runtime_polymophsm
    {

        public void Add(int a, int b)
        {
            Console.WriteLine("a + b = {0}", a + b);
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine("a + b + c = {0}", a + b + c);
        }
        public static void Main(string[] args)
        {
            Runtime_polymophsm obj= new Runtime_polymophsm();
            obj.Add(5, 10);
            obj.Add(5, 10, 15);
            Console.ReadLine();
        }
    }
}
