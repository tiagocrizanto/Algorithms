var array = new int[] { 3, 20, 5, 1 };

InsertionSort(array);

static void InsertionSort(int[] arr)
{
    Console.WriteLine($"Initial array: {string.Join(",", arr)}");

    for (int i = 0; i < arr.Length; i++)
    {
        var t = arr[i];
        var j = i - 1;

        while(j >= 0)
        {
            if (arr[j] > t)
            {
                arr[j + 1] = arr[j];
                j--;
            } else
            {
                break;
            }
        }

        arr[j + 1] = t;
    }

    Console.WriteLine($"Output array {string.Join(",", arr)}");
}
