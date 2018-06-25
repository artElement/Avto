using System;

namespace Car_2018
{
    class CarStart
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            UpgradeMenu menu = new UpgradeMenu();
            int Choise = 0;

            Console.WriteLine("Ваша машина, стандартно, состоит из таких частей и имеет такие характеристики: ");
            
            car.ShowSpec();
            while (Choise != 5) 
            {
                menu.WhatToDo();
                Start:
                Choise = Convert.ToInt32(Console.ReadLine());
                switch (Choise)
                {
                    case 1:
                        car.ChangeEngine(); //выбираем, что хотим менять: топливо, движок и т.п.
                        break;
                    case 2:
                        car.ChangeFuel();
                        break;
                    case 3:
                        car.ChangeWheels();
                        break;
                    case 4:
                        car.SetNitro();
                        break;
                    case 5:
                        Choise = 5;
                        Console.WriteLine("Спасибо за визит, приходите еще!");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nНеверный выбор, попробуйте еще раз.");
                        Console.ResetColor();
                        goto Start;
                }
            }

            Console.ReadLine();
        }
    }
}