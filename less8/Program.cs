// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день 
// недели, и проверяет, является ли 
// этот день выходным.

Console.Clear();
Console.Write("Введите цифру дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a>=1 & a<=5){
    Console.WriteLine("Нет ");
}
else if (a>=5 & a<=7){
    Console.WriteLine("Да");
}
else if (a<1 | a>7){
    Console.WriteLine("Неверно указан день");
}
