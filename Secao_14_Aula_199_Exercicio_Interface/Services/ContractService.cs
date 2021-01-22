using System;
using System.Collections.Generic;
using System.Text;
using Secao_14_Aula_199_Exercicio_Interface.Entities;

namespace Secao_14_Aula_199_Exercicio_Interface.Services
{
    class ContractService
    {
        private IOnlinePaymentService _iOnPaymService;

        public ContractService (IOnlinePaymentService onlinePaymServ)
        {
            _iOnPaymService = onlinePaymServ;
        }

        public void ProcessContract(Contract contract, int month)
        {
            double basicQuota = contract.ContractValue / month;
            for(int i = 1; i <= month; i++)
            {
                DateTime date = contract.ContractDate.AddMonths(i);
                double updateQuota = basicQuota + _iOnPaymService.Interest(basicQuota, i);
                double fullQuota = updateQuota + _iOnPaymService.PaymentFee(updateQuota);
                contract.AddInstallment(new Installments(date, fullQuota));
            }
        }
    }
}
