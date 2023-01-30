// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

(int[], int) GetArrAndTotal(int size, int firstNum, int lastNum)
{
    int[] arr = new int[size];
    int count = 0;
    for (int index = 0; index < size; index++)
    {
        arr[index] = new Random().Next(firstNum, lastNum + 1);
        if (arr[index] % 2 == 0)
            count++;
    }
    return (arr, count);
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int index = 0; index < arr.Length; index++)
        if (index < arr.Length - 1)
            Console.Write($"{arr[index]}, ");
    Console.Write($"{arr[arr.Length - 1]}]");
}

void PrintResult(int num)
{
    Console.Write($" -> {num}");
}

(int[] value, int total) array = GetArrAndTotal(7, 100, 999);
PrintArr(array.value);
PrintResult(array.total);
