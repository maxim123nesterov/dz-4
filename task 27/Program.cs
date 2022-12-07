Console.Write("Введите число трёх значное число - ");
int a = Convert.ToInt32(Console.ReadLine());
//int b = a % 10;
int i = a % 10;
int sum = 0;
//int c = (a / 10) % 10;
//it d = a / 100;
//int sum = b + c + d;

for  (i = a % 10; i <= a; i ++)
{
    sum = sum + i;
    
    Console.WriteLine(sum);
    return;
}
/*Console.WriteLine();
Console.WriteLine(b);
Console.WriteLine();
Console.WriteLine(c);
Console.WriteLine();
Console.WriteLine(d);
Console.Write($"Сумма цифр в числе = {sum}");*/