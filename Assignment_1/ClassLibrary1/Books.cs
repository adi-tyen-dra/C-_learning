using System;

enum Type
{
    Magazine=1,
    Novel=2,
    ReferenceBook=3,
    Miscellaneous=4,
}
public struct Book
{
    public int BookId;
    public String Title;
    public double Price;
    internal Type BookType;

    public void Assign(int bookId, String title, double price, int bookType)
    {
        this.BookId = bookId;
        this.Title = title;
        this.Price = price;
        this.BookType = (Type)bookType;

    }
}

namespace BookDetails
{
    public class Books
    {
        public Book ob;
        public void Get_Detail()
        {
            ob = new Book();

            Console.WriteLine("Enter the book Id: ");
            int bookId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Title of the book: ");
            String title = Console.ReadLine();

            Console.WriteLine("Price of the book: ");
            double price = double.Parse(Console.ReadLine());

            Reselect:
            Console.WriteLine("Enter the type: \n 1. Magazine \n 2. Novel \n 3. Reference Book \n 4. Miscellaneous");
            int bookType = int.Parse(Console.ReadLine());
            if(bookType <1 || bookType>4)
            {
                Console.WriteLine("Invalid Book Type!");
                goto Reselect;
            }

            ob.Assign(bookId, title, price, bookType);
        }
        public void Show_Detail()
        {
            Console.WriteLine("\nBook Id : " + ob.BookId); ;
            Console.WriteLine("Title : " + ob.Title);
            Console.WriteLine("Price : Rs." + ob.Price);
            Console.WriteLine("Type of book : " + ob.BookType.ToString());
        }
    }
}
