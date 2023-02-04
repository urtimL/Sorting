Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Введите значения элемента: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

int temp;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    //Console.WriteLine($"{i}. [{string.Join(", ", array)}]");
}

Console.WriteLine($"Отсортированный массив: [{string.Join(", ", array)}]");