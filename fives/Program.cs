Console.WriteLine("Введите 3-х значное число");
try
{
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(a % 10);
}
catch
{
    
    Console.WriteLine("Нужно число");
}