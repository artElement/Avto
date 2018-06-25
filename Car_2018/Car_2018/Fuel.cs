using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_2018
{
    class Fuel
    {
        public string Type { get; private set; } = "92";
        public double Power { get; private set; } = 1;

        public void UpgToPlus(double multiplier)
        {
            Type = "92+";
            Power = multiplier;
        }

        public void UpgTo95(double multiplier)
        {
            Type = "95";
            Power = multiplier;
        }

        public void UpgTo98(double multiplier)
        {
            Type = "98";
            Power = multiplier;
        }
    }
}
