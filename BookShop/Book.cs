using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class Book 
    {
        string Name { get; set; }
        string Genre { get; set; }
        List<Author> Authors;
        public Book()
        {
            this.Name = string.Empty;
            this.Genre = string.Empty;
            this.Authors = null;
        }
        public Book(string name, string genre, Author author)
        {
            this.Name = name;
            this.Genre = genre;
            this.Authors.Add(author);
        }
        ~Book()
        {
        }

        public string GetInfo()
        {
            return $"Назва книги - {Name}, її жанр - {Genre} \n";
        }
    }
}
