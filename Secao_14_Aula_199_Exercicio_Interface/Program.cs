using System;
using System.Globalization;
using System.Collections.Generic;
using Secao_14_Aula_199_Exercicio_Interface.Entities;
using Secao_14_Aula_199_Exercicio_Interface.Services;

namespace Secao_14_Aula_199_Exercicio_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do contrato: ");
            Console.Write("Número: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Data do contrato (dd/mm/aaaa): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/aaaa", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato: ");
            double contractValue = double.Parse(Console.ReadLine());
            Console.Write("Número de parcelas: ");
            int installNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Parcelas: ");

        }
    }
}
