using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopbowl
{
   public class Maker
   {
        public int id { get; set; }

        public string CompanyName{ get; set; }

        public string Country { get; set; }

        public string FullInfoMaker
        {
            get
            {
                return $"{id} {CompanyName} {Country}";
            }
        }

   }
}
