Console.Write("Введите два числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (b * b == a)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else if (a * a == b)
{
    Console.WriteLine("Второе число является квадратом первого");
}
else Console.WriteLine("Квадратов чисел нет");
