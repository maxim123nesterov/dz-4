Console.Write("Введите число - ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (a > 0)
{
 a = a % 10;
 sum = sum + a;
    } 
Console.WriteLine(sum);

/*int c = (a / 10) % 10;
//it d = a / 100;
//int sum = b + c + d;
Console.Write($"Сумма цифр в числе = {sum}");*/