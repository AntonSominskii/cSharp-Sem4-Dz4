// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
namespace Task27;
class Program
{
    static void Main(string[] args)
    {

        string ReadNumberTooString(string message) //Функция принимает число и преобразует его в строку. 
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        int SumSymbolsInNumber(string number) //Функция разбирает строку на символы, конвентирует их в int, а затем суммирует между собой. Работает и с отрицательными значениями.
        {
            int sum = 0;
            if (number[0] != '-'){
                for (int i=0; i < number.Length; i++){
                    char a = number[i];
                    sum += a - '0';
                }
            }
            if (number[0] == '-'){
                for (int i=1; i < number.Length; i++){
                    char a = number[i];
                    sum += a - '0';
                }
            }
            return sum;
        }

        string str = ReadNumberTooString("Программа выдаёт сумму цифр в числе.\nВведите число:");
        Console.WriteLine(SumSymbolsInNumber(str));    
    }
}
