#region 1
//Даны вещественные положительные числа a, b, c. Если существует треугольник со сторонами a, b, c, то определить, является ли он прямоугольным
double a;
Console.WriteLine("Введите сторону a:");
a = Convert.ToDouble(Console.ReadLine());
double b;
Console.WriteLine("Введите сторону b:");
b = Convert.ToDouble(Console.ReadLine());
double c;
Console.WriteLine("Введите сторону c:");
c = Convert.ToDouble(Console.ReadLine());

if ((a + b) > c || (a + c) > b || (b + c) > a)
{
    Console.WriteLine($"существует треугольник со сторонами a = {a}, b = {b}, c = {c}.");
    if (a * a + b * b == c * c || b * b + c * c == a * a || a * a + c * c == b * b)
    {
        Console.WriteLine("треугольник - прямоугольный.\n");
    }
    else
    {
        Console.WriteLine("треугольник - не прямоугольный.\n");
    }
}
else
{
    Console.WriteLine("Не существует треугольник со сторонами a = {a}, b = {b}, c = {c}.\n");
}
#endregion

#region 2
//Дано целое число n (1 <= n <= 99), определяющее возраст человека (в годах). Для этого числа напечатать фразу «мне n лет», учитывая,
//что при некоторых значениях n слово «лет» надо заменить на слово «год» или «года».
int n;
Console.WriteLine("Введите чило (количество лет, (1 <= n <= 99):");
n = Convert.ToInt32(Console.ReadLine());
while (n < 0 || n > 99)
{
    Console.WriteLine("Число вышло за пределы допустимого диапазона. Введите чило (количество лет, (1 <= n <= 99):");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 0 || (4 < n && n <= 20))
{
    Console.WriteLine($"Мне {n} лет.\n");
}
else
{
    if (n == 1 || n % 10 == 1)
    {
        Console.WriteLine($"Мне {n} год.\n");
    }
    else
    {
        if ((2 <= n && n <= 4) || ((2 <= n % 10) && (n % 10 <= 4)))
        {
            Console.WriteLine($"Мне {n} года.\n");
        }
        else
        {
            Console.WriteLine($"Мне {n} лет.\n");
        }
    }
}

//                  или (вариант 2)
//int n;
//Console.WriteLine("Введите чило (количество лет, (1 <= n <= 99):");
//n = Convert.ToInt32(Console.ReadLine());
//while (n < 0 || n > 99)
//{
//    Console.WriteLine("Число вышло за пределы допустимого диапазона. Введите чило (количество лет, (1 <= n <= 99):");
//    n = Convert.ToInt32(Console.ReadLine());
//}
//if ((n % 10 == 0) || (((n % 100) > 10) && (n % 100) < 20) || (n % 10) > 4)
//{
//    Console.WriteLine($"Мне {n} лет.\n");
//}
//else
//{
//    if (n % 10 == 1)
//    {
//        Console.WriteLine($"Мне {n} год.\n");
//    }
//    else
//    {
//        Console.WriteLine($"Мне {n} года.\n");
//    }
//}
#endregion