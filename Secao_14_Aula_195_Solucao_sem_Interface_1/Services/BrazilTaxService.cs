using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_14_Aula_195_Solucao_sem_Interface_1.Services
{
    class BrazilTaxService
    {
        public double Tax(double amount)
        {
            if(amount <= 100.00)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }

    }
}
