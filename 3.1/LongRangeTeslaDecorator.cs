using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    public class LongRangeTeslaDecorator : TeslaDecorator
    {
        protected readonly ITeslaModel3 _component;
        public LongRangeTeslaDecorator(ITeslaModel3 component) : base(component)
        {
            _component = component;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, Long Rage";
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + 3500;
        }

        public override int GetRange()
        {
            return base.GetRange() + 91;
        }
    }
}
