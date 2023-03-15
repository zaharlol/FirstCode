using System;
using System.Net.Security;
using System.Reflection;
using System.Xml.Linq;

class Program
{
    private static void Main(string[] args)
    {
        (string name, int age) anketa;

        Console.WriteLine("Как вас зовут?");
        anketa.name = Console.ReadLine();

        Console.WriteLine("Сколько вам лет?");
        anketa.age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Вас зовут {0}", anketa.name);
        Console.WriteLine("Ваш возраст {0}", anketa.age);

        var (name, age) = ("Евгения", 27);
        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваш возраст: {0}", age);

        Console.WriteLine("Введите имя: ");
        name = Console.ReadLine();
        Console.WriteLine("Введите возраст: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваш возраст: {0}", age);
    }
}