using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeQucikSort
{
    class QuickSort
    {
        public int[] Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                if (pivot > 1)
                    Sort(array, left, pivot - 1);
                if (pivot + 1 < right)
                    Sort(array, pivot + 1, right);
            }
            return array;
        }

        private int Partition(int[] array, int left, int right)
        {
            int pivot = array[left];

            while (true)
            {
                while (array[left] < pivot)
                    left++;
                while (array[right] > pivot)
                    right--;

                if (left < right)
                {
                    if (array[left] == array[right])
                        return right;
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
                else
                    return right;
            }
        }
    }
}
