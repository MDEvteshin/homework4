// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// // которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// Console.WriteLine("Enter size of array");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("this is your array: ");
// PrintArray(numbers);
// int count = 0;

// for (int z = 0; z < numbers.Length; z++)
// if (numbers[z] % 2 == 0)
// count++;

// Console.WriteLine($"Total {numbers.Length} numbers, {count} of this numbers are even");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// // стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0
// System.Console.WriteLine($"Enter size of array");
// int a = Convert.ToInt32(Console.ReadLine());
// int [] randomArray = new int[a];

// void ar (int a){
//     for (int i = 0; i < a; i++)
//     {
//         randomArray[i] = new Random().Next (1,9);
//         System.Console.Write(randomArray[i] + " ");
//     }
// }
// int kol(int[] randomArray)
//     {
//     int sum = 0;
//     int i = 0;
//     while (i < randomArray.Length)
//         {
//             sum = sum + randomArray[i];
//             i = i + 2;
//         }
//         return sum;
//     }
// ar(a);
// System.Console.WriteLine($"Sum elements which staied on non even positions: {kol(randomArray)}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("Enter da array");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("This is your array: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"Total numbers {numbers.Length}. Max number = {max}, Min number = {min}");
Console.WriteLine($"Difference between max and min = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}


