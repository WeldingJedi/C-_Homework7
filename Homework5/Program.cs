void Task34()
{
    //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
    //Напишите программу, которая покажет количество чётных чисел в массиве.
    //[345, 897, 568, 234] -> 2

    Console.WriteLine("Enter quantity of 3-digits array elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    Array3digGeneration(size, array);
    PrintArray(size, array);
    ArrayEvenElmtQty(size, array);
}  

void Task36()
{
    //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    //[3, 7, 23, 12] -> 19
    //[-4, -6, 89, 6] -> 0

    Console.WriteLine("Enter array elements quantity: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    ArrayGeneration(size, array);
    PrintArray(size, array);
    SumOddPosArray(size, array);
}

void Task38()
{
    //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    //[3,21 7,04 22,93 -2,71 78,24] -> 75,53
    Console.WriteLine("Enter float array elements quantity: ");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[size];
    ArrayFloatGeneration(size, array);
    PrintFloatArray(size, array);
    DifferenceArrayElements(array);
}

void ArrayFloatGeneration(int size, double[] array)
{
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        int Sym = rand.Next(-1, 2);
        array[i] = Math.Round(rand.NextDouble()*100, 2);
        if (Sym != 0) array[i] = array[i] * Sym;
    }
}

void DifferenceArrayElements(double[] array)
{
    double res = Math.Abs(Math.Round(array.Max() - Math.Abs(array.Min()), 2));
    Console.WriteLine($"Difference between MAX element and MIN element is {res}.");
}

void SumOddPosArray(int size, int[] array)
{
    int sum = 0;
    for (int i = 1; i < size; i = i + 2)
    {
        sum = sum + array[i];
    }
    Console.WriteLine($"Sum of all odd array elements is {sum}");
}

void ArrayGeneration(int size, int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(-10, 100);
    }
}

void Array3digGeneration(int size, int[] array)
{    
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
}

void PrintArray(int size, int[] array)
{
    Console.WriteLine("Generated array:");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine();
}

void PrintFloatArray(int size, double[] array)
{
    Console.WriteLine("Generated array:");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine();
}

void ArrayEvenElmtQty(int size, int[] array)
{   
    int cnt = 0; 
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0) cnt++;
    }
    Console.WriteLine($"Quantity of even elements in array is {cnt}");
}


//Task34();
//Task36();
//Task38();
