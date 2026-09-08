//Console.Write("Какой ты 67 ");
//string userName = Console.ReadLine();
//Console.WriteLine($"Привет, {userName}!");
//
//string input = "67";
//
//
//int a = Convert.ToInt32(input);
//int b = int.Parse(input);
//bool ok = int.TryParse(input, out int c);

using System.Linq.Expressions;

Console.WriteLine("Границы целочисленных типов");
Console.WriteLine($"byte: {byte.MinValue} ..{byte.MaxValue}>");
Console.WriteLine($"short:{short.MinValue}..{short.MaxValue}");
Console.WriteLine($"int;{int.MinValue}..{int.MaxValue}");

Console.WriteLine();
Console.WriteLine("Границы дробных типов");
Console.WriteLine($"float:{float.MinValue}..{float.MaxValue}");
Console.WriteLine($"double:{double.MinValue}..{double.MaxValue}");
Console.WriteLine($"decimal:{decimal.MinValue}..{decimal.MaxValue}");
Console.WriteLine();
Console.WriteLine("Перевыполнение byte");

byte maxByte = 255;
byte overflowed = (byte)(maxByte + 1);
Console.WriteLine($"255 + 1 для byte ={overflowed}");

