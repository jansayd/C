using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_heranca_etiquetas.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $" + Price + " (Manufacture date:" + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
