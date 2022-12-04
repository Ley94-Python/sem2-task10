//  Напишите программу, которая выводит случайное трехзначное число и показывает вторую цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1


int number = new Random().Next(100, 999);
Console.WriteLine($"Введите трехзначное число {number}:");
int numberA = number/100;    
int numberB = number/10;
int result = numberB - numberA*10;
Console.WriteLine($"Получается число {result}"); 


