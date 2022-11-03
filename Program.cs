// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите натуральное число от 1 до 7");
int x=Convert.ToInt32 (Console.ReadLine());
if (x==1) Console.WriteLine("no");
else if (x==2) Console.WriteLine("no");
else if (x==3) Console.WriteLine("no");
else if (x==4) Console.WriteLine("no");
else if (x==5) Console.WriteLine("no");
else if (x==6) Console.WriteLine("yes");
else if (x==7) Console.WriteLine("yes");
else Console.WriteLine("Вы ввели число некоретный день недели");