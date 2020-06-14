using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopbowl
{
    public class Descript
    {
        public int id { get; set; }

        public string Details { get; set; }


        public string FullInfoDescript
        {
            get
            {
                return $"{id} {Details}";
            }
        }
    }
}
