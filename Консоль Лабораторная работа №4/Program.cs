int[] arr = { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10 };
int sum = 0;

foreach (int num in arr)
{
    if (num > 0)
    {
        sum += num;
    }
}

Console.WriteLine("Сумма положительных элементов массива: " + sum);