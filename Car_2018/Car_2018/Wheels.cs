using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_2018
{
    class Wheels
    {
        public string Type { get; private set; } = "Standart";
        private string[] wheels = { "Обычное переднее правое колесо", "Обычное переднее левое колесо",
                                    "Обычное заднее правое колесо", "Обычное заднее левое колесо" };
        private string[] newWheels = { "Новое переднее правое колесо", "Новое переднее левое колесо",
                                    "Новое заднее правое колесо", "Новое заднее левое колесо" };

        public void Show()
        {
            for (int i = 0; i < wheels.Length; i++)
            {
                Console.WriteLine("\t\t\t\t\t[{0}]", wheels[i]);
            }
        }

        public void ToNewAll()
        {
            for (int i = 0; i < wheels.Length; i++)
            {
                wheels[i] = newWheels[i];
            }
        }

        public void ToNew(int wheelsIndex)
        {
            int i = wheelsIndex - 1;
            wheels[i] = newWheels[i];
        }
    }
}
