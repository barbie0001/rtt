using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1. Игра 'Угадай число'");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выход");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    GuessNumber();
                    break;
                case 2:
                    MultiplicationTable();
                    break;
                case 3:
                    FindDivisors();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Выбор неправельный.Попробуй еще раз");
                    break;
            }
        }
    }

    static void GuessNumber()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101);
        while (true)
        {
            Console.Write("Введите число от 0 до 100: ");
            int userNumber = int.Parse(Console.ReadLine());
            if (userNumber == randomNumber)
            {
                Console.WriteLine("Вы угадали число!");
                return;
            }
            else if (userNumber < randomNumber)
            {
                Console.WriteLine("Число больше");
            }
            else
            {
                Console.WriteLine("Число меньше");
            }
        }
    }

    static void MultiplicationTable()
    {
        int[,] table = new int[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                table[i, j] = (i + 1) * (j + 1);
            }
        }
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write("{0,4}", table[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void FindDivisors()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Делители числа {0}: ", number);
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}