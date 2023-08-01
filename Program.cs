// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int size = 3;
// int count = 0;
// int[] array = new int[size];
// for (int i = 0; i < size; i++)
// {
// array[i] = new Random().Next(100, 999);
// if (array [i] % 2)
// {
// count++
// }
// Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
// Console.WriteLine($"Всего четных чисел: {count}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int sumEven = 0;
// int[] GetArray (int size; int min; int max) ;
// {
// int [] array = new int [size];
// for (int i = 0;i<size; i++)
// {
// array [i] = New random (). Next (100;999);
// }
// return array;
// void PrintArray(int[] array);
// void GetSum (int[] array) ;
// for (int i = 2;i<size; i+2)
// {
// sumEven = sumEven + array [i] ;
// }
// Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
// Console.WriteLine($"Всего сумма четных чисел: {sumEven}");
// }

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double[] randomArray = new double[a];
// double min = Convert.ToInt32(min);
// double max = Convert.ToInt32(max)
// void NewArray(int a)
// {
// Random rand = new Random();
// for (int i = 0; i < a; i++)
// {
// randomArray[i] = rand.NextDouble();
// if (array[i] > 0)
// {
// max < array[i];
// max = array[i]
// }
// else
// {
// min > array[i];
// min = array [i]
// }
// }
// void[] GetCalculation (double[] calc)
// {
// calc= max - min;
// }
// return calc;
// Console.WriteLine($"Разница между {max} и {min} : {calc}");
