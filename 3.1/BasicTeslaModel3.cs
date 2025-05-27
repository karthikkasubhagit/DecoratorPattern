using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    public class BasicTeslaModel3 : ITeslaModel3
    {
        public decimal GetPrice()
        {
            return 38990m;
        }

        public string GetDescription()
        {
            return "Tesla Model 3 Rear-Wheel drive";
        }

        public int GetRange()
        {
            return 272;
        }
    }
}
