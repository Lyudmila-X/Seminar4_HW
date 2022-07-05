// Задача 29: Напишите программу, которая задаёт случайный массив случайного размера (от 5 до 10) элементов 
// (значение элементов от -15 до 15) и выводит на экран массив квадратов этих чисел.
// 1, 2, 5, 7, 19 -> [2, 4, 25, 49, 361]
// 6, 1, 33 -> [36, 1, 1089]
namespace Seminar4Task29
{
    class Program
    {
        public static void Main()
        {
            // Создаем массив и произвольно заполняем его с помощью метода GetArray описанного ниже в коде
            int [] randomArray = GetArray();
            Console.WriteLine("Исходный массив:");
            
            // Выводим получившийся массив с помощью метода PrintArray описанного в коде ниже
            PrintArray(randomArray);
            Console.WriteLine();
            Console.WriteLine("Массив квадратов чисел исходного массива:");

            // Выводим квадрат элементов массива, который получается вызовом метода SqrArray, который описан в коде ниже
            PrintArray(SqrArray(randomArray));
        }
        // создаем метод, который создает массив произвольного размера (от 5 до 10 элементов)
        // и заполняем его элементами произвольных значений от -15 до 15
        public static int [] GetArray ()
        {
            int size = new Random().Next(5,11);
            int [] array = new int [size];
            for (int i=0; i<size; i++)
            {
                array[i] = new Random().Next(-15,16);
            }
            return array;
        }
        // Создаем метод для вывода массива
        public static void PrintArray (int [] arrayToPrint)
        {
            for (int i=0; i<arrayToPrint.Length; i++)
            {
                Console.Write($"{arrayToPrint[i]} ");
            }
        }
        // Создаем метод по возведению в квадрат чисел массива
        public static int [] SqrArray (int [] inputArray)
        {
            int [] squaring = new int [inputArray.Length];
            for (int i=0; i<inputArray.Length; i++)
            {
                squaring [i] = inputArray[i]*inputArray[i];
            }
            return squaring;
        }
    }
}