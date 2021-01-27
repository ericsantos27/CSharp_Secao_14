using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_14_Aula_199_Revisao_Exercicio.Entidades
{
    class Contract
    {
        public int ContractNumber { get; set; }
        public DateTime ContractDate { get; set; }
        public double ContractValue { get; set; }
        public List<Installment> InstallmentList { get; set; }

        public Contract(int number, DateTime date, double value)
        {
            ContractNumber = number;
            ContractDate = date;
            ContractValue = value;
            InstallmentList = new List<Installment>();
        }

        public void AddInstallments(Installment element)
        {
            InstallmentList.Add(element);
        }
    }

}
