using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_interface_pagamentos.Services
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
