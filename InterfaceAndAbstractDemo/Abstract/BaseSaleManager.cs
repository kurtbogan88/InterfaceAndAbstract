using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAndAbstractDemo.Entities;

namespace InterfaceAndAbstractDemo.Abstract
{
    public abstract class BaseSaleManager : ISaleService
    {
        public virtual void Sale(Product product)
        {
            Console.WriteLine("Sale is completed");
        }

    }
}
