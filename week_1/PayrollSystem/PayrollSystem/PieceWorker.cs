using System;
using System.Collections.Generic;



    public class PieceWorker : Employee

    {
        private decimal variableWage;

        private int pieces;

        // property that gets and sets piece employee's variable wage

        public PieceWorker(string firstName, string lastName,
          string socialSecurityNumber, decimal vWage, int pieceS)
        : base(firstName, lastName, socialSecurityNumber)
       {
            VariableWage = vWage; // validate hourly wage 
            Pieces = pieceS; // validate hours worked 
        }

        public decimal VariableWage
        {
            get
            {
                return variableWage;
            }
            set
            {
                if (value < 0) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                       value, $"{nameof(variableWage)} must be >= 0");
                }

                variableWage = value;
            }
        }

        // property that gets and sets piece employee's piece
        public int Pieces
        {
            get
            {
                return pieces;
            }
            set
            {
                if (value < 0) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                       value, $"{nameof(Pieces)} must be >= 0 ");
                }

                pieces = value;
            }
        }


        // calculate earnings; override Employee’s abstract method Earnings
        public override decimal Earnings()
        {          
                return (VariableWage * Pieces);
        }

        public override string ToString() =>
      $"hourly employee: {base.ToString()}\n" +
      $"variable wage: {VariableWage:C}\npiece produced: {Pieces}";
  }
