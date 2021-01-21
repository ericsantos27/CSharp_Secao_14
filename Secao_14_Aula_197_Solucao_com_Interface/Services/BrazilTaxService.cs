using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_14_Aula_197_Solucao_com_Interface.Services
{
    class BrazilTaxService : ITaxService
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
