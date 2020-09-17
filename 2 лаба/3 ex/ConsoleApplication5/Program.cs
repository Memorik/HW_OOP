using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            { new Book("aa ", "aa ", "aa "),
            new Book("bb ", "bb ", "bb "),
             new Book("dd ", "dd ", "dd ")
            };
            bool exit = true;

            //Console.WriteLine(Book)

            for (; ; )
            {
                Console.WriteLine("1 - show books");
                Console.WriteLine("2 - Add book");
                Console.WriteLine("3 - Exit\n");

                int answer;
                int.TryParse(Console.ReadLine(), out answer);
                switch (answer)
                {

                    case 1:
                        ShowBooks(ref books);
                        break;

                    case 2:
                        AddBook(ref books);
                        break;

                    case 3:
                        exit = false;
                        Console.WriteLine("Good bye");
                        Console.ReadKey();
                        break;
                }


                if (exit == false)
                {
                    break;
                }
            }
        }

        public static void ShowBooks(ref List<Book> books)
        {

            Console.Clear();

            int i = 2;
            foreach (var item in books)
            {
                foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
                {
                    Console.ForegroundColor = color + i;
                    break;
                }
                i++;
                Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
        }

        public static void AddBook(ref List<Book> books)
        {
            Console.Clear();
            foreach (var item in books)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Write title ");
            string title = Console.ReadLine();
            Console.WriteLine("Write author ");
            string author = Console.ReadLine();
            Console.WriteLine("Write content ");
            string content = Console.ReadLine();
            books.Add(new Book(title, author, content));
            Console.Clear();
            Console.WriteLine("New book was added");
            Console.WriteLine("Write button to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }

    class Book
    {
        string title;
        string author;
        string content;

        public Book(string title, string author, string content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }

    }

}
