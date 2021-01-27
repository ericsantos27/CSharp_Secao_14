using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_14_Aula_199_Revisao_Exercicio.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double InterestFee(double amount, int month)
        {
            return ((amount * 0.01) * month);
        }

        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }
    }
}
