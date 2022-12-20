// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.

Console.WriteLine ("Введите первое число");
int firstDigit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число");
int secondDigit = Convert.ToInt32(Console.ReadLine());

if (firstDigit%secondDigit == 0)
{
    Console.WriteLine ("Это кратное число");
}
else 
{
    Console.WriteLine ("Результат");
    Console.WriteLine (firstDigit%secondDigit);
}

