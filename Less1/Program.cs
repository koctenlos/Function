// int x=10;

// if (x > 5)
// {
//     Console.WriteLine(x);
// }

// while (x>5)
// {
//     Console.WriteLine(x);
//     x=x-1;
// }

// for (int i=1; i<10; i++)
// {
//     Console.WriteLine(i);
// }

// // 11. Напишите программу, которая выводит случайное
//  трёхзначное число и удаляет вторую цифру
//   этого числа.

Console.Clear();
int x = new Random().Next(99, 1000);
Console.WriteLine(x);

int temp = x % 10;
int temp2= x/100;

Console.Write(temp2);
Console.WriteLine(temp);
















