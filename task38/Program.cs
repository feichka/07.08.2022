/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

Console.WriteLine("Задайте количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[]array = new int[n];

for (int i=0; i<n; i++)
array[i] = new Random().Next(0,101);
Console.WriteLine("[" + string.Join(",", array) + "]");
int max = 0;
int min = array[n-1];
//int dif = 0;
for (int i=0; i<n; i++)
{
        if (array[i] > max)
        max = array[i];

        if (array[i] < min)
        min = array[i];

        //dif = max - min;
 }

//Console.WriteLine(max);
//Console.WriteLine(min);
Console.WriteLine("Разница между максимальным и минимальным элементом равна " + (max-min));
