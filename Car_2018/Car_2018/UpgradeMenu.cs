using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_2018
{
    class UpgradeMenu
    {
        public void WhatToDo() //я вообще хотел тут сделать все меню, но тут не видно экземпляров других классов =(
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nЧто жетаете сделать?");
            Console.ResetColor();
            Console.WriteLine("1. Заменить двигатель" +
                "\n2. Заменить топливо" +
                "\n3. Заменить шины" +
                "\n4. \"Закись азота\"");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("5. [ВЫХОД]");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\nВаш выбор: ");
            Console.ResetColor();
        }

        
        
    }
}
