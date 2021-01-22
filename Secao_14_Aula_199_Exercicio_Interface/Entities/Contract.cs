using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_14_Aula_199_Exercicio_Interface.Entities
{
    class Contract
    {
        public int ContractNumber { get; set; }
        public DateTime ContractDate { get; set; }
        public double ContractValue { get; set; }
        public List<Installments> InstallmentList { get; set; }

        public Contract(int number, DateTime date, double value)
        {
            ContractNumber = number;
            ContractDate = date;
            ContractValue = value;
            InstallmentList = new List<Installments>();
        }

        public void AddInstallment(Installments element)
        {
            InstallmentList.Add(element);
        }
    }
}
