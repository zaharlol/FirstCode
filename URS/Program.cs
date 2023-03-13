using System;
using System.Net.Security;
using System.Xml.Linq;

class Program
{
    private static void Main(string[] args)
    {
        //string a, b;
        //bool c = a != b;

        //int A, B;
        //double X, Y;
        //bool C1 = (A < B) | (X > Y);

        var inv = true;
        var result = !inv;
        Console.WriteLine(result);

        var a = 6;
        var b = 7;

        if (a < b)
        {
            Console.WriteLine("Условие истинно");
        }
        else
        {
            Console.WriteLine("Условие ложно");
        }

        Console.WriteLine("Напиши любимый цвет с маленькой буквы на английском");

        var color = Console.ReadLine();

        if (color == "red")
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Ваш цвет красный");
            Console.ReadLine();
        }

        else if (color == "blue")
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Ваш цвет синий");
            Console.ReadLine();
        }

        else
        {
            Console.BackgroundColor= ConsoleColor.Yellow;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.WriteLine("Ваш цвет жёлтый");

            Console.ReadLine();
        }

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        //Использование Switch


        for (int i = 1; i < 5; i++)
        {
            Console.WriteLine("i = {0}", i);
            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш цвет красный");
                    break;


                case "blue":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш цвет синий");
                    break;


                case "yellow":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш цвет жёлтый");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Множество цветов");
                    break;



            }
        }
    }
}