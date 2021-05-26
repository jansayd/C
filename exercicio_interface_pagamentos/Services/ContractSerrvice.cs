using System;
using System.Collections.Generic;
using System.Text;
using exercicio_interface_pagamentos.Entities;

namespace exercicio_interface_pagamentos.Services
{
    class ContractSerrvice
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractSerrvice(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updateQuota + _onlinePaymentService.PaymentFee(updateQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
