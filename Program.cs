// Напишите программу, которая на вход
// принимает число и выдает его квадрат (число
// умноженое на само себя)
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
// Console.Write("Enter nuber: ");
// convert = конвертирует string в другую переменную
// int number = Convert.ToInt32( Console.ReadLine());

// int value = number * number;

// System.Console.WriteLine("квадрат числа:" + value);

// Напишите программу, которая на вход принимает два 
// числа и проверяет, является ли первое число квадратом
// второго.
// Например:
// а = 25, в = 5 -> да
// а = 2, в = 10 -> нет
// а = 9, в = -3 -> да
// а = -3, в = 9 -> нет 

// System.Console.Write("Enter first number : ");
// int squareNumber = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter second number : ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (squareNumber == (number * number))
// { 
//    Console.WriteLine( "Yes");   
//}
// else
// {
//    Console.WriteLine( "No");     
// }

//  Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// Например:
// 3 -> Среда
// 5 -> Пятница

// Console.Write("Enter number : ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number >= 1 && number <= 7)
// {

 // switch(number)
  //   {
   //  case 1: System.Console.WriteLine("День недели : Понедельник"); break;

   // case 2: System.Console.WriteLine("День недели : Вторник"); break;

   // case 3: System.Console.WriteLine("День недели : Среда"); break;

   // case 4: System.Console.WriteLine("День недели : Четверг"); break;
     
  //  case 5: System.Console.WriteLine("День недели : Пятница"); break;

   // case 6: System.Console.WriteLine("День недели : Суббота"); break;

 //   case 7: System.Console.WriteLine("День недели : Воскресенье"); break;
    
  //  default: System.Console.WriteLine("Bad number"); break;
  //  }
//}

// напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые 
// числа в промежутке от -N до N.
// Например: 
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

// Console.Write("Enter number : ");

// int number = Convert.ToInt32(Console.ReadLine());

// int number2 = -number;

// while(number2 <= number){

    //Console.Write($"{number2},");
// Console.Write(number2 + ",");

// ++number2;

// }

// Напишите программу, которая принимает на вход
// трехзначное число и на выходе показывает последнюю цифру
// этого числа.
// Например:
// 456 -> 6
// 782 -> 2

Console.Write("Enter number : ");

int number = Convert.ToInt32(Console.ReadLine());

if(((number / 100) > 0) && ((number / 1000) < 1) ){
    int LastNumber = number % 10;
    System.Console.WriteLine( "Last number : "+ LastNumber);
}
    else{
        System.Console.WriteLine("Bad number");
    }