using System.Net.Security;

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


                string Name = "Захар";
                byte year = 21;
                bool back = true;
                double ttt = 44.5;

                Console.WriteLine("Меня зовут " + Name);
                Console.WriteLine("Мне " + year + " год");
                Console.WriteLine("У вас есть питиомец? " + back);
                Console.WriteLine("Размер ноги " + ttt);
            }
        }
       
    }
}