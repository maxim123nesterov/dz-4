/* 
В данной задаче описал 2 способа:
1 способ - вставляются рандомные числа
2 способ - числа вводятся самостоятельно
*/

int n = 8;
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
array[i] = new Random().Next(0, 99);
Console.Write($"{array[i]} ");
}

/*int n = 8;
int[] array = {1, 2, 3, 4, 5, 6, 7, 8};
for (int i = 0; i < n; i++)
{
    Console.Write($" {array[i]}");
}*/