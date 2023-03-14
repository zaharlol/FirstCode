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

        int i = 1;
        do
        {
            Console.Write(name[name.Length - i]);
            i++;
        }
        while (i != name.Length + 1);

        Console.WriteLine(" Последняя буква вашего имени: {0}", name[0]);
        Console.ReadKey();

        int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

        for (int x = 0; x < array.GetUpperBound(1) + 1; x++)
        {
            for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                Console.Write(array[k, x] + " ");

            Console.WriteLine();
            Console.ReadKey();
        }

        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

        int temp;

        for (int z = 0; z < arr.Length; z++)
        {
            for (int j = z + 1; j < arr.Length; j++)
            {
                if (arr[z] > arr[j])
                {
                    temp = arr[z];
                    arr[z] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        foreach (var item in arr)
        {
            Console.Write(item);
        }

        var arr1 = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        int a = 0;
        Console.WriteLine(a);
        for (int t = 0; t < arr1.Length; t++)
        {
            a += arr1[t];
        }
        Console.WriteLine(a);


        int[][] array1 = new int[3][];

        array1[0] = new int[2] { 1, 2 };
        array1[1] = new int[3] { 1, 2, 3 };
        array1[2] = new int[5] { 1, 2, 3, 4, 5 };

        foreach (var ar in array1)
        {
            foreach (var item in ar)
            {
                Console.Write(item + " ");
            }
        }
        Console.WriteLine();

        var arr2 = new int[] { 5, 1, -1, -6, 2, -7, -2, 8 };
        var v = 0;
        for (int m = 0; m < arr2.Length; m++)
        {
            if (arr2[m] > 0)
            {
                v += 1;
            }
        }
        Console.WriteLine(v);

        int[,] arr3 = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

        var c = 0;
        foreach (var ty in arr3)
        {
            if (ty > 0)
                c++;
        }
        Console.WriteLine(c);

        int[,] arr5 = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
        int pow;
        for (int o = 0; o <= arr5.GetUpperBound(0); o++)
        {

            for (int p = 0; p <= arr5.GetUpperBound(1); p++)
                for (int d = p + 1; d <= arr5.GetUpperBound(1); d++)
                    
                    if (arr5[o, p] > arr5[o, d])
                    {
                        pow = arr5[o, d];
                        arr5[o, d] = arr5[o, p];
                        arr5[o, p] = pow;
                    }
        
        }
        foreach (var item in arr5)
        {
            Console.Write(item) ;
        }
    }
}