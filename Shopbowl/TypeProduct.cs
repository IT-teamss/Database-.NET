using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopbowl
{
    public class TypeProduct
    {
        public int id { get; set; }

        public string Type{ get; set; }


        public string FullInfoTypeProduct
        {
            get
            {
                return $"{id} {Type}";
            }
        }
    }
}
