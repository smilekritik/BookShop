using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{

    class Author : Edition
    {
        protected string _name { get; set; }
        protected DateTime _dateOfBirth { get; set; }

        public Author()
        {
            this._name = "";
            this._dateOfBirth = DateTime.Now;
        }
        public Author(string name, DateTime dateOfBirth)
        {
            this._name = name;
            this._dateOfBirth = dateOfBirth;
        }
        ~Author()
        {
        }

        public override string GetInfo()
        {
            return $"Ім'я автора - {_name}, дата народження - {_dateOfBirth} \n";
        }

    }
}
