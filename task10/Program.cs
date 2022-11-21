//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число: ");
int numberA= Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(numberA);
Console.WriteLine("Второй цифрой числа является "+stringNumber[1]);
