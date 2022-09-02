// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// Console.WriteLine($"Сумма цифр = {GetSumNums2(num)}");

// int GetSumNums1(int number)
// {
//     // 1+1
//     int sum = 0;
//     while (number > 0)
//     {
//         sum += number % 10;
//         number /= 10;
//     }
//     return sum;
// }

// int GetSumNums2(int number)
// {
//     int result = 0;
//     for (int i = 1; i <= number; i++)
//     {
//         result += i;
//     }
//     return result;
// }

// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

// Console.WriteLine("Enter number... ");
// int number = int.Parse(Console.ReadLine());
// int index = 0;

// while(number > 0)
// {
//     number = number/10;
//     index++;
// }

// Console.WriteLine(index);




// второй метод решения задачи:

// Console.WriteLine("Enter number... ");

// string num = Console.ReadLine();
// int count = num.Length;
// Console.WriteLine("Количество цифр в числе: " +count);


// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


// void factorialdigit(string? data)

// {
//     ulong num;
//     while (true)
//     {
//         if (ulong.TryParse(data, out num))
//         {
//             break;

//         }
//         else
//         {
//             Console.WriteLine("Error to enter");
//             data = Console.ReadLine();
//     }
// }
// ulong result = 1;
// for (ulong i = 2; i <= num; i++)
// {
//     result*=i;
// }
// Console.WriteLine($"произведение чисел {result}");
// }

// Console.WriteLine("Enter number... ");
// factorialdigit(Console.ReadLine());


// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];


for(int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(0,2);
    Console.Write(array[i]+" ");
}

