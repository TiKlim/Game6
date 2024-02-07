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
            //Game game = new Game();
            //List<Game> persons = new List<Game>();
            while (true)
            {
                Console.WriteLine("                                                ~ИГРОВОЕ МЕНЮ~");
                Console.WriteLine("                         1 - Создать нового персонажа; 2 - Выбрать уже существующего.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string? vybor = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                if (vybor == "1")
                {
                    Game.persons.Add(new Game()); //Добавляю в список живых 
                }
                else if (vybor == "2")
                {
                    //foreach (Game a in Game.persons) //Выполняю перебор в списке живых
                    //{
                        Console.WriteLine("> Имя: ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        string? s = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    var names = from g in Game.persons
                                where g.Name == s
                                select g;
                    foreach (var name in names)
                    {
                        name.Menu2(Game.persons);
                    }
                        /*if (s == a.Name) //Поиск по имени персонажа
                        {
                            per = a;
                            per.Menu2(Game.persons);
                        }*/
                    /*if (persons.Exists(x => x.Name == s))
                    {
                        game.Menu2(persons.Find(x => x.Name.Contains(s)));
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Персонажа с таким именем не существует");
                        Console.ForegroundColor = ConsoleColor.White;
                    }*/
                    //}
                }
            }
        }
    }
}
