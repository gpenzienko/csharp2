//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
Console.WriteLine("Введите число: ");
int numberA= Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(numberA);
if (stringNumber.Length > 2 )
{
    Console.WriteLine("Третьей цифрой данного числа является "+stringNumber[2]);
}
else 
Console.WriteLine("Третьей цифры нет");