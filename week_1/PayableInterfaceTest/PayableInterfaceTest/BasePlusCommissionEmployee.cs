﻿// Fig. 12.8: BasePlusCommissionEmployee.cs
// BasePlusCommissionEmployee class that extends CommissionEmployee.
using System;

public class BasePlusCommissionEmployee : CommissionEmployee, IPayable
{
   private decimal baseSalary; // base salary per week

   // six-parameter constructor
   public BasePlusCommissionEmployee(string firstName, string lastName,
      string socialSecurityNumber, decimal grossSales,
      decimal commissionRate, decimal baseSalary)
      : base(firstName, lastName, socialSecurityNumber,
           grossSales, commissionRate)
   {
      BaseSalary = baseSalary; // validates base salary
   }

   // property that gets and sets 
   // BasePlusCommissionEmployee's base salary
   public decimal BaseSalary
   {
      get
      {
         return baseSalary;
      }
      set
      {
         if (value < 0) // validation
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(BaseSalary)} must be >= 0");
         }

         baseSalary = value;
      }
   }

   // calculate earnings
   public new decimal GetPaymentAmount() => BaseSalary + base.GetPaymentAmount();

   // return string representation of BasePlusCommissionEmployee
   public override string ToString() =>
      $"base-salaried {base.ToString()}\nbase salary: {BaseSalary:C}";

    
}


