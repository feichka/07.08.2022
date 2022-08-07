/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

Console.WriteLine("Задайте количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[]array = new double[n];
for (int i=0; i<n; i++)
array[i] = new Random().NextDouble();
Console.WriteLine("[" + string.Join(";", array) + "]");
double max = 0;
double min = array[n-1];
for (int i=0; i<n; i++)
{
        if (array[i] > max)
        max = array[i];

        if (array[i] < min)
        min = array[i];
}
Console.WriteLine("Разница между максимальным и минимальным элементом равна " + (max-min));
