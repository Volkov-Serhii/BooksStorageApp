using BooksStorageApp.Models;
using BooksStorageApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksStorageApp.Controllers
{
    class HomeController
    {
        public List<Books> books;
        Context context = new Context();
        public HomeController()
        {
            books = context.Read();
            Index();
        }
        public void Index()
        {
            new Views.Index(books,this,0);
        }
        public void Add()
        {
            Books book = Views.Add.AddBook();
            books.Add(book);
            context.Save(books);
            Index();
        }
        public  void Delete(int index)
        {
            books.RemoveAt(index);
            context.Save(books);
            Index();
        }
        public void Edit(int i)
        {
            Books book = Views.Edit.EditBook(books,i,this);
            books[i] = book;
            context.Save(books);
            Index();
        }
        public void Read(int i)
        {
            Views.Read.ReadBook(books,i,this);
        }
    }
}
