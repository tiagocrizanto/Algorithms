var array = new int[] { 3, 20, 5, 1 };

Console.WriteLine($"Initial array: {string.Join(",", array)}");

QuickSort(array, 0, array.Length - 1);

Console.WriteLine($"Output array {string.Join(",", array)}");

static void QuickSort(int[] arr, int startPos, int endPosition)
{

    var pivot = arr[startPos];
    int left = startPos;
    int right = endPosition;

    while (left <= right)
    {
        while (arr[left] < pivot) left++;
        while (arr[right] > pivot) right--;

        if (left <= right)
        {
            (arr[left], arr[right]) = (arr[right], arr[left]);
            left++;
            right--;
        }

        if (startPos < right) QuickSort(arr, startPos, right);
        if (left < endPosition) QuickSort(arr, left, endPosition);
    }
}