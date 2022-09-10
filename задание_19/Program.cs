// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int reverse = number;
int result = 0;
if(number > 99999 && number < 10000)
{
    Console.WriteLine("Введено не пятизначное чисто");
}
else
{
    while(reverse > 0)
    {
        int digit = reverse % 10;
        result = result * 10 + digit;
        reverse = reverse / 10;
    }
    if(number == result)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
