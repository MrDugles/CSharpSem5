// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

(int[], int) GetArrAndTotal(int size, int firstNum, int lastNum)
{
    int[] arr = new int[size];
    int summ = 0;
    for (int index = 0; index < size; index++)
    {
        arr[index] = new Random().Next(firstNum, lastNum + 1);
        if (index % 2 == 0 || index == 0)
            summ += arr[index];
    }
    return (arr, summ);
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

(int[] value, int total) array = GetArrAndTotal(7, 0, 9);
PrintArr(array.value);
PrintResult(array.total);