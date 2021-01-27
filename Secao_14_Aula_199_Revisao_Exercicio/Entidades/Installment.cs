using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_14_Aula_199_Revisao_Exercicio.Entidades
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double InstallmentValue { get; set; }

        public Installment(DateTime date, double value)
        {
            DueDate = date;
            InstallmentValue = value;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy") + " - " + InstallmentValue.ToString("F2");
        }
    }
}
