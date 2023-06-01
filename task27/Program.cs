// See https://aka.ms/new-console-template for more information
int sum(int number)
{
    int resultSum=0;  
    while(number>9)
    {
        resultSum+=(number%10);
        number=number/10;
    }
    resultSum+=number;    
    return resultSum;
}

Console.WriteLine("Введите число: ");
int num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма цифр числа: "+sum(num));