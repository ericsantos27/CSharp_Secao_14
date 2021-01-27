using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_14_Aula_199_Revisao_Exercicio.Services
{
    interface IOnlinePaymentService
    {
        public double PaymentFee(double amount);
        public double InterestFee(double amount, int month);
    }
}
