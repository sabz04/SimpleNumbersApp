using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class HelloWorld
{

    static void Main()
    {
        
        int n, i = 0;
        Random rand_Num = new Random();

        Console.WriteLine("Enter n: ");
        n = int.Parse(Console.ReadLine());
        int[] mas = new int[n];
        Console.WriteLine();
        while (i < n)
        {
            int number = Get_Rand();
            if (number == 0)
                continue;
            if (Math.Abs(number) > 1 && Get_Simple(number))
            {
                if (mas.Any(x => x == number))
                    continue;
                mas[i] = number;
               
                i++;
            }
            else
            {
                continue;
            }
        }
        
        string str = "\nRESULT:\n";
        for (int j = 0; j < n; j++)
        {
            str += $"| {mas[j]} |\n";
        }
        Console.WriteLine(str);

    }
   
    

    static int Get_Rand()
    {
        Random rand = new Random();
        return rand.Next(-1000, 1000);
    }
    static bool Get_Simple(int number)
    {
        bool flag = true;
        int i = 2;
        while (i < Math.Abs(number))
        {
            if(number == 2)
            {
                break;
            }
            if (number % i == 0)
            {
                flag = false;
                break;
            }

            i++;
        }
        if (flag) {
            Console.WriteLine("YES\t" + number);
            
        }
        if (!flag)
            Console.WriteLine("NO\t" + number);
        return flag;
    }
    static int Get_Simple_HALF(int number)
    {
        bool flag = true;
        int i = 2;
        while (i < 10)
        {
            if (number == 2)
            {
                break;
            }
            if (number % i == 0)
            {
                flag = false;
            }

            i++;
        }
        if (flag)
        {
            return number;
        }
        return 0;
        
    }
}
