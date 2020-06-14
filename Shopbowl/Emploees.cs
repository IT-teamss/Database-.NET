using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopbowl
{
    public  class Emploees
    {
        public int ID { get; set; }

        public string Fname { get; set; }

        public string Mname { get; set; }

        public string Lname { get; set; }

        public string Post { get; set; }

        public string Salary { get; set; }

        public string PriorSalary { get; set; }

        public string FullInfoEmploees
        {
            get
            {
                return $"{ID} {Fname} {Mname} {Lname} {Post} {Salary} {PriorSalary}";
            }
        }

    }
}
