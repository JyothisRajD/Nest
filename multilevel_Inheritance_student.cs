using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Students
    {
        class Student
        {
            private string name;
            private int id;
            public void read()
            {
                Console.WriteLine("Enter Student ID:");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Student Name:");
                name = Console.ReadLine();
            }
            public void display()
            {
                Console.WriteLine("\n\n\t<---Student Details--->");
                Console.WriteLine("\n\tStundet ID:\t" + id);
                Console.WriteLine("\tStudent Name:\t" + name);
            }
        }

        class Internal : Student
        {
            protected int internal_mark;

            public void internal_read()
            {
                Console.WriteLine("Enter internal mark:");
                internal_mark = Convert.ToInt32(Console.ReadLine());
            }

            public void internal_display()
            {
                Console.WriteLine("\n\tInternal Mark:\t" + internal_mark);
            }
        }

        class External : Internal
        {
            private int external_mark, total_mark;

            public void external_read()
            {
                Console.WriteLine("Enter external mark");
                external_mark = Convert.ToInt32(Console.ReadLine());
            }
            public void external_display()
            {
                Console.WriteLine("\tExternal Mark:" + external_mark);
            }
            public void total()
            {
                total_mark = external_mark + internal_mark;
                Console.WriteLine("\nTotal Mark:" + total_mark);
            }
        }
        public static void Main(string[] args)
        {
            External obj = new External();
            obj.read();
            obj.internal_read();
            obj.external_read();
            obj.display();
            obj.internal_display();
            obj.external_display();
            obj.total();
        }

    }
}
