using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainuL_Haque_Excercise_03
{
    class Invoice
    {
        public int PartNumber;
        public string PartDescription;
        private int Quantity;
        private decimal Price;
        private decimal InvoiceTotal;

        public Invoice(int partNumber, string partDescription, int quatity, decimal price)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quatity;
            Price = price;
        }

        public decimal price
        {
            get
            {
                return Price;
            }
            set
            {
                if (value >= 0M)
                {
                    Price = value;
                }
            }
        }

        public int quantity
        {
            get
            {
                return Quantity;
            }
            set
            {
                if (value >= 0)
                {
                    Quantity = value;
                }
            }
        }

        public decimal invoiceTotal
        {
            get
            {
                return price * quantity;
            }
            set
            {

                InvoiceTotal = value;

            }
        }

        public override string ToString() =>
      $"{PartNumber,-10} {PartDescription,-20} {Quantity,-10} {Price,10:C}";
    }
}
