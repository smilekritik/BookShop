using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class Book : Edition
    {
        protected int _page { get; set; }

        public Book()
        {
            this._page = 0;
        }
        public Book(int page)
        {
            this._page = page;
        }
        ~Book()
        {
        }

        public override string GetInfo()
        {
            return $"Сторінок в книзі - {_page} \n";
        }
    }
}
