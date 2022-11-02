var array = new int[] { 3, 20, 5, 1};
// var array = new int[] { 1, 3, 5, 20 }; // ordered array to test the break condition

BubbleSort(array);

static void BubbleSort(int[] inputArray)
{
	Console.WriteLine($"Initial array: {string.Join(",", inputArray)}");

	for (int i = inputArray.Length - 1; i > 0; i--)
	{
        // this variable prevents loop through the entire array if the input array is ordered.
        var changed = false;

		for (int j = 0; j < i; j++)
		{
			if (inputArray[j] > inputArray[j + 1])
			{
                // swap array position
                (inputArray[j], inputArray[j + 1]) = (inputArray[j + 1], inputArray[j]);
                changed = true;
			}
		}

        if (!changed) break;
    }

    Console.WriteLine($"Output array {string.Join(",", inputArray)}");
}
