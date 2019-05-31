using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeQucikSort
{
    class MergeSort
    {
        public int[] Sort(int[] array)
        {
            if (array.Length <= 1)
                return array;

            int midpoint = array.Length / 2;
            int[] leftArray = new int[midpoint];
            int[] rightArray = new int[(array.Length % 2 == 0) ? midpoint : midpoint + 1];

            for (int i = 0; i < leftArray.Length; i++)
                leftArray[i] = array[i];
            for (int i = 0; i < rightArray.Length; i++)
                rightArray[i] = array[i + leftArray.Length];

            int[] leftMerged = Sort(leftArray);
            int[] rightMerged = Sort(rightArray);

            return Merge(leftMerged, rightMerged);
        }

        private int[] Merge(int[] leftArray, int[] rightArray)
        {
            int[] resultArray = new int[leftArray.Length + rightArray.Length];
            leftArray.CopyTo(resultArray, 0);
            rightArray.CopyTo(resultArray, leftArray.Length);

            int lengthToCheck = resultArray.Length;
            for (int i = 0; i < resultArray.Length; i++)
            {
                bool complete = true;
                for (int j = 0; j < lengthToCheck - 1; j++)
                {
                    if (resultArray[j] > resultArray[j + 1])
                    {
                        int temp = resultArray[j + 1];
                        resultArray[j + 1] = resultArray[j];
                        resultArray[j] = temp;
                        complete = false;
                    }
                }
                if (complete) break;
                lengthToCheck--;
            }
            return resultArray;
        }
    }
}
