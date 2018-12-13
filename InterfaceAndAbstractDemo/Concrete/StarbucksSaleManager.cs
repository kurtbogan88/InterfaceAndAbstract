using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractDemo.Concrete
{
    public class StarbucksSaleManager:BaseSaleManager
    {
        IStarsProcess starsProcess;
        Customer customer;
        public StarbucksSaleManager(IStarsProcess starsProcess,Customer customer)
        {
            this.starsProcess = starsProcess;
            this.customer = customer;
        }

        public override void Sale(Product product)
        {
            if (starsProcess.StarCount(customer) == 10)
                SaleFree(product);
            else
            {
                starsProcess.AddStar(customer);
                base.Sale(product);
            }         
        }

        private void SaleFree(Product product)
        {
            Console.WriteLine("Free");
        }

        


    }
}
