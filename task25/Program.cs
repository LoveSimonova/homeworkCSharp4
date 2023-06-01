// See https://aka.ms/new-console-template for more information
double pow(int number,int power)
{
    return Math.Pow(number,power);
}

Console.WriteLine("Введите число: ");
int num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую возводят число: ");
int power=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Результат: "+pow(num,power));