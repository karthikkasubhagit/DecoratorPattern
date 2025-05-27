using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    public abstract class TeslaDecorator(ITeslaModel3 car) : ITeslaModel3
    {
        protected ITeslaModel3 _car = car;


        public virtual decimal GetPrice()
        {
           return _car.GetPrice();
        }

        public virtual string GetDescription()
        {
            return _car.GetDescription();
        }

        public virtual int GetRange()
        {
            return _car.GetRange();
        }
    }
}
