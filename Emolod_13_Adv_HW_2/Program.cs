using System;
using System.Linq;
using System.Text;

namespace Emolod_13_Adv_HW_2;

public static class Program
{
    static int readNum(string message)
    {
        while (true)
        {
            Console.WriteLine(message);

            string input = Console.ReadLine().Trim();
            if (int.TryParse(input, out int number))
            {
                return number;
            }

            Console.WriteLine("\nВведене вами значення не є числом.");
        }
    }

    static string readString(string message)
    {
        while (true)
        {
            Console.WriteLine(message);

            string input = Console.ReadLine().Trim();
            if (input != "")
            {
                return input;
            }

            Console.WriteLine("\nВведене вами значення є порожнім.");
        }
    }

    public static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        int program = readNum("Введіть номер програми(згідно д/з):");

        if (program == 1)
        {
            Random random = new Random();

            int[][] numbers = new int[10][];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = new int[10];
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    numbers[i][j] = random.Next(10, 99);
                }
            }

            int min = readNum("\nВведіть мінімальне число для пошуку:");
            int max = readNum("\nВведіть максимальне число для пошуку:");


            Console.WriteLine("\nЗнайдені числа:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (numbers[i][j] > min && numbers[i][j] < max)
                    {
                        Console.Write(numbers[i][j] + " ");
                    }
                }
            }

            Console.WriteLine("\n\nТакож числа, кратні 5:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (numbers[i][j] % 5 == 0)
                    {
                        Console.Write(numbers[i][j] + " ");
                    }
                }
            }
        }
        else if (program == 2)
        {
            Random random = new Random();

            int[] numbers = new int[100];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100, 900);
            }

            int firstMin = int.MaxValue;
            foreach (int number in numbers)
            {
                if (number < firstMin)
                {
                    firstMin = number;
                }
            }

            int secondMin = int.MaxValue;
            foreach (int number in numbers)
            {
                if (number > firstMin && number < secondMin)
                {
                    secondMin = number;
                }
            }

            Console.WriteLine("\nДруге найменше число в масиві: " + secondMin);
        }
        else if (program == 3)
        {
            string input = readString("\nВведіть текст англійською:").ToLower();

            int[] letterCounts = new int[26];
            foreach (char c in input)
            {
                if (c >= 'a' && c <= 'z')
                {
                    int index = c - 'a';

                    letterCounts[index]++;
                }
            }

            Console.WriteLine("\nСтатистика:");
            Console.WriteLine("-----------");
            for (int i = 0; i < letterCounts.Length; i++)
            {
                if (letterCounts[i] > 0)
                {
                    char letter = (char)(i + 'a');
                    Console.WriteLine("Літера '" + letter + "': " + letterCounts[i] + " повторів");
                }
            }
        }
        else if (program == 4)
        {
            Random random = new Random();

            int[] numbers = new int[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(10, 99);
            }

            int maxSum = 0;
            int maxIndex = 0;
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                int currentSum = numbers[i] + numbers[i + 1] + numbers[i + 2];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxIndex = i;
                }
            }

            Console.WriteLine("\nНайбільша сума послідовності: " + maxSum);
            Console.WriteLine($"Індекси послідовності: {maxIndex}, {maxIndex + 1}, {maxIndex + 2}");
            Console.WriteLine($"Числа послідовності: {numbers[maxIndex]}, {numbers[maxIndex + 1]}, {numbers[maxIndex + 2]}");
        }
    }
}
