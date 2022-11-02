var arr = new int[] { 2, 4, 5, 3, 20, 6 };

var result = MinMax(arr);

Console.WriteLine($"Mix / Max: {result}");

static (int, int) MinMax(int[] arr)
{
    var min = int.MaxValue; // O(1)
    var max = int.MinValue; // O(1)
    for (int i =0; i < arr.Length; i++) // O(N)
    {
        if (arr[i] < min) min = arr[i]; // O(1)
        if (arr[i] > max) max = arr[i]; // O(1)
    }

    return (min, max); // O(1)
}

// O(N) + 5 * O(1) - DROP THE CONSTANTS
// O(N)

// There's another way to implement this code
// but this is slower than the code above because 
// it gets linearly slower as the input increases in size
static (int, int) MinMaxSlower(int[] arr)
{
    var min = int.MaxValue; // O(1)
    var max = int.MinValue; // O(1)

    for (int i = 0; i < arr.Length; i++) // O(N)
        if (arr[i] < min) min = arr[i]; // O(1)

    for (int i = 0; i < arr.Length; i++) // O(N)
        if (arr[i] > max) max = arr[i]; // O(1)

    return (min, max); // O(1)
}