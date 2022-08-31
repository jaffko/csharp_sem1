Console.Write("Введите число: ");
try
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = a * a;
    Console.WriteLine("Квадрат числа равен " + b);
    if (a>0)
    {
        Console.WriteLine("Число положительное");
    }
    else if (a<0) Console.WriteLine("Число отрицательное");
    else Console.WriteLine("Число равно нулю");
}
catch 
{
    
   Console.WriteLine("Нужно целое число!"); 
}
