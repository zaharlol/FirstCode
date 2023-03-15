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

        (string Name, string Type, double Age, int NameCount) Pet;

        Console.WriteLine("Как зовут вашего питомца?");
        Pet.Name = Console.ReadLine();
        Console.WriteLine("Что за питомец?");
        Pet.Type = Console.ReadLine();
        Console.WriteLine("Какой возраст?");
        Pet.Age = Convert.ToDouble(Console.ReadLine());
        Pet.NameCount = Pet.Name.Length;
        Console.WriteLine("Вашего питомца зовут {0}, это - {1}, его возраст {2}", Pet.Name, Pet.Type, Pet.Age);
        Console.WriteLine("Длина имени: {0}", Pet.NameCount);
    }
}