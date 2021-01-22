using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_14_Aula_199_Exercicio_Interface.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount += (amount * 0.02);
        }
        
        public double Interest(double amount, int month)
        {
            return ((amount * 0.01) * month) + amount; 
        }
    }
}
