namespace DayNine
{
    static class Program
    {
        static void BubbleSortArray(int[] array)
        {
            int qtdTimesTraveled = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for(int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int box = array[j];
                        array[j] = array[j+1];
                        array[j+1] = box;
                    }
                }
                qtdTimesTraveled++;

                if (IsOrdened(array))
                {
                    System.Console.WriteLine($"The array is already ordened!\nTimes traveled: {qtdTimesTraveled}\n");
                    break;
                }
            }
        }
        static bool IsOrdened(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false; 
                }
            }
            return true; 
        }

        static void Main()
        {
            int[] array = {1,2,3,4,5,6,7,9,8,10};
            BubbleSortArray(array);

            Console.WriteLine("Sorted array:");

            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }
        }
    }
}