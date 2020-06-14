using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopbowl
{
    class OrdersTwo
    {
        public string IdOrders { get; set; }

        public string IDgoods { get; set; }

        public string CountGoods { get; set; }

        public string FullInfoOrderTWo
        {
            get
            {
                return $"{IdOrders} {IDgoods} {CountGoods} ";
            }
        }
    }
}
