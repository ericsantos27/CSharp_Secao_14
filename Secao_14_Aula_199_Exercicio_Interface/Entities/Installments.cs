using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_14_Aula_199_Exercicio_Interface.Entities
{
    class Installments
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installments(DateTime due, double amount)
        {
            DueDate = due;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate + " - " + Amount.ToString("F2");
        }
    }
}
