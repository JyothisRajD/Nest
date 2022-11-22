using System;

class StudentSwap
{
    public int id;
    public string name;
    public int mark;
    public void read()
    {
        Console.WriteLine("Enter id");
        id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter name");
        name = Console.ReadLine();
        Console.WriteLine("Enter mark");
        mark = int.Parse(Console.ReadLine());
    }
    public void swap(StudentSwap stud, StudentSwap stud2)
    {
        StudentSwap temp = new StudentSwap();
        temp = stud;
        stud = stud2;
        stud2 = temp;
        Console.WriteLine("After Swapping");
        stud.display();
        stud2.display();
    }
    public void display()
    {
        Console.WriteLine("Id: {0}", id);
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Mark: {0}", mark);
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentSwap st1 = new StudentSwap();
        StudentSwap st2 = new StudentSwap();
        st1.read();
        st2.read();
        Console.WriteLine("Before Swapping");
        st1.display();
        st2.display();
        st1.swap(st1, st2);
        
        Console.ReadLine();
    }
}
