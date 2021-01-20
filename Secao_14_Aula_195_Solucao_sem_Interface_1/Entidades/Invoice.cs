using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_14_Aula_195_Solucao_sem_Interface_1.Entidades
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double payment, double tax)
        {
            BasicPayment = payment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return 
                "INVOICE:" + "\nPagamento: " + BasicPayment.ToString("F2") + "\nTax: " + Tax.ToString("F2") + "\nTotal: " + TotalPayment.ToString("F2");
        }

    }
}
