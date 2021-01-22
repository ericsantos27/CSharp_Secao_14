using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_14_Aula_199_Exercicio_Interface.Services
{
    interface IOnlinePaymentService
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int month);
    }
}
