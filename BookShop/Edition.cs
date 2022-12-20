using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class Edition
    {

        Book _book;
        Author _author;
        string _name;
        decimal _price;

        public Edition()
        {
            _name = "";
            _price = 0;
            _book = new Book();
            _author = new Author();
        }
        public Edition(string name, decimal price, string authorName, DateTime authorBirth, int bookPages)
        {
            _name = name;
            _price = price;
            _book = new Book(bookPages);
            _author = new Author(authorName, authorBirth);
        }
        public Edition(Edition edition)
        {
            _name = edition._name;
            _price = edition._price;
            _book = edition._book;
            _author = edition._author;
        }
   
        public virtual string GetInfo()
        {
            return $"{_name} {_price} \n"+_book.GetInfo()+ _author.GetInfo();

        }
    }
}
