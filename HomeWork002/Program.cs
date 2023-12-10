//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число");
int n1 = Convert.ToInt32 (Console.ReadLine());
int n2 = 7;
int n3 = 23;

if (n1%n2 == 0 && n1%n3==0)
   Console.WriteLine("yes");
else 
   Console.WriteLine("no");

// Задача 2. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
//выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());
 
Console.WriteLine("Введите y: ");
 double y = Convert.ToDouble(Console.ReadLine());
 
          if (x > 0)
            {
               if (y > 0)
                    Console.WriteLine("I четверть");
                else if (y < 0)
                    Console.WriteLine("IV четверть");
            }
            else if (x < 0)
            {
                if (y > 0)
                    Console.WriteLine("II четверть");
                else if (y < 0)
                   Console.WriteLine("III четверть");
            }
 
//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.


int b = new Random().Next(10, 90);
Console.WriteLine(b);
int b1=b/10;
int b2=b%10;
if (b1>b2)
{
    Console.WriteLine(b1);
}
else
{
Console.WriteLine(b2);
}



//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.


        Console.WriteLine("Введите натуральное число N:");
        int number = int.Parse(Console.ReadLine());
        
        string digits = GetDigits(number);
        
        Console.WriteLine(" " + digits);
        
    static string GetDigits(int number)
    {
        string result = "";
        
        while (number > 0)
        {
            int digit = number % 10;
            result = digit + (result != "" ? ", " + result : "");
            number = number / 10;
        }
        
        return result;
    }