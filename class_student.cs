using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_student
{
    internal class student
    {
        public int roll_no;
        public String name;
        public void read()
        {
            Console.WriteLine("Enter the Roll Number");
            roll_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the Name");
            name = Console.ReadLine();
        }

        public void displaydetails()
        {
            Console.WriteLine("\nRoll Number: " + roll_no);
            Console.WriteLine("\nName: " + name);
        }

        public static void Main(string[] args)
        {
            student s1 = new student();
            s1.read();
            s1.displaydetails();

        }

    }
}
