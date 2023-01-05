using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class Edition
    {

        Book Book;
        Publishing_house Publishing_house;
        string Name { get; set; }
        decimal Price { get; set; }
        int Page { get; set; }

        public Edition()
        {
            Name = string.Empty;
            Price = 0;
            Page = 0;
            Book = new Book();
            Publishing_house = new Publishing_house();
        }
        public Edition(string name, decimal price, string authorName, string authorSoname, DateTime authorBirth, string bookName, string bookGenre, int bookPages)
        {
            Name = name;
            Price = price;
            Page = bookPages;

            Author temp = new Author(authorName, authorSoname, authorBirth);
            Book = new Book(bookName, bookGenre, temp);

            Publishing_house = new Publishing_house();
        }
        public Edition(Edition edition)
        {
            Name = edition.Name;
            Price = edition.Price;
            Page = edition.Page;
            Book = edition.Book;
            Publishing_house = edition.Publishing_house;
        }
   
        public string GetInfo()
        {
            return $"{Name} {Price} \n"+ Book.GetInfo()+ Publishing_house.GetInfo();
        }
    }
}
