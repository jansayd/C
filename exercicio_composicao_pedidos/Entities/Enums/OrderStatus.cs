using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_composicao_pedidos.Entities.Enums
{
    enum OrderStstus : int
    {
        Pending_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    };
}
