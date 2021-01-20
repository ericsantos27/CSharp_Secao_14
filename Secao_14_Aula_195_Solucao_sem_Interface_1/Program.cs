using System;
using System.Globalization;
using Secao_14_Aula_195_Solucao_sem_Interface_1.Entidades;
using Secao_14_Aula_195_Solucao_sem_Interface_1.Services;

namespace Secao_14_Aula_195_Solucao_sem_Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do aluguel:");
            Console.Write("Modelo: ");
            string carModel = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Retirada (dd/mm/yyyy hh:mm): ");
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Devolução (dd/mm/yyyy hh:mm): ");
            DateTime finishDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Valor hora: ");
            double hourValue = double.Parse(Console.ReadLine());
            Console.Write("Valor da diária: ");
            double dailyRental = double.Parse(Console.ReadLine());

            Vehicle modelVehicle = new Vehicle(carModel);
            CarRental rentalData = new CarRental(startDate, finishDate, modelVehicle);
            RentalService rentalService = new RentalService(hourValue, dailyRental);

            rentalService.ProcessInvoice(rentalData);

            Console.WriteLine();
            Console.WriteLine("NOTA FISCAL: ");
            Console.WriteLine(rentalData.RentalInvoice);
        }
    }
}
