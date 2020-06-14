using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopbowl
{
    public class Order
    {
        public string ID { get; set; }

        public string IDCustm { get; set; }

        public string IDEmploee { get; set; }

        public string DataOrder { get; set; }

        public string DataSplit { get; set; }

        public string FullInfoOrders
        {
            get
            {
                return $"{ID} {IDCustm} {IDEmploee} {DataOrder} {DataSplit }";
            }
        }


    }
}
