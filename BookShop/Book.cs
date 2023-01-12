using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    [Serializable]
    class Book 
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public List<Author> Authors = new List<Author>();
        public Book()
        {
            this.Name = string.Empty;
            this.Genre = string.Empty;
            this.Authors = new List<Author>();
        }
        public Book(string name, string genre, Author author)
        {
            this.Name = name;
            this.Genre = genre;
            Authors.Add(author);
        }
        ~Book()
        {
        }
        public void GetInfoName()
        {
            throw new AuthorException("Назва книги містить помилку", string.Empty);
        }
        public string GetInfo()
        {
            return $"Назва книги - {Name}, її жанр - {Genre} \n";
        }
    }
}
