// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

namespace Task25;
class Program
{
    static void Main(string[] args)
    {
        int ReadNumber(string message) //Функция принимает число и преобразует его в int. 
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        int PowNumbers(int num1, int num2)  // Функция принимает два числа и возводит первое в натуральную степень значения второго.
        {
            int pow = num1;

            for (int i = 1; i < num2; i++){
                pow = pow * num1;
            }
            return pow;
        }

        int a = ReadNumber("Введите число A:");
        int b = ReadNumber("Введите число B:");
     
        Console.WriteLine("A в натуральной степени B равно: " + PowNumbers(a,b));
    }
}
