// See https://aka.ms/new-console-template for more information
int[] array(int length, int minPossibleNumber, int maxPossibleNumber)
{
    Random random = new Random();
    int[] array = new int[length];
    for(int i=0;i<length;i++)
        array[i]=random.Next(minPossibleNumber,maxPossibleNumber);
    return array;
}

void print(int[] array)
{
    for(int i=0;i<array.Length;i++)
        Console.Write(""+array[i]+" ");
}

Console.WriteLine("Введите количество элементов массива: ");
int len=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число: ");
int max=Convert.ToInt32(Console.ReadLine());
int[] numbers=array(len,min,max);
Console.Write("Массив: ");
print(numbers);