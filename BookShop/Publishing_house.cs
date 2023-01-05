using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class Publishing_house
    {
        string Name { get; set; }

        public Publishing_house()
        {
            this.Name = string.Empty;
        }
        public Publishing_house(string name)
        {
            this.Name = name;
        }
        ~Publishing_house()
        {
        }

        public string GetInfo()
        {
            return $"Назва видавництва - {Name} \n";
        }
    }
}
