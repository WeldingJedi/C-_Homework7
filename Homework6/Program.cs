void Task41()
{
    //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    //0, 7, 8, -2, -2 -> 2
    //1, -7, 567, 89, 223-> 3
    // "А" - Автоматизация
    Random rand = new Random();
    int size = rand.Next(1, 21);
    Console.WriteLine("Array elements quantity: " + size);
    int[] array = new int[size];
    GenerationArray(size, array);
    PrintArray(size, array);
    UnderZeroElements(size, array);
}

void Task43()
{
    //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
    //значения b1, k1, b2 и k2 задаются пользователем.
    //b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) <- была ошибка в ответе условия /!\
    Console.WriteLine("For y = k1 * x + b1 and y = k2 * x + b2 \nCoefficients can be generated or entered manually.\nPlease type Y for generating");
    ConsoleKeyInfo key = Console.ReadKey(true);
    if (key.Key == ConsoleKey.Y)
    {
        Random rand = new Random();
        double b1 = rand.Next(-10, 11);
        double b2 = rand.Next(-10, 11);
        double k1 = rand.Next(-10, 11);
        double k2 = rand.Next(-10, 11);
        Console.WriteLine($"were generated:\nb1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}");
        if (k1 != k2)
        {
            double x0 = (b2 - b1) / (k1 - k2);
            double y0 = k1 * x0 + b1;
            Console.WriteLine($"Intersection point on coordinates [{x0}; {y0}]");
        }
        else Console.WriteLine("Lines are parallel!");   
    }
    else
    {
        Console.WriteLine("Please, enter b1 coefficient: ");
        double b1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please, enter k1 coefficient: ");
        double k1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please, enter b2 coefficient: ");
        double b2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please, enter k2 coefficient: ");
        double k2 = Convert.ToInt32(Console.ReadLine());
        if (k1 != k2)
        {
            double x0 = (b2 - b1) / (k1 - k2);
            double y0 = k1 * x0 + b1;
            Console.WriteLine($"Intersection point on coordinates [{x0}; {y0}]");
        }
        else Console.WriteLine("Lines are parallel!");
    }

}

void GenerationArray(int size, int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(-1000, 1001);
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

void UnderZeroElements(int size, int[] array)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine($"Numbers quantity greater than zero: {count}");
}



//Task41();
//Task43();
