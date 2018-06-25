using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_2018
{
    class Nitro
    {
        public string Available { get; private set; } = "None";
        public double Power { get; private set; } = 1;

        public void Active(double multiplier)
        {
            Available = "Available";
            Power = multiplier;
        }

        public void Deactive(double multiplier)
        {
            Available = "None";
            Power = multiplier;
        }
    }
}
