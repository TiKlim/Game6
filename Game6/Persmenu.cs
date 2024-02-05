using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game6
{
    internal class Persmenu : Game
    {
        public static void Menu()
        {
            Game per;
            while (true)
            {
                Console.WriteLine("                                                ~ИГРОВОЕ МЕНЮ~");
                Console.WriteLine("                         1 - Создать нового персонажа; 2 - Выбрать уже существующего.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string? vybor = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                if (vybor == "1")
                {
                    Game.persons.Add(new Game()); //Добавляю в список живых новобранца
                }
                else if (vybor == "2")
                {
                    foreach (Game a in Game.persons) //Выполняю перебор в списке живых
                    {
                        Console.WriteLine("> Имя: ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        string? s = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (s == a.Name) //Поиск по имени персонажа
                        {
                            per = a;
                            per.Menu2(Game.persons);
                        }
                    }
                }
            }
        }
    }
}
