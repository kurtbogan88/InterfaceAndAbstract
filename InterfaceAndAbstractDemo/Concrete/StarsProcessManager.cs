using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractDemo.Concrete
{
    public class StarsProcessManager : IStars
    {
        public void AddStar(Customer customer)
        {
            Console.WriteLine("Add Star");
        }

        public int StarCount(Customer customer)
        {
            return 4;
        }
    }
}
