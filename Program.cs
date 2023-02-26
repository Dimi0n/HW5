// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

int[]myArray = new int[10];
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = new Random().Next(0,1000);
}
System.Console.WriteLine("Массив случайных чисел: ");
System.Console.WriteLine(string.Join(" ", myArray));
System.Console.WriteLine();
int []myArray2 = Array.FindAll(myArray,i=>i%2==0).ToArray();
int result = myArray2.Length;
System.Console.WriteLine("Kоличество чётных чисел в массиве--->  "+ result);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[]myArray = new int[10];
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = new Random().Next(0,50);
}
System.Console.WriteLine("Массив случайных чисел: ");
System.Console.WriteLine(string.Join(" ", myArray));
System.Console.WriteLine();
int []myArray2 = Array.FindAll(myArray,i=>i%2!=0).ToArray();
int result = myArray2.Sum();
System.Console.WriteLine("Сумма нечетных чисел массива ---> " + result);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
//  элементов массива. [3 7 22 2 78] -> 76

int [] myArray = {2,44,5,38,56,99,4,77};
int a = myArray.Min();
int b = myArray.Max();
int res = b-a;
System.Console.WriteLine(res);
