using System;
using System.Collections.Generic;
using System.Text;
using Secao_14_Aula_197_Solucao_com_Interface.Entidades;

namespace Secao_14_Aula_197_Solucao_com_Interface.Entidades
{
    class CarRental
    {
        public DateTime StartRentalDate { get; set; }
        public DateTime FinishRentalDate { get; set; }
        public Vehicle RentalVehicle { get; set; }
        public Invoice RentalInvoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            StartRentalDate = start;
            FinishRentalDate = finish;
            RentalVehicle = vehicle;
            RentalInvoice = null;
        }
    }
}
