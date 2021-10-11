using BooksStorageApp.Models;
using BooksStorageApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksStorageApp.Views
{
    class Index
    {
        public Index(List<Books> books, HomeController home, int index)
        {
            INDEX(books, home, index);
        }
        public void INDEX(List<Books> books,HomeController home,int index)
        {

            int top = Console.CursorTop;
            int y = top;
            int Count;
            if (index + 5 > books.Count)
                Count = books.Count;
            else
                Count = index + 5;
            for (int i = index; i < Count; i++)
            {
                Console.WriteLine($"Title{i+1}: {books[i].Title}");
            }

            Console.WriteLine("Add");
            Console.WriteLine("Next page");
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

            if (y > top - 1 & y < down-2)
                home.Read(index+y-top);
            else if (y == down-2)
                home.Add();
            else if (y == down-1)
                INDEX(books, home, index + 5);
        }
    }
}
