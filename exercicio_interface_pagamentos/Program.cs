using exercicio_interface_pagamentos.Entities;
using exercicio_interface_pagamentos.Services;
using System;
using System.Globalization;

namespace exercicio_interface_pagamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Contract Data");
            Console.Write("Number: ");
            int contractnumber = int.Parse(Console.ReadLine());
            Console.Write("Data: ");
            DateTime contractdate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy" , CultureInfo.InvariantCulture);
            Console.Write("Contract Value: ");
            double contractvalue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of Installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract myContract = new Contract(contractnumber, contractdate, contractvalue);

            ContractSerrvice contractService = new ContractSerrvice(new PaypalService());
            contractService.ProcessContract(myContract, months);

            Console.WriteLine("Installments");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
