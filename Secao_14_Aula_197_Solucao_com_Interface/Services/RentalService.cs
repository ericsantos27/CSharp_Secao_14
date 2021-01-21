using System;
using System.Collections.Generic;
using System.Text;
using Secao_14_Aula_197_Solucao_com_Interface.Entidades;
using Secao_14_Aula_197_Solucao_com_Interface.Services;

namespace Secao_14_Aula_197_Solucao_com_Interface.Services
{
    class RentalService
    {
        public double HourPrice { get; private set; }
        public double DayPrice { get; private set; }

        private ITaxService _iTaxService;

        public RentalService()
        {
        }
        public RentalService(double hour, double day, ITaxService tax)
        {
            HourPrice = hour;
            DayPrice = day;
            _iTaxService = tax;
        }

        public void ProcessInvoice(CarRental carRent)
        {
            TimeSpan location = carRent.FinishRentalDate.Subtract(carRent.StartRentalDate);
            double paymLocation = 0.00;
            if(location.TotalHours <= 12.00)
            {
                paymLocation = HourPrice * Math.Ceiling(location.TotalHours);
            }
            else
            {
                paymLocation = DayPrice * Math.Ceiling(location.TotalDays);
            }

            double taxService = _iTaxService.Tax(paymLocation);

            carRent.RentalInvoice = new Invoice(paymLocation, taxService);
        }
    }
}
