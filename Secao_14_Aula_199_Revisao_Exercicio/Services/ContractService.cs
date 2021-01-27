using System;
using System.Collections.Generic;
using System.Text;
using Secao_14_Aula_199_Revisao_Exercicio.Entidades;

namespace Secao_14_Aula_199_Revisao_Exercicio.Services
{
    class ContractService
    {
        public IOnlinePaymentService _iOnPaymService;

        public ContractService(IOnlinePaymentService onlinePaymServ)
        {
            _iOnPaymService = onlinePaymServ;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicValue = contract.ContractValue / months;
            for(int i = 1; i <= months; i++)
            {
                DateTime paymDate = contract.ContractDate.AddMonths(i);
                double updateValue = basicValue + _iOnPaymService.InterestFee(basicValue, i);
                double fullValue = updateValue + _iOnPaymService.PaymentFee(updateValue);
                contract.AddInstallments(new Installment(paymDate, fullValue));
            }
        }
    }
}
