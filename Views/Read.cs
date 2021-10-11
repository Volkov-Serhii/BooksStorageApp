using BooksStorageApp.Controllers;
using BooksStorageApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksStorageApp.Views
{
    class Read
    {
        public static void ReadBook(List<Books> books,int i,HomeController home)
        {
            Console.WriteLine("Title:"+books[i].Title);
            Console.WriteLine("Description:"+books[i].Description);
            Console.WriteLine("Author:"+books[i].Author);
            Console.WriteLine("Price:"+books[i].Price);
            Console.WriteLine("Year:"+books[i].Year);
            int top = Console.CursorTop;
            int y = top;
            Console.WriteLine("Edit");
            Console.WriteLine("Delete");
            Console.WriteLine("Cencle");
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
                home.Edit(i);
            else if (y == top + 1)
                home.Delete(i);
            else if (y == top + 2)
                home.Index();
        }
    }
}
