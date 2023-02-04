public static class Sorting
{
    public static void SelectionSort(int[] array)
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
        }
    }
}