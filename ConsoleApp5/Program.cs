using System;



class Program
{

    static void Main()
    {

        Console.Write("Введіть число Х: ");

        int x = int.Parse(Console.ReadLine());



        if (x < 1)
        {

            Console.WriteLine("Помилка: введене число менше 1.");

        }

        else
        {

            int a = 0;

            int b = 1;



            Console.Write(a + " " + b + " ");



            for (int i = 2; i < x; i++)
            {

                int c = a + b;

                Console.Write(c + " ");

                a = b;

                b = c;

            }

        }

    }

}