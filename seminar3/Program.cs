// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.


// Console.Write("Введите X: ");
// int X = int.Parse(Console.ReadLine());

// Console.Write("Введите Y: ");
// int Y = int.Parse(Console.ReadLine());

// if (X > 0 && Y > 0)
// {
//     Console.WriteLine("1 четверть");
// }
// else if (X < 0 && Y > 0)
// {
//     Console.WriteLine("2 четверть");
// }
// else if (X < 0 && Y < 0)
// {
//     Console.WriteLine("3 четверть");
// }
// else if (X > 0 && Y < 0)
// {
//     Console.WriteLine("4 четверть");
// }

// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y)
//  вариант 1:

// Console.Write("Введите четверть: ");
// int quaternumber = int.Parse(Console.ReadLine()); строку преобразовывает в цифру
// if (quaternumber == 1)
// {
//     Console.WriteLine("x > 0; y > 0");
// }
// else if (quaternumber == 2)

//     Console.WriteLine("x < 0; y > 0");
// else if (quaternumber == 3)
// {
//     Console.WriteLine("x < 0; y < 0");
// }
// else if (quaternumber == 4)
// {
//     Console.WriteLine("x > 0; y < 0");
// }
// else
// {
//     Console.WriteLine("Bug Error");
// }

// вариант 2:

// Console.Write("Введите четверть: ");
// int quarter = Convert.ToInt32(Console.ReadLine());

// switch (quarter)
// {
//     case 1:
//         Console.WriteLine("x > 0; y > 0");
//         break;
//     case 2:
//         Console.WriteLine("x < 0; y > 0");
//         break;
//     case 3:
//         Console.WriteLine("x < 0; y < 0");
//         break;
//     case 4:
//         Console.WriteLine("x < 0; y < 0");
//         break;
//     default:
//         Console.WriteLine("Bug Error");
//         break;
// }

// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Enter x1...");
// int x1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter y1...");
// int y1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter x2...");
// int x2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter y2...");
// int y2 = int.Parse(Console.ReadLine());

// double result = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));

// Console.WriteLine($"A({x1},{y1}); b ({x2},{y2}) ->{result}");

// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Enter number...");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Таблица квадратов");

// for(int i = 1; i<= number; i++)
// {
//     Console.WriteLine(Math.Pow(i,2));
// }
