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
    }
}