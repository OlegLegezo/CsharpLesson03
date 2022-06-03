// сортировка массива методом min max
// 1. Найти позицию минимального элемента
// в неотсортированной части массива
// 2. Произвести обмен этого значения со
// значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные
// элементы

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// метод вывод на экран
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
// метод вывод на экран
PrintArray(arr);


// метод сортировки массива
void SelectioSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)//не очень понятно зачем тут отнимаем (без этих +- тоже все отрабатывает)
    {
        int maxPosition = i;
        //кусок поиска минимального
        for (int j = i+1; j < array.Length; j++)//не очень понятно зачем тут прибавляем
        {
            if (array[j] > array[maxPosition])
                maxPosition = j;
        }
        //кусок поиска минимального
        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}

SelectioSort(arr);
PrintArray(arr);