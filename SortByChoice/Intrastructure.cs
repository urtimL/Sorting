using static System.Console;
public static class Intrastructure
{
    /// <summary>
    /// Метод создания и заполнения массива
    /// </summary>
    /// <param name="size">Размер нового массива</param>
    /// <param name="min">Нижняя граница заполнения</param>
    /// <param name="max">Верхняя граница заполнения</param>
    /// <returns>Новый массив</returns>
    public static int[] CreateArray(int size, int min = 0, int max = 10)
    {
        return Enumerable.Range(1, size)
                .Select(item => Random.Shared.Next(min, max))
                .ToArray();
    }

    public static void Show(int[] array, string Separator = ", ")
    {
        string autput = String.Join(Separator, array);
        WriteLine($"[{autput}]");
    }
}