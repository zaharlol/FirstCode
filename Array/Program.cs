using System;
using System.Net.Security;
using System.Reflection;
using System.Xml.Linq;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите свё имя");
        var name = Console.ReadLine();

        Console.WriteLine("Ваше имя по буквам: ");

        foreach (var q in name) 
        {
            Console.Write(q + " ");
        }

        Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);
        Console.ReadKey();
    }
}