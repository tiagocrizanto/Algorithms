var array = new int[] { 3, 20, 5, 1 };

SelectionSort(array);

static void SelectionSort(int[] inputArray)
{
    Console.WriteLine($"Initial array: {string.Join(",", inputArray)}");

    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        var lowest = i;

        for (int j = i + 1; j < inputArray.Length; j++)
        {
            if (inputArray[j] < inputArray[lowest])
                lowest = j;
        }
        
        if (lowest != i)
            (inputArray[i], inputArray[lowest]) = (inputArray[lowest], inputArray[i]);
    }

    Console.WriteLine($"Output array {string.Join(",", inputArray)}");
}
