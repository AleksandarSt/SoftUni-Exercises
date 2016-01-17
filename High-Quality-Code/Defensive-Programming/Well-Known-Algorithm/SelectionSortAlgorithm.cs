using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Well_Known_Algorithm
{
    class SelectionSortAlgorithm
    {
        static void Main(string[] args)
        {
            int[] numbers = {8, 5, 2, 6, 9, 3, 10, 7, 1, 0};

                SelectionSort(numbers);
        }

        static void SelectionSort(int[] numbers)
        {
            for (int currentIndex = 0; currentIndex < numbers.Length-1; currentIndex++)
            {

                int minIndex = currentIndex;
                for (int nextIndex = currentIndex + 1; nextIndex < numbers.Length; nextIndex++)
                {
                    if (numbers[nextIndex]<numbers[minIndex])
                    {
                        minIndex = nextIndex;
                    }
                }

                if (minIndex!=currentIndex)
                {
                    Swap(numbers, minIndex, currentIndex);
                }
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Debug.Assert(numbers[i] < numbers[i + 1], "Sorting is not working correctly!");
            }
        }

        private static void Swap(int[] numbers, int minIndex, int currentIndex)
        {
            int oldValue = numbers[minIndex];
            numbers[minIndex] = numbers[currentIndex];
            numbers[currentIndex] = oldValue;
        }
    }
}
