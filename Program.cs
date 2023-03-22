int[] arr = new int[5];
int min = int.MaxValue;
int max = int.MinValue;
double avg = 0.0;
int sum = 0;
int mult = 1;
for (int i = 0; i < 5; i++)
{
    Console.Write("Введите число: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < 5; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
    }
    if (arr[i] > max)
    {
        max = arr[i];
    }
    sum += arr[i];
    mult *= arr[i];
}
avg = (double)sum / arr.Length;
Console.WriteLine("Минимальное значение: " + min);
Console.WriteLine("Максимальное значение: " + max);
Console.WriteLine("Среднее значение: " + avg);
Console.WriteLine("Сумма: " + sum);
Console.WriteLine("Произведение: " + mult);