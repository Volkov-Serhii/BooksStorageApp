using BooksStorageApp.Controllers;
using BooksStorageApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksStorageApp.Views
{
    class Edit
    {
        public static Books EditBook(List<Books> books, int i, HomeController home)
        {
            Books book = new Books() {Title = books[i].Title,Description = books[i].Description,Author = books[i].Author, Price = books[i].Price, Year = books[i].Year };
            Console.WriteLine("What you want edit?");
            int top = Console.CursorTop;
            int y = top;
            Console.WriteLine("Title:" + books[i].Title);
            Console.WriteLine("Description:" + books[i].Description);
            Console.WriteLine("Author:" + books[i].Author);
            Console.WriteLine("Price:" + books[i].Price);
            Console.WriteLine("Year:" + books[i].Year);

            Console.WriteLine("Cancle");
            Console.WriteLine("Main");
            int down = Console.CursorTop;

            Console.CursorSize = 100;
            Console.CursorTop = top;

            ConsoleKey key;
            while ((key = Console.ReadKey(true).Key) != ConsoleKey.Enter)
            {
                if (key == ConsoleKey.UpArrow)
                {
                    if (y > top)
                    {
                        y--;
                        Console.CursorTop = y;
                    }
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    if (y < down - 1)
                    {
                        y++;
                        Console.CursorTop = y;
                    }
                }
            }

            Console.CursorTop = down;

            if (y == top)
                book.Title = EditTitle();
            else if (y == top + 1)
                book.Description = EditDescription();
            else if (y == top + 2)
                book.Author = EditAuthor();
            else if (y == top + 3)
                book.Price = EditPrice();
            else if (y == top + 4)
                book.Year = EditYear();
            else if (y == top + 5)
                home.Read(i);
            else if (y == top + 6)
                home.Index();
            return book;
        }
        public static string EditTitle()
        {
            Console.WriteLine("Enter new Title:");
            return Console.ReadLine();
        }
        public static string EditDescription()
        {
            Console.WriteLine("Enter new Description:");
            return Console.ReadLine();
        }
        public static string EditAuthor()
        {
            Console.WriteLine("Enter new Author:");
            return Console.ReadLine();
        }
        public static double EditPrice()
        {
            Console.WriteLine("Enter new Price:");
            try
            {
                return Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error enter nit cirrect type,enter number");
                return Convert.ToDouble(Console.ReadLine());
            }
        }
        public static int EditYear()
        {
            Console.WriteLine("Enter new Year:");
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error not correct type,enter number");
                return Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
