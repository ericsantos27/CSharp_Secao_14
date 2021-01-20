using System;
using System.Collections.Generic;
using System.Text;
using Secao_14_Aula_195_Solucao_sem_Interface_1.Entidades;

namespace Secao_14_Aula_195_Solucao_sem_Interface_1.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double perHour, double perDay)
        {
            PricePerHour = perHour;
            PricePerDay = perDay;
        }

        public void ProcessInvoice(CarRental car)
        {
            TimeSpan duration = car.FinishDate.Subtract(car.StartDate);
            double payment = 0.00;
            if(duration.TotalHours <= 12.00)
            {
                payment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                payment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(payment);

            car.RentalInvoice = new Invoice(payment, tax);
        }
    }
}
