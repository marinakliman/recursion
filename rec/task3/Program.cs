
Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());

int[] randomArray = GenerateRandomArray(size);

Console.WriteLine("Первоначальный массив:");
PrintArray(randomArray, 0);

Console.WriteLine("\nПеревернутый массив:");
PrintArrayReverse(randomArray, size - 1);

static int[] GenerateRandomArray(int size)
{
    int[] array = new int[size];
    Random random = new Random();

    return GenerateRandomArrayRecursive(array, random, 0);
}

static int[] GenerateRandomArrayRecursive(int[] array, Random random, int index)
{
    if (index < array.Length)
    {
        array[index] = random.Next(1, 100); 
        return GenerateRandomArrayRecursive(array, random, index + 1);
    }
    return array;
}

static void PrintArray(int[] array, int index)
{
    if (index < array.Length)
    {
        Console.Write($"{array[index]} ");
        PrintArray(array, index + 1);
    }
}

static void PrintArrayReverse(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write($"{array[index]} ");
        PrintArrayReverse(array, index - 1);
    }
}


