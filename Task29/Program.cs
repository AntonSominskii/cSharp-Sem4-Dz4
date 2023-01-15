// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем
namespace Task29;
class Program
{
    static void Main(string[] args)
    {
        int [] NumberTooArray(string message) //Функция принимает 8 чисел, помещает их в массив, после выводит значения массива в терминал. 
        {
            Console.WriteLine(message);

            int[] numbers = new int[8];
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < numbers.Length; ++i){
            numbers[i] = int.Parse(input[i]);
            }

            Console.WriteLine("Вы ввели:");          
            for (int i = 0; i < 7; i++){ // написал так код, чтобы не было запятой в конце
            Console.Write(numbers[i] + ", ");
            }
            Console.Write(numbers[7]);
            return numbers;
        }

        int [] array = NumberTooArray("Введите 8 чисел массива через пробел:");
    }
}
