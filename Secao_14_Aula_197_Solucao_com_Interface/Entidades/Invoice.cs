using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_14_Aula_197_Solucao_com_Interface.Entidades
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double InvoiceTax { get; set; }

        public Invoice()
        {
        }
        public Invoice(double payment, double tax)
        {
            BasicPayment = payment;
            InvoiceTax = tax;
        }

        public double TotalPayment()
        {
            return BasicPayment + InvoiceTax;
        }

        public override string ToString()
        {
            return "NOTA FISCAL: " + "\nPagamento: $ " + BasicPayment.ToString("F2") + "\nImposto: $ " + InvoiceTax.ToString("F2")
            + "\nTotal: $ " + TotalPayment().ToString("F2");
        }
    }
}
