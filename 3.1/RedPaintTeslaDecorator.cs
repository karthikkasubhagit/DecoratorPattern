using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    public class RedPaintTeslaDecorator : TeslaDecorator
    {
        protected readonly ITeslaModel3 _car;
        public RedPaintTeslaDecorator(ITeslaModel3 car) : base(car)
        {
            _car = car;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, Red Paint";
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + 2000;
        }
    }
}
