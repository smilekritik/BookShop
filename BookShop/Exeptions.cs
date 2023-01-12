using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class AuthorException : Exception
    {
        public string Name { get; set; }
        public AuthorException(string message, string text)
                : base(message)
        {
            Name = text;
        }
    }
}
