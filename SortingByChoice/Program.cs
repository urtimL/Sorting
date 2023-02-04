void SelectionSort(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size - 1; i++)
    {
        int post = i;

        for (int j = i + 1; j < size; j++)
        {
            if (array[j] < array[post])
            {
                post = j;
            }

        }

        int temp = array[i];
        array[i] = array[post];
        array[post] = temp;
        // Console.WriteLine($"{i}. [{String.Join(", ", array)}]");
    }
}

int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

Console.WriteLine($"[{String.Join(", ", arr)}]");
SelectionSort(arr);
Console.WriteLine($"[{String.Join(", ", arr)}]");