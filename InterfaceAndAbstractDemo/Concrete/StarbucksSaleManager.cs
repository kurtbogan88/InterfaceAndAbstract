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
        IStars stars;
        Customer customer;
        public StarbucksSaleManager(IStars stars, Customer customer)
        {
            this.stars = stars;
            this.customer = customer;
        }

        public override void Sale(Product product)
        {
            if (stars.StarCount(customer) == 10)
                SaleFree(product);
            else
            {
                stars.AddStar(customer);
                base.Sale(product);
            }         
        }

        private void SaleFree(Product product)
        {
            Console.WriteLine("Free");
        }

        


    }
}
