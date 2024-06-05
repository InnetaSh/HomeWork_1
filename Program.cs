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