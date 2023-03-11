using System;
using System.Net.Security;
using System.Xml.Linq;

class Program
{
    private static void Main(string[] args)
    {
        {
            {
                string MyName;
                MyName = "Захар";
                const string Name1 = "Захар";
                Console.WriteLine(MyName);
                Console.WriteLine(Name1);
                Console.ReadKey();

                Console.WriteLine("\tПривет, мир");
                Console.WriteLine("Мне 27 лет");
                Console.WriteLine("My name is Jane");
                Console.ReadKey();

                Console.WriteLine("Привет,\n мир!");
                Console.WriteLine('\x40');
                Console.WriteLine('\x23');
                Console.ReadKey();

                Console.WriteLine(true);
                Console.WriteLine(false);
                Console.ReadKey();

                string Name = "Захар";
                byte year = 21;
                bool back = true;
                double ttt = 44.5;

                Console.WriteLine("Меня зовут " + Name);
                Console.WriteLine("Мне " + year + " год");
                Console.WriteLine("У вас есть питиомец? " + back);
                Console.WriteLine("Размер ноги " + ttt);

                Console.WriteLine("Твой любимый день?");
                DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());
                Console.WriteLine("Your favorite day is {0}", day);

                Console.WriteLine("Как тебя зовут?");
                var name = Console.ReadLine();
                Console.WriteLine("Сколько тебе лет?");
                var age = checked((byte)int.Parse(Console.ReadLine()));
                Console.WriteLine("Your name is {0} and age is {1} ", name, age);
                Console.Write("What is your favorite day of week? ");
                var daym = (DayOfWeek)int.Parse(Console.ReadLine());
                Console.WriteLine("Your favorite day is {0}", daym);

                Console.WriteLine("Как тебя зовут?");
                var name2 = Console.ReadLine();
                Console.WriteLine("Сколько тебе лет?");
                var age1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Тебя зовут {0} и твой возраст {1} ", name2, age1);
                Console.Write("Дата рождения: ");
                var data1 = Console.ReadLine();
                Console.WriteLine("Ты родился {0}", data1);

                
            }

        }
    }
}
enum Semaphore
{
    Red = 100,
    Yellow = 200,
    Green = 300
}