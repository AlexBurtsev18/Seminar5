// // Начало урока

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Task 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных элементов массива.

// int GetSimOfNegativs(int[] array)
// {
//     int sum = 0;

//     for(int i =0; i<array.Length; i++)
//         if(array[i]<0) 
//             sum += array[i];   // sum = sum + array[i]
//     return sum;
// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);
// Console.WriteLine("Sum of negative elements is " + GetSimOfNegativs(myArray));


// TASK 1. Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// int[] MakePositive(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = array[i] * (-1);
//     return array;
// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minimum possible element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a maximum possible element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);
// MakePositive(myArray);
// ShowArray(myArray);

// TASK 2. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// bool HaveChosenNumber(int number, int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             Console.WriteLine($"There is such number in the current array.");
//             return true;
//         }
//     }
//     Console.WriteLine($"There is NO such number in the current array.");
//     return false;

// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minimum possible element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a maximum possible element: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input chosen number, please: ");
// int chosenNum = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, min, max);
// ShowArray(array);
// HaveChosenNumber(chosenNum, array);

// TASK 3. Задайте одномерный массив из m случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

// int QuantityOfElements(int[] array, int min, int max)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] <= max && array[i] >= min) count++;
//     return count;
// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minimum possible element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a maximum possible element: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input lower boarder, please: ");
// int boarderA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input top boarder, please: ");
// int boarderB = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, min, max);
// ShowArray(array);
// Console.WriteLine("The quantity of elements between boarders: " + QuantityOfElements(array, boarderA, boarderB));


// HOMEWORK. 
// Task 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}

int[] array = new int[5];
int count = 0;
for(int z = 0; z < array.Length; z++)
    if(array[z] % 2 == 0) count++;

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"всего {array.Length} чисел, {count} из них чётные");


// Console.WriteLine("Введите размер массива:  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("массив: ");
// PrintArray(numbers);
// int count = 0;

// for (int z = 0; z < numbers.Length; z++)
// if (numbers[z] % 2 == 0)
// count++;

// Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

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
