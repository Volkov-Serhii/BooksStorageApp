using BooksStorageApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksStorageApp.Views
{
    class Add
    {
        public static Books AddBook()
        {
            Console.WriteLine("Enter Title:");
            string title = Console.ReadLine();
            Console.WriteLine("Enter Description:");
            string description = Console.ReadLine();
            Console.WriteLine("Enter Author:");
            string author = Console.ReadLine();
            Console.WriteLine("Enter Price:");
            double price = 0;
            try
            {
                price = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error enter nit cirrect type,enter number");
            }
            Console.WriteLine("Enter Year:");
            int year = 0;
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error not correct type,enter number");
            }
            Books book = new Books() { Title = title,Description = description, Author = author, Price = price, Year = year };
            return book;
        }
    }
}
