// Fig. 12.14: PayableInterfaceTest.cs
// Tests interface IPayable with disparate classes.
using System;
using System.Collections.Generic;

class PayableInterfaceTest
{
   static void Main()
   {
      // create a List<IPayable> and initialize it with four 
      // objects of classes that implement interface IPayable
      var payableObjects = new List<IPayable>() {
         new Invoice("01234", "seat", 2, 375.00M),
         new Invoice("56789", "tire", 4, 79.95M),
         new SalariedEmployee("John", "Smith", "111-11-1111", 800.00M),
         new CommissionEmployee("Lisa", "Barnes", "888-88-8888", 10000.00M, .06M),
         new HourlyEmployee("Karen", "Price","222-22-2222", 16.75M, 40.0M),
         new BasePlusCommissionEmployee("Bob", "Lewis", "444-44-4444", 5000.00M, .04M, 300.00M)};

      Console.WriteLine(
         "Invoices and Employees processed polymorphically:\n");

      // generically process each element in payableObjects
      foreach (var payable in payableObjects)
      {
         // output payable and its appropriate payment amount
         Console.WriteLine($"{payable}");
         

            // determine whether element is a BasePlusCommissionEmployee
            if (payable is BasePlusCommissionEmployee)
            {
                // downcast Employee reference to 
                // BasePlusCommissionEmployee reference
                var employee = (BasePlusCommissionEmployee)payable;

                employee.BaseSalary *= 1.10M;
                Console.WriteLine("new base salary with 10% increase is: " +
                    $"{employee.BaseSalary:C}");
            }

            if (payable is HourlyEmployee)
            {
                // downcast Employee reference to 
                // BasePlusCommissionEmployee reference
                var employee = (HourlyEmployee)payable;

                employee.Wage += 2;
                Console.WriteLine("new hourly salary with 2.00 dollar increase is: " +
                    $"{employee.GetPaymentAmount():C}");
            }

            Console.WriteLine(
            $"payment due: {payable.GetPaymentAmount():C}\n");
        }
   }
}


