// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());
int a1 = a/100;
a=a%10;
if(a1>=1){
    Console.WriteLine($"Третье число {a} ");
}
else{
    Console.WriteLine("Третьей цифры нет ");
}