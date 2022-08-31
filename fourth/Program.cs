Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = -a;
while (i < a)
{
    Console.Write(i + ", ");
    i++;
}
Console.Write(i);
