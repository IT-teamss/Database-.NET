using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopbowl
{
    public class Customers
    {
        public int id { get; set; }

        public string Fname { get; set; }

        public string Mname { get; set; }

        public string Lname { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public string DataInSystem { get; set; }
          
        public string FullInfo
        {
            get
            {
                return $"{id} {Fname}{Mname}{Lname}{Address}{City}{Phone}{DataInSystem}";
            }
        }

    }
}
