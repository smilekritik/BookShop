using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    [Serializable]
    class Author
    {
       

        public string Name { get; set; }
        public string Soname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Author()
        {
            this.Name = string.Empty;
            this.Soname = string.Empty;
            this.DateOfBirth = DateTime.Now;
        }
        public Author(string name, string soname, DateTime dateOfBirth)
        {
            if (name == "" || soname == "")
            {
                if (name == "")
                {
                    throw new AuthorException("Ім'я не повинно містити пусті поля", name);
                }
                else
                {
                    throw new AuthorException("Прізвище не повинно містити пусті поля", soname);
                }
            }
            else
            {
                this.Name = name;
                this.Soname = soname;
            }
            this.DateOfBirth = dateOfBirth;
        }
        ~Author()
        {
        }
        public void GetInfoName()
        {
            throw new AuthorException("Ім'я автора містить помилку", string.Empty);
        }
        public string GetInfo()
        {
            return $"Ім'я автора - {Name}, Прізвище - {Soname}, дата народження - {DateOfBirth} \n";
        }

    }
}
