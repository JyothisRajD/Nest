class Book
{
    public int BOOKNO;
    public string BOOKTITLE;
    public float PRICE;

    public void INPUT()
    {
        Console.Write("Enter Book No: ");
        BOOKNO = int.Parse(Console.ReadLine());
        Console.Write("Enter Book Title: ");
        BOOKTITLE = Console.ReadLine();
        Console.Write("Enter Price: ");
        PRICE = int.Parse(Console.ReadLine());
    }

    public float TotalCost(int p)
    {
        return price * p;
    }

    public void PURCHASE()
    {
        Console.Write("Enter the number of copies to be purchased: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Total cost to be paid: {0}", TotalCost(p));
    }

    public void DISPLAY()
    {
        Console.WriteLine("Book No: {0}", BOOKNO);
        Console.WriteLine("Book Title: {0}", BOOKTITLE);
        Console.WriteLine("Price: {0}", PRICE);
    }

    static void Main(string[] args)
    {
        Book b= new Book();
        b.INPUT();
        b.PURCHASE();
        b.DISPLAY();
    }
}