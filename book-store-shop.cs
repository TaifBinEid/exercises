using System;
using System.Collections.Generic;

namespace TaifShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            Console.WriteLine("<<< Welcome in Taif Bookstore >>> \n can i know you ? ");
            userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello " + userName + " have enjoy :)\n");

            Console.WriteLine("Enter 1 to show books.");
            int numberOne = int.Parse(Console.ReadLine());

            BookOperation();

        }


        public static void BookOperation()
        {
            List<Bookstore> book = new List<Bookstore>();

        Add:
            Console.WriteLine(" 1- Book: In Search of Lost Time\n Author:Marcel Proust\n Price 40.67\n quantity :5 \n******************\n"
                + " 2- Book: Start with why\n Author:Simon Sinek\n Price 80.0\n quantity :15 \n******************\n"
                +
                " 3- Book: Awaken The Giant Within\n Author:Anthony Robbins\n Price 50.0\n quantity :10 \n******************\n"
                +
                " 4- Book: Screw It Lets Do It: Lessons in Life\n Author:Richard Bransonn Price 60.55\n quantity :7 \n******************\n"
                +
                " 5- Book: The Art of Happiness\n Author:Dalai Lama\n Price 74.30\n quantity :5 \n******************\n"
                +
                " 6- Book: The Magic of Thinking Big\n Author:David J Schwartzt\n Price 66.67n quantity :13 \n******************\n"
                +
                " 7- Book: Don’t Sweat the Small Stuff\n Author:Richard Carlson\n Price 50.67\n quantity :8 \n******************\n"
                +
                " 8- Book: You don't know JS\n Author:Kyle Simpsont\n Price 37.5n quantity :6 \n******************\n");

            Console.WriteLine("Enter book ID , you want to add to the basket :");
            int idBook = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity You Need :");
            int q = int.Parse(Console.ReadLine());
            switch (idBook)
            {
                case 1:
                    book.Add(new Bookstore("In Search of Lost Time", "Marcel Proust", 40.67, q));
                    Console.WriteLine("\n<<<  The book has been added successfully  >>>");
                    break;

                case 2:
                    book.Add(new Bookstore("Start with why", "Simon Sinek", 80.0, q));
                    Console.WriteLine("\n<<<  The book has been added successfully  >>>\n");
                    break;

                case 3:
                    book.Add(new Bookstore("Awaken The Giant Within", "Anthony Robbins", 50.0, q));
                    Console.WriteLine("\n<<<  The book has been added successfully  >>>\n");
                    break;

                case 4:
                    book.Add(new Bookstore("Screw It Lets Do It: Lessons in Life", "Richard Branson", 60.55, q));
                    Console.WriteLine("\n<<<  The book has been added successfully  >>>\n");
                    break;

                case 5:
                    book.Add(new Bookstore("The Art of Happiness", "Dalai Lama", 74.30, q));
                    Console.WriteLine("\n<<<  The book has been added successfully  >>>\n");
                    break;

                case 6:

                    book.Add(new Bookstore("The Magic of Thinking Big", "David J Schwartz", 66.67, q));
                    Console.WriteLine("\n<<<  The book has been added successfully  >>>\n");
                    break;

                case 7:
                    book.Add(new Bookstore("Don’t Sweat the Small Stuff", " Richard Carlson", 50.67, q));
                    Console.WriteLine("\n<<<  The book has been added successfully  >>>\n");
                    break;

                case 8:
                    book.Add(new Bookstore("You don't know JS", "Kyle Simpson", 37.5, q));
                    Console.WriteLine("\n<<<  The book has been added successfully  >>>\n");
                    break;

                default:
                    Console.WriteLine("Sorry .. Invalid Id book try again");
                    break;
            }
            // here count total of price for  Purchased books
            double tumpPrice = 0;
            foreach (Bookstore bbb in book)
            {
                tumpPrice += bbb.bookPrice;
            }

            double total = 0;
            // here  print purchased books By Customer 
            Console.WriteLine("Purchased books is :");
            int countrNumberOfBook = 1;
            {
                foreach (Bookstore bb in book)
                {
                    total += bb.bookPrice;
                    Console.WriteLine("Book Id : " + countrNumberOfBook + "\nBook Name :" + bb.bookName + "\nBook Author : " + bb.bookAuthor + "\nBook Price : " + bb.bookPrice
                        + "\nBook Quantity : " + bb.bookQuantity);

                    countrNumberOfBook++;
                }
                Console.WriteLine("Total amount : " + total); //print onec
                Console.WriteLine("*******************************");
                if (total > 100)//here discount 
                {
                    Console.WriteLine("Great, you got 10% off.");
                    double discount = total * 0.10;
                    Console.WriteLine("has been discount:" + discount);
                    Console.WriteLine("Total amount after discount " + (total - discount));
                }

                Console.WriteLine("Do you want to :\n1-Add a new book.\n" +
                                                   "2-Delete book .  \n" +
                                                   "3-Exit?");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    goto Add;
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter Book Id you want delete : ");
                    int deletBook = int.Parse(Console.ReadLine());
                    deletBook = countrNumberOfBook;
                    book.RemoveAt(countrNumberOfBook);
                    Console.WriteLine("\n<<<  The book has been deleted successfully  >>>\n");
                }
                else if (choice == 3)
                {
                    return;
                }
            }
        }

        class Bookstore
        {
            public string bookName;
            public string bookAuthor;
            public double bookPrice;
            public int bookQuantity;
            public Bookstore(string bookName, string bookAuthor, double bookPrice, int bookQuantity)
            {
                this.bookName = bookName;
                this.bookAuthor = bookAuthor;
                this.bookPrice = bookPrice;
                this.bookQuantity = bookQuantity;
            }
            public Bookstore() { }
        }


    }
}

