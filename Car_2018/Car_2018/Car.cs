using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_2018
{
    class Car
    {
        Engine engine = new Engine();
        Fuel fuel = new Fuel();
        Nitro nitro = new Nitro();
        Wheels wheels = new Wheels();

        public void ShowSpec()
        {
            int maxSpeed = (int)((engine.Power * fuel.Power * nitro.Power) * 1.2);
            Console.WriteLine("\n\tДвигатель: {0}     \tМощностью: {1} л.с.", engine.Type, engine.Power);
            Console.WriteLine("\tТопливо: {0}             \t[Множитель скорости: {1}]", fuel.Type, fuel.Power);
            Console.WriteLine("\tШины: 4 шт, {0}-го типа \n\tСостояние шин: ", wheels.Type);
            wheels.Show();
            Console.WriteLine("\tNitro: {0}               \t[Множитель скорости: {1}]", nitro.Available, nitro.Power);
            Console.WriteLine("\tМаксимальная скорость: {0} км/ч", maxSpeed);
        }

        public void ChangeEngine() //изменение движка
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;   // кумарит много текста, хотел бы красивее код, но увы..
            Console.WriteLine("\nКакой двигатель желаете?");
            Console.ResetColor();
            Console.WriteLine("1. Поставить Standart+" +
                "\n2. Поставить Sport" +
                "\n3. Поставить Muscule");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Start1:
            Console.Write("Ваш выбор: ");
            Console.ResetColor();
            
            int Choise = Convert.ToInt32(Console.ReadLine());    // не нравится мне через свич, не оч красиво, но по другому не придумал
            switch (Choise)
            {
                case 1:
                    engine.UpgToPlus(1.1);
                    break;
                case 2:
                    engine.UpgToSport(1.2);
                    break;
                case 3:
                    engine.UpgToMuscule(1.3);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nНеверный выбор, попробуйте еще раз.");
                    Console.ResetColor();
                    goto Start1;
                    
            }
            Console.Clear;
            ShowSpec();
        }

        public void ChangeFuel() // топлива
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nНа какой бензин поменять?");
            Console.ResetColor();
            Console.WriteLine("1. Поставить 92+" +
                "\n2. Поставить 95" +
                "\n3. Поставить 98");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Start2:
            Console.Write("Ваш выбор: ");
            Console.ResetColor();
            
            int Choise = Convert.ToInt32(Console.ReadLine());
            switch (Choise)
            {
                case 1:
                    fuel.UpgToPlus(1.1);
                    break;
                case 2:
                    fuel.UpgTo95(1.15);
                    break;
                case 3:
                    fuel.UpgTo98(1.2);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nНеверный выбор, попробуйте еще раз.");
                    Console.ResetColor();
                    goto Start2;
            }
            ShowSpec();
        }

        public void ChangeWheels()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nЧто делаем с шинами?");
            Console.ResetColor();
            Console.WriteLine("1. Ставим новое переднее правое колесо" +
                "\n2. Ставим новое переднее левое колесо" +
                "\n3. Ставим новое заднее правое колесо" +
                "\n4. Ставим новое заднее левое колесо" +
                "\n5. Ставим все новые колеса");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Start3:
            Console.Write("Ваш выбор: ");
            Console.ResetColor();

            int Choise = Convert.ToInt32(Console.ReadLine());
            switch (Choise)
            {
                case 1:
                    wheels.ToNew(Choise);
                    break;
                case 2:
                    wheels.ToNew(Choise);
                    break;
                case 3:
                    wheels.ToNew(Choise);
                    break;
                case 4:
                    wheels.ToNew(Choise);
                    break;
                case 5:
                    wheels.ToNewAll();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nНеверный выбор, попробуйте еще раз.");
                    Console.ResetColor();
                    goto Start3;
            }
            ShowSpec();
        }

        public void SetNitro() // нитро
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nСтавим \"Закись азота\"?");
            Console.ResetColor();
            Console.WriteLine("1. Да, установить Nitro" +
                "\n2. Нет, убрать Nitro");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Start4:
            Console.Write("Ваш выбор: ");
            Console.ResetColor();
            
            int Choise = Convert.ToInt32(Console.ReadLine());
            switch (Choise)
            {
                case 1:
                    nitro.Active(1.3);
                    break;
                case 2:
                    nitro.Deactive(1);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nНеверный выбор, попробуйте еще раз.");
                    Console.ResetColor();
                    goto Start4;
            }
            ShowSpec();
        }

    }
}
