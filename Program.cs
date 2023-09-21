//Напишите программу, которая
//1. принимает на вход три числа и
//2. выдает максимальное из этих чисел
//3. вывод результата

//Например
//2, 3, 7 -> 7
//44, 5, 78 -> 78
//22, 3, 9 -> 22

Console.WriteLine("Введите три числа, и узнайте");
Console.WriteLine("какое из них максимальное");
Console.Write("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число");
int num3 = int.Parse(Console.ReadLine());
int maxNum = 0;
if (num1 > maxNum) maxNum = num1;
if (num2 > maxNum) maxNum = num2;
if (num3 > maxNum) maxNum = num3;
Console.Write("Максимальное число" + maxNum);
