// 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
void Task19()           // DONE
{
    Console.WriteLine("Enter five-digit integer: ");
    string n = Console.ReadLine();
    char temp1 = n[0];
    char temp2 = n[1];
    char temp3 = n[3];
    char temp4 = n[4];
    if (temp1 == temp4 && temp2 == temp3) Console.WriteLine("Palindrome");
    else Console.WriteLine("Non-palindrome");
}
//Task19();
//---------------------------------------------------------------------------//

// 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
void Task21()           // DONE
{
    Console.WriteLine("Enter coordinates (X, Y, Z) of 1st dot:");
    double x1 = Convert.ToInt32(Console.ReadLine());
    double y1 = Convert.ToInt32(Console.ReadLine());
    double z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter coordinates (X, Y, Z) of 2nd dot:");
    double x2 = Convert.ToInt32(Console.ReadLine());
    double y2 = Convert.ToInt32(Console.ReadLine());
    double z2 = Convert.ToInt32(Console.ReadLine());

    double xx = x2 - x1;
    double yy = y2 - y1;
    double zz = z2 - z1;

    double result = Math.Sqrt(xx * xx + yy * yy + zz * zz);
    Console.WriteLine("Distance:" + result);
}
//Task21();
//---------------------------------------------------------------------------//

// 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Task23()           // DONE
{
    Console.WriteLine("Enter number: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int start = 1;
    if (N <= 1)
        Console.WriteLine("Please, try again");
    else
    {
        while (start <= N)
        {
            Console.WriteLine($"{start}^3 = {start * start * start}");
            start++;
        }
        Console.WriteLine();
    }
}
//Task23();
//---------------------------------------------------------------------------//
//---------------------------------------------------------------------------//

// ДОПОЛНИТЕЛЬНЫЕ ЗАДАЧИ
// Задача 1. Рассчитать значение y при заданном x по формуле y = sin^2(x) (x>0), y = 1 - 2sin(x^2) (x<=0)
void addTask1()         // IN PROGRESS !финализировать проверки!
{
    Console.WriteLine("Enter 'X' value:");
    int x = Convert.ToInt32(Console.ReadLine());
    double Rx = x * Math.PI / 180;          // перевод переменной в радианы
    double RADy = 0;                        // радианы
    double DEGy = 0;                        // градусы
    if (x > 0)
    {
        RADy = (1 - Math.Cos(2 * Rx)) / 2;  // радианы
        DEGy = RADy * 180 / Math.PI;        // градусы
        Console.WriteLine($"Значение функции sin^2({x}) = {RADy}");
        Console.WriteLine($"Значение функции sin^2({x}) = {DEGy} в градусах");
    }
    else //if (x <= 0)
    {
        RADy = 1 - 2 * Math.Sin(Math.Pow(Rx, 2));       // радианы
        DEGy = RADy * (180 / Math.PI);                  // градусы
        Console.WriteLine($"Значение функции 1 - 2sin({x}^2) = {RADy}");
        Console.WriteLine($"Значение функции 1 - 2sin({x}^2) = {DEGy} в градусах");
    }
}
//addTask1();
//---------------------------------------------------------------------------//

// Задача 2. Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.
void addTask2()         // THINK
{ // Сравнивает не символ строки, а его номер в таблице ASCII   /!\ Подумать как можно это использовать в дальнейшем!
    Console.WriteLine("Enter three-digit number: ");
    string num = Console.ReadLine();
    int n1 = num[0];
    int n2 = num[1];
    int n3 = num[2];
    int res = n1 + n2 + n3;
    Console.WriteLine(res);
    if (res % 3 == 0) Console.WriteLine("Multiple of 3");
    else Console.WriteLine("Non-multiple of 3");
}
//addTask2();
void addTask2_1()       // DONE
{
    Console.WriteLine("Enter three-digit number: ");
    string n = Console.ReadLine();
    int num = Convert.ToInt32(n);
    if (n.Length < 3 || n.Length > 3) Console.WriteLine("Out of range!");
    else
    {
        int ones = num % 10;
        int tens = num / 10 % 10;
        int hund = num / 100;

        if ((ones + tens + hund) % 3 == 0) Console.WriteLine("Congrats! Entered number is multiple of 3");
        else Console.WriteLine("Sorry, entered number is NOT multiple of 3");
    }
}
//addTask2_1();
//---------------------------------------------------------------------------//

// Задача 3. Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.
void addTask3()         // DONE
{
    Console.WriteLine("Enter three-digit number: ");
    string n = Console.ReadLine();
    string f = "4";         // Можно и без переменных, просто вставить цифру в n.Contains
    string s = "7";         // Однако, необходимо избегать "магических" цифр
    if (n.Length < 3 || n.Length > 3) Console.WriteLine("Out of range!");
    else
    {
        if (n.Contains(f) && n.Contains(s)) Console.WriteLine($"Entered number contains digits {f} and {s}");
        else if (n.Contains(f)) Console.WriteLine($"Entered number contains digit {f}");
        else if (n.Contains(s)) Console.WriteLine($"Entered number contains digit {s}");
        else Console.WriteLine($"Entered number doesn't contain digits {f}, {s}");
    }
}
//addTask3();
//---------------------------------------------------------------------------//

// Задача 4. Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.
void addTask4()         // Для любой длины массива, включая 10
{
    Console.Write("Enter array size: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = i + 1;
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//addTask4();
void addTask4_1()       // DONE
{
    Console.Write("Enter array elements quantity: ");       // универсальное решение на любое количество элементов
    int n = Convert.ToInt32(Console.ReadLine());            // ввод количества элементов
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Array element [{i + 1}] = ");       // ввод самих элементов
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    int count = array.Length;
    for (int j = 0; j < count; j++)
    {
        Console.Write($"{array[j]} ");                      // вывод введенного массива
    }
    Console.WriteLine();
    for (int k = 0; k < array.Length; k++)
    {
        int MinPos = k;
        for (int l = k + 1; l < array.Length; l++)
        {
            if (array[l] < array[MinPos]) MinPos = l;       // сортировка по возрастанию
        }

        int Temp = array[k];
        array[k] = array[MinPos];
        array[MinPos] = Temp;
        Console.Write($"{array[k]} ");                      // вывод отсортированного массива
    }
    Console.WriteLine();
}
//addTask4_1();
//---------------------------------------------------------------------------//
//---------------------------------------------------------------------------//

// ЗАДАЧИ ПОВЫШЕННОЙ СЛОЖНОСТИ
// Задача 1. На ввод подаётся номер четверти. Создаются 3 случайные точки в этой четверти. 
// Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.
void addCompTask1()     // DONE
{
    Console.WriteLine("Enter quarter number:");
    int qua = Convert.ToInt32(Console.ReadLine());
    double x1 = 0;                                                      // координаты точек
    double y1 = 0;
    double x2 = 0;
    double y2 = 0;
    double x3 = 0;
    double y3 = 0;

    if (qua < 1 || qua > 4) Console.WriteLine("Wrong quarter number!"); // проверка четверти
    else if (qua == 1)
    {
        Random rand = new Random();                                     // создание случайных точек в нужной четверти
        x1 = rand.Next(1, 10);
        y1 = rand.Next(1, 10);
        x2 = rand.Next(1, 10);
        y2 = rand.Next(1, 10);
        x3 = rand.Next(1, 10);
        y3 = rand.Next(1, 10);
        Console.WriteLine($"Dot A ({x1}; {y1}), dot B ({x2}; {y2}), dot C ({x3}; {y3})");
    }
    else if (qua == 2)
    {
        Random rand = new Random();                                     // создание случайных точек в нужной четверти
        x1 = rand.Next(-9, 0);
        y1 = rand.Next(1, 10);
        x2 = rand.Next(-9, 0);
        y2 = rand.Next(1, 10);
        x3 = rand.Next(-9, 0);
        y3 = rand.Next(1, 10);
        Console.WriteLine($"Dot A ({x1}; {y1}), dot B ({x2}; {y2}), dot C ({x3}; {y3})");
    }
    else if (qua == 3)
    {
        Random rand = new Random();                                     // создание случайных точек в нужной четверти
        x1 = rand.Next(-9, 0);
        y1 = rand.Next(-9, 0);
        x2 = rand.Next(-9, 0);
        y2 = rand.Next(-9, 0);
        x3 = rand.Next(-9, 0);
        y3 = rand.Next(-9, 0);
        Console.WriteLine($"Dot A ({x1}; {y1}), dot B ({x2}; {y2}), dot C ({x3}; {y3})");
    }
    else
    {
        Random rand = new Random();                                     // создание случайных точек в нужной четверти
        x1 = rand.Next(1, 10);
        y1 = rand.Next(-9, 0);
        x2 = rand.Next(1, 10);
        y2 = rand.Next(-9, -1);
        x3 = rand.Next(1, 10);
        y3 = rand.Next(-9, 0);
        Console.WriteLine($"Dot A ({x1}; {y1}), dot B ({x2}; {y2}), dot C ({x3}; {y3})");
    }

    double dist01 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));       // определение дистанции от точки 00 до 01
    double dist02 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));       // определение дистанции от точки 00 до 02
    double dist03 = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2));       // определение дистанции от точки 00 до 03
    double dist12 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // определение дистанции от точки 01 до 02
    double dist13 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2)); // определение дистанции от точки 01 до 03
    double dist23 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)); // определение дистанции от точки 02 до 03
    double short1 = 0;
    double short2 = 0;
    double short3 = 0;

    if (dist01 < dist02 && dist01 < dist03) short1 = dist01;            // выбор минимальной дистанции от 00 точки
    else if (dist02 < dist01 && dist02 < dist03) short1 = dist02;
    else short1 = dist03;

    if (dist12 < dist13) short2 = dist12;                               // выбор минимальной дистанции от 01 точки
    else short2 = dist13;

    short3 = dist23;                                                    // всегда наикратчайшая дистанция, т.к. единственная

    double way = short1 + short2 + short3;

    if (qua < 1 || qua > 4) Console.WriteLine("Nowhere to go");         // если четверть неверная, менеджер стоит на месте
    else Console.WriteLine($"The shortest manager way is: {way}");      // сумма наикратчайших дистанций = кратчайший путь


}
//addCompTask1();
//---------------------------------------------------------------------------//

// Задача 2. Даны 4 точки a, b, c, d. Пересекаются ли вектора AB и CD?
void addCompTask2()
{

}
//addCompTask2();
//---------------------------------------------------------------------------//
// Задача 3. Найти в какой четверти лежит точка пересечения из задачи 2 (если вектора пересекаются).
//---------------------------------------------------------------------------//

// Задача 4. Дан массив средних температур (массив заполняется случайно) за последние 10 лет. 
// На ввод подают номер месяца и год начали и конца. Определить самые высокие и низкие температуры 
// для лета, осени, зимы и весны в заданном промежутке. Если таких температур нет, сообщить, что определить не удалось.
void addCompTask4()     // как НЕ НАДО программировать :D  /!\ попробовать через словарь или хэш таблицу
{
    string[] Town = new string[] {
    "  2012 Jan:", "", "  2012 Feb:", "", "  2012 Mar:", "", "  2012 Apr:", "", "  2012 May:", "", "  2012 Jun:", "",
    "  2012 Jul:", "", "  2012 Aug:", "", "  2012 Sep:", "", "  2012 Oct:", "", "  2012 Nov:", "", "  2012 Dec:", "",
    "  2013 Jan:", "", "  2013 Feb:", "", "  2013 Mar:", "", "  2013 Apr:", "", "  2013 May:", "", "  2013 Jun:", "",
    "  2013 Jul:", "", "  2013 Aug:", "", "  2013 Sep:", "", "  2013 Oct:", "", "  2013 Nov:", "", "  2013 Dec:", "",
    "  2014 Jan:", "", "  2014 Feb:", "", "  2014 Mar:", "", "  2014 Apr:", "", "  2014 May:", "", "  2014 Jun:", "",
    "  2014 Jul:", "", "  2014 Aug:", "", "  2014 Sep:", "", "  2014 Oct:", "", "  2014 Nov:", "", "  2014 Dec:", "",
    "  2015 Jan:", "", "  2015 Feb:", "", "  2015 Mar:", "", "  2015 Apr:", "", "  2015 May:", "", "  2015 Jun:", "",
    "  2015 Jul:", "", "  2015 Aug:", "", "  2015 Sep:", "", "  2015 Oct:", "", "  2015 Nov:", "", "  2015 Dec:", "",
    "  2016 Jan:", "", "  2016 Feb:", "", "  2016 Mar:", "", "  2016 Apr:", "", "  2016 May:", "", "  2016 Jun:", "",
    "  2016 Jul:", "", "  2016 Aug:", "", "  2016 Sep:", "", "  2016 Oct:", "", "  2016 Nov:", "", "  2016 Dec:", "",
    "  2017 Jan:", "", "  2017 Feb:", "", "  2017 Mar:", "", "  2017 Apr:", "", "  2017 May:", "", "  2017 Jun:", "",
    "  2017 Jul:", "", "  2017 Aug:", "", "  2017 Sep:", "", "  2017 Oct:", "", "  2017 Nov:", "", "  2017 Dec:", "",
    "  2018 Jan:", "", "  2018 Feb:", "", "  2018 Mar:", "", "  2018 Apr:", "", "  2018 May:", "", "  2018 Jun:", "",
    "  2018 Jul:", "", "  2018 Aug:", "", "  2018 Sep:", "", "  2018 Oct:", "", "  2018 Nov:", "", "  2018 Dec:", "",
    "  2019 Jan:", "", "  2019 Feb:", "", "  2019 Mar:", "", "  2019 Apr:", "", "  2019 May:", "", "  2019 Jun:", "",
    "  2019 Jul:", "", "  2019 Aug:", "", "  2019 Sep:", "", "  2019 Oct:", "", "  2019 Nov:", "", "  2019 Dec:", "",
    "  2020 Jan:", "", "  2020 Feb:", "", "  2020 Mar:", "", "  2020 Apr:", "", "  2020 May:", "", "  2020 Jun:", "",
    "  2020 Jul:", "", "  2020 Aug:", "", "  2020 Sep:", "", "  2020 Oct:", "", "  2020 Nov:", "", "  2020 Dec:", "",
    "  2021 Jan:", "", "  2021 Feb:", "", "  2021 Mar:", "", "  2021 Apr:", "", "  2021 May:", "", "  2021 Jun:", "",
    "  2021 Jul:", "", "  2021 Aug:", "", "  2021 Sep:", "", "  2021 Oct:", "", "  2021 Nov:", "", "  2021 Dec:", ""};
    var random = new Random();
    for (int i = 1; i < Town.Length; i = i + 2)
    {
        if (i == 1 || i == 3 || i == 23 || i == 25 || i == 27 || i == 47 || i == 49 || i == 51 || i == 71
        || i == 73 || i == 75 || i == 95 || i == 97 || i == 99 || i == 119 || i == 121 || i == 123 || i == 143
        || i == 145 || i == 147 || i == 167 || i == 169 || i == 171 || i == 191 || i == 193 || i == 195 || i == 215
        || i == 217 || i == 219 || i == 239)
            Town[i] = Convert.ToString(random.Next(-25, 2));
        else if (i == 11 || i == 13 || i == 15 || i == 35 || i == 37 || i == 39 || i == 59 || i == 61 || i == 63
        || i == 83 || i == 85 || i == 87 || i == 107 || i == 109 || i == 111 || i == 131 || i == 133 || i == 135
        || i == 155 || i == 157 || i == 159 || i == 179 || i == 181 || i == 183 || i == 203 || i == 205 || i == 207
        || i == 227 || i == 229 || i == 231)
            Town[i] = Convert.ToString(random.Next(15, 41));
        else
            Town[i] = Convert.ToString(random.Next(0, 16));
    }
    Console.Write("Average month temperature from 2012 to 2021:{0} ", String.Join(" ", Town)); // вывод сгенерированного массива за 10 лет

}
//addCompTask4();
//---------------------------------------------------------------------------//
// Задача 5. На вход подаётся число n > 4, указывающее длину пароля. 
// Создайте метод, генерирующий пароль заданной длины. В пароле обязательно использовать цифру, букву и специальный знак.
void addCompTask5()     // DONE
{
    Console.WriteLine("Enter symbol quantity of the password: ");
    int PasSym = Convert.ToInt32(Console.ReadLine());
    string Password = "";
    var rand = new Random();
    if (PasSym < 5) Console.WriteLine("Password must be longer!");
    else
    {
        while (Password.Length < PasSym)
        {
            Char ch = (char)rand.Next(33, 125); // Берем символы из таблицы ASCII (спец.символы, цифры, заглавные и строчные буквы)
            Password += ch;
        }
        Console.Write(Password);
    }
}
//addCompTask5();
void addCompTask5_1()   // Обязательное чередование цифры, заглавной, строчной и спец.символа
{
    Console.WriteLine("Enter symbol quantity of the password: ");
    int PasSym = Convert.ToInt32(Console.ReadLine());
    string Password = "";
    var rand = new Random();
    if (PasSym < 5) Console.WriteLine("Password must be longer!");
    else
    {
        while (Password.Length < PasSym)
        {
            Char chNum = (char)rand.Next(48, 57);   // 48-57 цифры 
            Char chUp = (char)rand.Next(65, 90);    // 65-90 заглавные
            Char chLo = (char)rand.Next(97, 122);   // 97-122 строчные
            Char chSp = (char)rand.Next(33, 47);    // 33-47 спец.символы
            Char chSp2 = (char)rand.Next(58, 67);   // 58-64 спец.символы
            Char chSp3 = (char)rand.Next(91, 96);   // 91-96 спец.символы
            Char chSp4 = (char)rand.Next(123, 125); // 123-125 спец.символы
            Password = Password + chNum + chUp + chLo + chSp + chSp2 + chSp3 + chSp4;
        }
        Console.Write(Password);
    }
}
//addCompTask5_1();
void addCompTask5_2()   // Обязательное чередование цифры, заглавной, строчной и спец.символа
{
    Console.WriteLine("Enter symbol quantity of the password: ");
    int PasSym = Convert.ToInt32(Console.ReadLine());
    string Nums = "1234567890";
    string UpLet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string LoLet = "abcdefghijklmnopqrstuwxyz";
    string SpSym = "!@#$%^&*()-_=+\'|?.,/:;][{}№";
    string Password = "";
    var rand = new Random();
    if (PasSym < 5) Console.WriteLine("Password must be longer!");
    else
    {
        while (Password.Length < PasSym)
        {
            var chNum = rand.Next(Nums.Length);
            var chUp = rand.Next(UpLet.Length);
            var chLo = rand.Next(LoLet.Length);
            var chSp = rand.Next(SpSym.Length);
            Password = Password + Nums[chNum] + UpLet[chUp] + LoLet[chLo] + SpSym[chSp];
        }
        Console.Write(Password);
    }
}
//addCompTask5_2();

// Задача 6. Из центра координат к точке А(x, y) проведён отрезок АО. 
// Напишите программу, определяющую наименьший угол наклона отрезка AO к оси X
//---------------------------------------------------------------------------//

// Задача 7. Массив из ста элементов заполняется случайными числами от 1 до 100. 
// Удалить из массива все элементы, содержащие цифру 3. Вывести в консоль новый массив и количество удалённых элементов.
void addCompTask7()     // IN PROGRESS
{
    int[] array = new int[10];
    for (int i = 0; i < 10; i++)
    {
        Random rand = new Random();
        int num = rand.Next(1, 11);
        array[i] = num;
        Console.Write($"{array[i]} ");
    }
    for (int j = 0; j < 10; j++)
    {
        for (int k = 0; k < 10; k++)
        {
            int[] res = new int[k];
            if (array.Contains(3))
            {
                continue;
            }
            else               
            {
                //array[j] = res[k];
            }
            Console.Write($"{res[k]}");
        }    
        //Console.WriteLine();
    }
    
    Console.WriteLine();
}
//addCompTask7();
//---------------------------------------------------------------------------//

// Задача 8. Напишите программу, который выводит на консоль таблицу умножения от 1 до n, где n задаётся случайно от 2 до 100.
void addCompTask8()     // Ручной ввод числа от 2 до 99
{
    Console.WriteLine("Enter integer from 2 to 100: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num < 2 || num > 99) Console.WriteLine("Out of range!");    // Нет слова включительно в условии задачи, потому до 99
    else
    {
        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                int result = i * j;
                Console.WriteLine($"{i} * {j} = {result}");
            }
            Console.WriteLine(" ");
        }
    }
}
//addCompTask8();
void addCompTask8_1()   // Автоматический ввод числа от 2 до 99
{
    Random rand = new Random();
    int num = rand.Next(2, 100);    // Нет слова включительно в условии задачи, потому до 99
    Console.WriteLine($"Multiplication table for {num}:\n");

    for (int i = 1; i <= num; i++)
    {
        for (int j = 1; j <= 10; j++)
        {
            int result = i * j;
            Console.WriteLine($"{i} * {j} = {result}");
        }
        Console.WriteLine(" ");
    }
}
//addCompTask8_1();
//---------------------------------------------------------------------------//

// Задача 9. Дана игра со следующими правилами. Первый игрок называет любое натуральное число от 2 до 9, 
// второй умножает его на любое натуральное число от 2 до 9, первый умножает результат на любое натуральное число от 2 до 9 и т. д. 
// Выигрывает тот, у кого впервые получится число больше 1000. Запрограммировать консольный вариант игры.
void addCompTask9()     // DONE by как НЕ НАДО программировать :D  /!\ Подумать над сокращением кода
{                       // максимальное число циклов = 10, т.к. мин.число 2 в степени 10 больше 1000.
    
    Console.WriteLine("Welcome to the console game '1000'!");
    Console.WriteLine("1st player, enter integer from 2 to 9: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    int result = 1;

        if (num1 < 2 || num1 > 9) Console.WriteLine("Out of range. Start again.");
        else
        {
            Console.WriteLine("2nd player, enter integer from 2 to 9: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 < 2 || num2 > 9) Console.WriteLine("Out of range. Start again.");
            else
            {
                result = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {result}");
                Console.WriteLine("1st player, enter integer from 2 to 9: ");
                int num3 = Convert.ToInt32(Console.ReadLine());
                if (num3 < 2 || num3 > 9) Console.WriteLine("Out of range. Start again.");
                else
                {
                    int result2 = result * num3;
                    Console.WriteLine($"{result} * {num3} = {result2}");
                    Console.WriteLine("2nd player, enter integer from 2 to 9: ");
                    int num4 = Convert.ToInt32(Console.ReadLine());
                    if (num4 < 2 || num4 > 9) Console.WriteLine("Out of range. Start again.");
                    else 
                    {
                        int result3 = result2 * num4;
                        Console.WriteLine($"{result2} * {num4} = {result3}");
                        if (result3 > 1000) Console.WriteLine("2nd player won!"); // раньше объявлять победителя нет смысла, т.к. только перемножение всех 9 ведёт сюда
                        else
                        {
                            Console.WriteLine("1st player, enter integer from 2 to 9: ");
                            int num5 = Convert.ToInt32(Console.ReadLine());
                            if (num5 < 2 || num5 > 9) Console.WriteLine("Out of range. Start again.");
                            else
                            {
                                int result4 = result3 * num5;
                                Console.WriteLine($"{result3} * {num5} = {result4}");
                                if (result4 > 1000) Console.WriteLine("1st player won!");
                                else
                                {
                                    Console.WriteLine("2nd player, enter integer from 2 to 9: ");
                                    int num6 = Convert.ToInt32(Console.ReadLine());
                                    if (num6 < 2 || num6 > 9) Console.WriteLine("Out of range. Start again.");
                                    else
                                    {
                                        int result5 = result4 * num6;
                                        Console.WriteLine($"{result4} * {num6} = {result5}");
                                        if (result5 > 1000) Console.WriteLine("2nd player won!");
                                        else
                                        {
                                            Console.WriteLine("1st player, enter integer from 2 to 9: ");
                                            int num7 = Convert.ToInt32(Console.ReadLine());
                                            if (num7 < 2 || num7 > 9) Console.WriteLine("Out of range. Start again.");
                                            else
                                            {
                                                int result6 = result5 * num7;
                                                Console.WriteLine($"{result5} * {num7} = {result6}");
                                                if (result6 > 1000) Console.WriteLine("1st player won!");
                                                else
                                                {
                                                    Console.WriteLine("2nd player, enter integer from 2 to 9: ");
                                                    int num8 = Convert.ToInt32(Console.ReadLine());
                                                    if (num8 < 2 || num8 > 9) Console.WriteLine("Out of range. Start again.");
                                                    else
                                                    {
                                                        int result7 = result6 * num8;
                                                        Console.WriteLine($"{result6} * {num8} = {result7}");
                                                        if (result7 > 1000) Console.WriteLine("2nd player won!");
                                                        else
                                                        {
                                                            Console.WriteLine("1st player, enter integer from 2 to 9: ");
                                                            int num9 = Convert.ToInt32(Console.ReadLine());
                                                            if (num9 < 2 || num9 > 9) Console.WriteLine("Out of range. Start again.");
                                                            else
                                                            {
                                                                int result8 = result7 * num9;
                                                                Console.WriteLine($"{result7} * {num9} = {result8}");
                                                                if (result8 > 1000) Console.WriteLine("1st player won!");
                                                                else
                                                                {
                                                                    Console.WriteLine("2nd player, enter integer from 2 to 9: ");
                                                                    int num10 = Convert.ToInt32(Console.ReadLine());
                                                                    if (num10 < 2 || num10 > 9) Console.WriteLine("Out of range. Start again.");
                                                                    else
                                                                    {
                                                                        int result9 = result8 * num10;
                                                                        Console.WriteLine($"{result8} * {num10} = {result9}");
                                                                        if (result9 > 1000) Console.WriteLine("2nd player won!");
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }    
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }        
            }
        }
Console.WriteLine("Game over");
}
//addCompTask9();
//---------------------------------------------------------------------------//
