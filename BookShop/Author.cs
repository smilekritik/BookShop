using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{

    class Author
    {
        string Name { get; set; }
        string Soname { get; set; }
        DateTime DateOfBirth { get; set; }

        public Author()
        {
            this.Name = string.Empty;
            this.Soname = string.Empty;
            this.DateOfBirth = DateTime.Now;
        }
        public Author(string name, string soname, DateTime dateOfBirth)
        {
            this.Name = name;
            this.Soname = soname;
            this.DateOfBirth = dateOfBirth;
        }
        ~Author()
        {
        }

        public string GetInfo()
        {
            return $"Ім'я автора - {Name}, Прізвище - {Soname}, дата народження - {DateOfBirth} \n";
        }

    }
}
