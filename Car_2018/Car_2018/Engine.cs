using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_2018
{
    class Engine
    {
        public string Type { get; private set; } = "Standart";
        public int Power { get; private set; } = 200;

        public void UpgToPlus(double multiplier) // меняю мощность движка и название через методы
        {
            Type = "Standart+";
            Power = (int)(Power * multiplier);
        }

        public void UpgToSport(double multiplier)
        {
            Type = "Sport";
            Power = (int)(Power * multiplier);
        }

        public void UpgToMuscule(double multiplier)
        {
            Type = "Muscule";
            Power = (int)(Power * multiplier);
        }
    }
}
