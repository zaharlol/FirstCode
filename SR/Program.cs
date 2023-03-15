using System;
using System.Net.Security;
using System.Reflection;
using System.Xml.Linq;

class Program
{
    private static void Main(string[] args)
    {
        (string name1, string lastname1, string login, int login1, bool pet, double year, string[] color) User;

        Console.WriteLine("Сколько будет пользователей?");
        int s = Int32.Parse(Console.ReadLine());
        for (int p = s; p > 0; p--)
        {
            Console.WriteLine("Введите имя");
            User.name1 = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.lastname1 = Console.ReadLine();

            Console.WriteLine("Введите логин");
            User.login = Console.ReadLine();

            User.login1 = User.login.Length;

            Console.WriteLine("У вас есть животное? Да или нет");
            var a = Console.ReadLine();
            if (a == "да")
            {
                User.pet = true;
            }
            else
            {
                User.pet = false;
            }

            Console.WriteLine("Введите возраст пользователя");
            User.year = Convert.ToDouble(Console.ReadLine());

            User.color = new string[3];
            Console.WriteLine("Введите три любимых цвета пользователя");

            for (int i = 0; i < User.color.Length; i++)
            {
                User.color[i] = Console.ReadLine();
            }
            Console.WriteLine("Следующий пользователь");
        }
    }
}