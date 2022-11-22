using System;
class student
{
    public int id, m1, m2, m3, Total;
    public string name;
    public void read()
    {
        Console.WriteLine("Enter id ");
        id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter name ");
        name = Console.ReadLine();
        Console.WriteLine("Enter mark1 ");
        m1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter mark2 ");
        m2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter mark3 ");
        m3 = int.Parse(Console.ReadLine());
    }
    public void calculate()
    {
        Total = m1 + m2 + m3;
    }
    public void display()
    {
        Console.WriteLine("id=" + id);
        Console.WriteLine("name=" + name);
        Console.WriteLine("mark1=" + m1);
        Console.WriteLine("mark2=" + m2);
        Console.WriteLine("mark3=" + m3);
        Console.WriteLine("total=" + total);
    }
    public static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Number of students");
        n = int.Parse(Console.ReadLine());
        student[] st = new student[n];
        for (int i = 0; i < n; i++)
        {
            st[i] = new student();
            st[i].read();
            st[i].calculate();
            st[i].display();
        }
    }
}