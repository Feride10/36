// 36
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10); 
}

int SummaOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
        sum += array[i];
    return sum;
}

Console.Clear();
Console.Write("Введите кол-во чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine(SummaOdd(array));
