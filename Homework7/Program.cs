void Task47()
{
    //Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами,
    //округлёнными до одного знака.

    Random random = new Random();
    int rows = random.Next(3, 9);
    int columns = random.Next(3, 9);
    double[,] array = new double[rows, columns];
    FillDoubleArray(array);
    PrintDoubleArray(array);
}


void Task50()
{
    //Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
    //возвращает значение этого элемента или же указание, что такого элемента нет.
    
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];
    FillArray(array, -99, 99);
    PrintArray(array);
    Console.WriteLine("Are you user (press U) or programer (press P)?");
    ConsoleKeyInfo key = Console.ReadKey(true);
    if (key.Key == ConsoleKey.U) UserCheckArray(array);
    else if (key.Key == ConsoleKey.P) ProgramerCheckArray(array);
    else Console.WriteLine("You need to decide who you are. Try again.");
}

void Task52()
{
    //Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
    //столбце.

    Random random = new Random();
    int rows = random.Next(3, 6);
    int columns = random.Next(3, 6);
    int[,] array = new int[rows, columns];
    FillArray(array, 1, 9);
    PrintArray(array);
    ArithmeticalMean(array);
}

void FillDoubleArray(double[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * 20 - 10, 1);
        }
    }
}

void PrintDoubleArray(double[,] array)
{ 
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"[{array[i, j]}]\t");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array, int startNumber, int finNumber)
{
    Random random = new Random();
    finNumber++;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(startNumber, finNumber);
        }
    }
}

void PrintArray(int[,] array)
{ 
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"[{array[i, j]}]\t");
        }
        Console.WriteLine();
    }
}

void UserCheckArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Console.WriteLine("Dear User, enter row number: ");
    int R = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Dear User, enter column number: ");
    int C = Convert.ToInt32(Console.ReadLine());

    if (R > rows || C > columns) Console.WriteLine("There is no element with such indexes!");
    else Console.WriteLine($"Selected array element is: [{array[(R - 1), (C - 1)]}]");
}

void ProgramerCheckArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Console.WriteLine("Bro, enter row number: ");
    int R = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Bro, enter column number: ");
    int C = Convert.ToInt32(Console.ReadLine());

    if (R > rows - 1 || C > columns - 1) Console.WriteLine("There is no element with such indexes!");
    else Console.WriteLine($"Selected array element is: [{array[R, C]}]");
}

void ArithmeticalMean(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double sum = 0;
    double arithMean = 0.0;

    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        arithMean = sum / rows;
        sum = 0;
        Console.WriteLine($"For elements in column {j} arithmetical mean is {Math.Round(arithMean, 3)}");
    }
}

//Task47();
//Task50();
//Task52();