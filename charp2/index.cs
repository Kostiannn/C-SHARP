using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введіть число від 1 до 3, що відповідає символу, який буде використовуватися для друкування ромбу:");
        Console.WriteLine("1 - *");
        Console.WriteLine("2 - #");
        Console.WriteLine("3 - $");

        int symbol = 0;

        while (symbol != 1 && symbol != 2 && symbol != 3)
        {
            Console.Write("Введіть число: ");
            symbol = Convert.ToInt32(Console.ReadLine());

            if (symbol != 1 && symbol != 2 && symbol != 3)
            {
                Console.WriteLine("Помилка: введене число повинно бути 1, 2 або 3.");
            }
        }

        Console.Write("Введіть ширину ромбу: ");
        int width = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть висоту ромбу: ");
        int height = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= width; j++)
            {
                if (i == (height + 1) / 2 || j == (width + 1) / 2 || i + j == (height + width + 1) / 2 || i + width - j == (height + width + 1) / 2)
                {
                    switch (symbol)
                    {
                        case 1:
                            Console.Write("*");
                            break;
                        case 2:
                            Console.Write("#");
                            break;
                        case 3:
                            Console.Write("$");
                            break;
                    }
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
