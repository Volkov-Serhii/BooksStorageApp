using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;

namespace BooksStorageApp.Models
{
    class Context
    {
        public Context()
        {
        }

        public List<Books> Read()
        {

            string path = Path.Combine(Environment.CurrentDirectory, "book.json");
            string json = File.ReadAllText(path);

            List<Books> books = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Books>>(json);

            return books;
        }

        public void Save(List<Books> books)
        {
            string jsonout = Newtonsoft.Json.JsonConvert.SerializeObject ( books );
            string path = Path.Combine(Environment.CurrentDirectory, "book.json");
            File.WriteAllText(path, jsonout);
        }
    }
}
