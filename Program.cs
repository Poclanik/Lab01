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

//using System.Linq.Expressions;
//
//Console.WriteLine("Границы целочисленных типов");
//Console.WriteLine($"byte: {byte.MinValue} ..{byte.MaxValue}>");
//Console.WriteLine($"short:{short.MinValue}..{short.MaxValue}");
//Console.WriteLine($"int;{int.MinValue}..{int.MaxValue}");
//
//Console.WriteLine();
//Console.WriteLine("Границы дробных типов");
//Console.WriteLine($"float:{float.MinValue}..{float.MaxValue}");
//Console.WriteLine($"double:{double.MinValue}..{double.MaxValue}");
//Console.WriteLine($"decimal:{decimal.MinValue}..{decimal.MaxValue}");
//Console.WriteLine();
//Console.WriteLine("Перевыполнение byte");
//
//byte maxByte = 255;
//byte overflowed = (byte)(maxByte + 1);
//Console.WriteLine($"255 + 1 для byte ={overflowed}");
//Console.WriteLine();
//Console.WriteLine("Ввод чисел: Convert и Parse");
//
//Console.WriteLine("Введите ваш год рождения");
//string birthYearInput  = Console.ReadLine();
//
//int birthYearConvert = Convert.ToInt32(birthYearInput);
//int birthYearParse = int.Parse(birthYearInput);
//
//Console.WriteLine($"Convert.ToInt32:{birthYearConvert}");
//Console.WriteLine($"int.Parse:      {birthYearParse}");
//Console.WriteLine($"В 2030 году вам будет: {2030 - birthYearConvert}лет ");

Console.WriteLine();
Console.WriteLine("Ввод чисел: TryParse");

Console.Write("Введите количество прочитанных книг за семестр:");
string bookInput = Console.ReadLine();

bool wasSuccessful = int.TryParse(bookInput, out int bookCount);

Console.WriteLine($"Удалось преобразовать: {wasSuccessful}");
Console.WriteLine($"Значение переменной booksCount: {bookCount}");


