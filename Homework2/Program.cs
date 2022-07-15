// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void Task10()
{
    Random rand = new Random();
    int num = rand.Next(100, 1000);
    Console.WriteLine(num);

    int tens = num / 10 % 10;
   
    Console.WriteLine(tens);
}
//Task10();
//---------------------------------------------------------------------------//

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void Task13()
{
    Console.WriteLine("Enter integer: ");
    string num = Console.ReadLine();
    int len = num.Length;

    if (len > 2)
        Console.WriteLine(num[2]);
    else 
        Console.WriteLine("My lord, we need more digits!");
}
//Task13();
//---------------------------------------------------------------------------//

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

void Task15()
{
    Console.WriteLine("Enter number of the week day: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num == 6)
        Console.WriteLine("Yes, that's Saturday!");
    else if (num == 7)
        Console.WriteLine("Yes, that's Sunday!");
    else if (num == 1)
        Console.WriteLine("No, that's Monday, week just begun...");
    else if (num == 2)
        Console.WriteLine("No, that's Tuesday, week is going...");
    else if (num == 3)
        Console.WriteLine("No, that's Wednesday, but Wednesday is a little Friday, don't give up!");
    else if (num == 4)
        Console.WriteLine("No, that's Thursday, weekend is around...");
    else if (num == 5)
        Console.WriteLine("No, that's Friday, be ready for a weekend!");
    else
        Console.WriteLine("Incorrect number of the week day");
}
//Task15();
//---------------------------------------------------------------------------//

// /!\ ДОПОЛНИТЕЛЬНЫЕ ЗАДАЧИ
//Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.

void addTask1()
{
    Console.WriteLine("Enter A side of triangle: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter B side of triangle: ");
    int B = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter C side of triangle: ");
    int C = Convert.ToInt32(Console.ReadLine());

    if (A + B == C || A + C == B || B + C == A)
        Console.WriteLine("Such a triangle cannot exist");      // для частных случаев (A=1, B=2, C=3)
    else if (A == B && B == C)
        Console.WriteLine ("That triangle is equilateral");     // для частных случаев равносторонних треугольников
    else if (A == B || B == C || C == A)
        Console.WriteLine("That triangle is isosceles");        // для равнобедренных треугольников
    else if (A*A == B*B + C*C || B*B == C*C + A*A || C*C == A*A + B*B)
        Console.WriteLine("That triangle is rectangular");      // для частных случаев прямоугольных треугольников
    else if (A + B < C || A + C < B || B + C < A)
        Console.WriteLine("Such a triangle cannot exist");
    else
        Console.WriteLine("That's usual boring triangle");
}
//addTask1();
//---------------------------------------------------------------------------//

//Задача 2. На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 июля 2022 г.

void addTask2()
{
    Console.WriteLine("If you want to know the person's age on 1st of July, 2022, enter the day of birth in format DD: ");
    int day = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Also need the number of month of birth in format MM: ");
    int month = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("And the year in format YYYY: ");
    int year = Convert.ToInt32(Console.ReadLine());
    int y_age = 0;
    
    if (month > 12 || day > 31)
    {
        Console.WriteLine("Incorrect date");
        if (month == 2 && day > 28 || month == 4 && day > 30 || month == 6 && day > 30 || month == 9 && day > 30 || month == 11 && day > 30)
        {   // проверяем на корректность даты (30.02.2000 или 37.09.1980)
            Console.WriteLine("Incorrect date");
        }
    }
    else if (month > 7)
    {
        y_age = 2022 - year - 1;
        Console.WriteLine("Age is: " + y_age + " year(s)");
    }
    else
    {
        y_age = 2022 - year;
        Console.WriteLine("Age is: " + y_age + " year(s)");
    }
}
//addTask2();   // нутром чую, что можно решить проще, но пока не приходит в голову
//---------------------------------------------------------------------------//

//Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается 
//на 1.5% от имеющейся суммы. Определить размер депозита через n месяцев.

void addTask3()
{
    Console.WriteLine("Enter month quantity: ");
    int month = Convert.ToInt32(Console.ReadLine());
    double rate = 1.5;
    double money = 1000;
    double profit = rate / 100 + 1; // переводим ставку в число и прибавляем 1 (т.к. умножение), для учёта влияния ставки на ВСЮ сумму
    
    for (int i = 0; i < month; i++)
        money = money * profit;
    
    money = Math.Round(money, 2);   // округляем до 2 знаков после запятой (копейки)         !подумать! .225 округлять до .23
    Console.WriteLine(money);
}
//addTask3();
//---------------------------------------------------------------------------//

//Задача 4. Дано натуральное число, в котором все цифры различны. Определить, какая цифра расположена в нем левее: 
//максимальная или минимальная.
/*
void addTask4()     // попытки "обуздать" массив закоментированны, самое первое решение ниже. Попытки развить его шире и интереснее не увенчались
{
    Console.WriteLine("Enter integer without repeating digits: ");
    string num = Console.ReadLine();
    int dig = 0;    // сравниваемая цифра
    int count = 0;  // счетчик повторений
    int len = num.Length;
        
    if (len > 10)   // если цифр в числе больше 10 - 100% есть повторяющиеся
    {
        Console.WriteLine("That size of integer couldn't consist non repeating digits!");
    }
    else
    {
        Console.WriteLine("Entered integer under the checking");        // для инфо
        
        for (int i = 0; i <= len - 1; i++)
        {
            while (dig < 10)
            {
                if (dig == num[i])
                {
                    count++;
                    Console.WriteLine(dig + "in" + num[i] + "checked"); // для инфо
                    if (count < 2)
                    {
                        dig++;
                    }
                    else
                    { 
                        Console.WriteLine("Digits repeating!");
                    }
                }
                else
                {
                    dig++;
                }
            
            }
        Console.WriteLine("Check ends successful");                     // для инфо
            
        }

        Console.WriteLine("Сhecking digit to the left");                // для инфо
    }    
    
    //Console.WriteLine(num);                

}
addTask4();
*/

void addTask4_1()
{
    Console.WriteLine("Enter integer: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int max = 0;
    int min = num;
    int act = num;
    bool pos = false;

    while (num > 0) 
    {
        act = num % 10;
        if (act > max)
        {
            max = act;
            pos = false;
        }
        if (act < min)
        {
            min = act;
            pos = true;
        }
        num = num / 10;
    }

    if (pos == true)
    {
        Console.WriteLine("Min digit to the left of the max");
    }
    else 
    {
        Console.WriteLine("Max digit to the left of the min");
    } 
}
addTask4_1();
//---------------------------------------------------------------------------//

/*
void Test()     // функция, выдающая рандомное число без повторения цифр честно стырена для ковыряния
{
    int[] digits = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int buf, j, i, p = 1000000000, res = 0;
    Random r = new Random();
    for (i = 0; i < 10; i++)
    {
        j = r.Next(10);
        buf = digits[i];
        digits[i] = digits[j];
        digits[j] = buf;
    }
    if (digits[0] == 0) i = 1;
    else i = 0;
    for (; p >= 1; p /= 10, i++) res += digits[i] * p;
    Console.WriteLine(res);
}
Test();
*/