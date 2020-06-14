using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopbowl
{
    public class Goods
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Details { get; set; }

        public string CompanyName { get; set; }

        public string StatusView { get; set; }

        public string price { get; set; }

        public string FullInfoGoods
        {
            get
            {
                return $" {Id} {Name} {Type} {CompanyName} {Details} {StatusView } { price}";
            }
        }
    }
}
