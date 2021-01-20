using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_14_Aula_195_Solucao_sem_Interface_1.Entidades
{
    class CarRental
    {
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public Vehicle RentalVehicle { get; set; }
        public Invoice RentalInvoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            StartDate = start;
            FinishDate = finish;
            RentalVehicle = vehicle;
            RentalInvoice = null;
        }
    }
}
