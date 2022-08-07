/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

Console.WriteLine("Задайте количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[]array = new int[n];
int sum = 0;
for (int i=0; i<n; i++)
array[i] = new Random().Next(1,11);
Console.WriteLine("[" + string.Join(",", array) + "]");
for (int i=0; i<n; i++)
    {
        if (i % 2 == 0)
        sum += array[i];
    }
Console.WriteLine(sum);

