using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            int rightDivisor = 10;
            bool found = false;

            while (rightDivisor < number)
            {
                int midDivisor = rightDivisor * 10;

                while (midDivisor < number)
                {
                    int right = number % rightDivisor;
                    int mid = (number % midDivisor) / rightDivisor;
                    int left = number / midDivisor;

                    if (left + right == mid)
                    {
                        Console.WriteLine($"Расчет: {left} + {right} = {mid}");
                        found = true;
                        break;
                    }

                    midDivisor *= 10;
                }

                if (found) break;
                rightDivisor *= 10;
            }

            if (!found)
            {
                Console.WriteLine("Разбить число по заданному условию невозможно");
            }

            Console.WriteLine("");
        }
    }
}
