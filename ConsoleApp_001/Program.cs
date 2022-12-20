// НАПИШИТЕ ПРОГРАММУ, КОТОРАЯ ВЫВОДИТ СЛУЧАЙНОЕ ЧИСЛО ИЗ ОТРЕЗКА [10, 99]
// И ПОКАЗЫВАЕТ НАИБОЛЬШУЮ ЦИФРУ ЧИСЛА

// СЛУЧАЙНОЕ ЧИСЛО 
 int number = 69;

// ПЕРВАЯ ЦИФРА ЧИСЛА number | firstDigit = первая цифра 
 int firstDigit = number / 10; // делим чтобы получить 1 цифру из 2-х значного числа

// ВТОРАЯ ЦИФРА ЧИСЛА number | secondDigit = вторая цифра
 int secondDigit = number % 10; //

  Console.WriteLine($"Случайное число: {number}");

  if (firstDigit > secondDigit)
  {
    Console.WriteLine($"Наибольшая цифра числа: {firstDigit}");
  }

  if (secondDigit > firstDigit)
  {
    Console.WriteLine($"Наибольшая цифра числа: {secondDigit}");
  }

  if (firstDigit == secondDigit)
  {
    Console.WriteLine("Цифры в числе равны");
  }