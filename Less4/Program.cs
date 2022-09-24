// Напиши программу, которая по введённому возрасту 
// пользователя сообщает, к какой возрастной группе 
// он относится:
// до 13 включительно – детство;
// от 14 до 24 – молодость;
// от 25 до 59 – зрелость;
// от 60 – старость.


Console.Clear();
Console.Write("Введите возраст: ");
int age = Convert.ToInt32(Console.ReadLine());

if(age>=0 & age<=13)
{
    Console.WriteLine("Детство");
}
else if(age>=14 & age<=24)
{
      Console.WriteLine("молодость");
}
else if (age>=25 & age<=59)
{
      Console.WriteLine("зрелость");
}
else if(age>=60)
{
      Console.WriteLine("старость");
}