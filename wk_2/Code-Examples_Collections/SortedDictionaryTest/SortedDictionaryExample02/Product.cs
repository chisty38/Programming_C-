using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionaryExample02
{
     class Product
    {
        public string Name { get; set; }
        public double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                    price = value;
                else
                    price = 0.0;
            }
        } // end property

        // constructor
        public Product(string name, double p)
        {
            Name = name;
            Price = p;
        }

        public override string ToString()
        {
            return String.Format("\n{0}, {1}", Name, Price);
        }
    }
}
