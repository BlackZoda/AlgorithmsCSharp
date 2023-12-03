namespace ArticleExamples;

public static class TimeComplexity
{
    public static int ConstantTimeLookup(int[] arr, int needle)
    {
        return arr[needle];
    }

    public static bool LinearSearch(int[] arr, int needle)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == needle)
            {
                return true;
            }
        }
        return false;
    }

    public static int[] BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        return arr;
    }

    public static int BinarySearch(int[] arr, int needle)
    {
        int low = 0;
        int high = arr.Length;

        while (low < high)
        {
            int mid = (low + high) / 2;
            int midValue = arr[mid];

            if (midValue == needle)
            {
                return mid;
            }
            else if (midValue < needle)
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }

        return -1;
    }

    public static int[] MergeSort(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return arr;
        }

        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        Array.Copy(arr, 0, left, 0, mid);
        Array.Copy(arr, mid, right, 0, arr.Length - mid);

        left = MergeSort(left);
        right = MergeSort(right);

        return Merge(left, right);
    }

    static int[] Merge(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];
        int leftIndex = 0, rightIndex = 0, resultIndex = 0;

        while (leftIndex < left.Length && rightIndex < right.Length)
        {
            if (left[leftIndex] < right[rightIndex])
            {
                result[resultIndex++] = left[leftIndex++];
            }
            else
            {
                result[resultIndex++] = right[rightIndex++];
            }
        }

        while (leftIndex < left.Length)
        {
            result[resultIndex++] = left[leftIndex++];
        }

        while (rightIndex < right.Length)
        {
            result[resultIndex++] = right[rightIndex++];
        }

        return result;
    }
}
