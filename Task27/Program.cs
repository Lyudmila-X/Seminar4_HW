// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
namespace Seminar4Task27
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите число:");
            string number = Console.ReadLine()!;
            // выводим результат, сумму всех цифр числа получаем вызовом метода Summation который описан ниже
            Console.WriteLine($"Сумма цифр заданного числа равна {Summation(number)}");
        }
        public static int Summation(string num)
        {
            int sum = 0;
            // создаем цикл, который перебирает цифры числа по порядку и прибавляет текущую цифру к общей сумме
            for (int i = 0; i < num.Length; i++)
            {
                // Преобразуем символ строки в число и прибавляем его к сумме цифр
                sum = sum + int.Parse(num[i].ToString());
            }
            return sum;
        }

    }
}