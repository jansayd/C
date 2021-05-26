using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace exercicio_heranca_etiquetas.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFree { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFree) : base(name, price)
        {
            CustomsFree = customsFree;
        }

        public double TotalPrice()
        {
            return Price + CustomsFree;
        }

        public override string PriceTag()
        {
            return Name + " $" + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs Fee: $" + CustomsFree.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
