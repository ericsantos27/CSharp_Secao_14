using System;
using System.Globalization;
using Secao_14_Aula_199_Revisao_Exercicio.Entidades;
using Secao_14_Aula_199_Revisao_Exercicio.Services;

namespace Secao_14_Aula_199_Revisao_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do contrato: ");
            Console.WriteLine();
            Console.Write("Número do contrato: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Data do contrato (dd/mm/aaaa): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato: ");
            double contractValue = double.Parse(Console.ReadLine());

            Contract contractData = new Contract(contractNumber, contractDate, contractValue);

            Console.Write("Número de parcelas: ");
            int installmentsNumber = int.Parse(Console.ReadLine());

            ContractService serviceContract = new ContractService(new PaypalService());
            serviceContract.ProcessContract(contractData, installmentsNumber);

            Console.WriteLine("Parcelas: ");
            foreach (Installment element in contractData.InstallmentList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
