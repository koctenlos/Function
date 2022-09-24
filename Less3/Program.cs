// Stanislav N: 16. Напишите программу, 
// которая принимает на вход два числа и 
// проверяет, является ли одно число 
// квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if(a*a==b | b*b==a){
    Console.WriteLine("да");
}
else{
Console.WriteLine("Нет");
}
