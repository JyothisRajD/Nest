
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Space_count
    {
        string str, str1;
        public void SpaceCount()
        {
            Console.Write("Input a string :");
            str = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                {
                    count++;
                }
            }
            Console.WriteLine("\nTotal spaces:{0} ", +count);
        }
        public static void Main(String[] args)
        {
            Space_count n = new Space_count();
            n.SpaceCount();
        }

    }
}
