// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
namespace Seminar4
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите число А:");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B:");
            int numberB = Convert.ToInt32(Console.ReadLine());
            
            // выводим на экран искомое значение, результат получаем через вызов метода Exponent описанный ниже
            Console.WriteLine($"{numberA} в степени {numberB} = {Exponent(numberA, numberB)}");
        }
        // Создаем метод, который возвращает значение числа А в степени В, 
        // возведение в нужную степень выполняем в цикле
        public static int Exponent (int numA, int numB)
        {
            int exponentiation = 1;
            for (int i = 1; i <= numB; i++)
            {
                exponentiation = exponentiation * numA;
            }
            return exponentiation;
        }
    }
}