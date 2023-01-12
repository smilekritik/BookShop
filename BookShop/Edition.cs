using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    [Serializable]
    class Edition : IPrintable
    {
        delegate void ErrorShow();
        public Book Book { get; set; }
        public Publishing_house Publishing_house { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Page { get; set; }

        public Edition()
        {
            Name = string.Empty;
            Price = 0;
            Page = 0;
            Book = new Book();
            Publishing_house = new Publishing_house();
        }
        public Edition(string name, decimal price, string authorName, string authorSoname, DateTime authorBirth, string bookName, string bookGenre, int bookPages, string publishing_house)
        {
            Name = name;
            Price = price;
            Page = bookPages;

            Book = new Book(bookName, bookGenre, new Author(authorName, authorSoname, authorBirth));

            Publishing_house = new Publishing_house(publishing_house);
        }
        public Edition(Edition edition)
        {
            Name = edition.Name;
            Price = edition.Price;
            Page = edition.Page;
            Book = edition.Book;
            Publishing_house = edition.Publishing_house;
        }

        public void PrintsQuery(string type)
        {

            ErrorShow operation;
            if (type == "автор")
            {
                operation = Book.Authors.FirstOrDefault().GetInfoName;
            }
            else
            {
                operation = Book.GetInfoName;
            }
            operation();
        }

        public string GetInfo()
        {
            return $"{Name} {Price} \n"+ Book.GetInfo()+ Publishing_house.GetInfo();
        }
    }
}
