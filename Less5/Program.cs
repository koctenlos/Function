// Напиши программу, где вводим три числа, 
// а потом выводим сумму только положительных чисел.
Console.Clear();
Console.Write("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c: ");
int c = Convert.ToInt32(Console.ReadLine());
int a1=0;
int b1=0;
int c1=0;
if(a>0){
    a1=a;
}
else{
    a=0;
}

if(b>0){
    b1=b;
}
else{
    b=0;
}

if(c>0){
    c1=c;
}
else{
    c=0;
}
Console.WriteLine($"Сумма чисел {a1+b1+c1}");