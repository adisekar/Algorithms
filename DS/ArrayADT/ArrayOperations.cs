using System;
using System.Collections.Generic;
using System.Text;

namespace DS.ArrayADT
{
    public class ArrayOperations
    {
        private int[] arr;
        private int size;
        public int currentFilledItems;

        public int[] Creation()
        {
            arr = new int[] { 2, 3, 5, 4, 2, 7, 8 };
            size = arr.Length;
            currentFilledItems = arr.Length - 1;
            return arr;
        }

        public void Display()
        {
            for(int i =0; i< arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void Push(int num)
        {
            if(arr.Length == size)
            {
                IncreaseSize();
            }

            arr[currentFilledItems] = num;
            currentFilledItems++;
        }

        public void IncreaseSize()
        {
            // Copy elements from old arr to new arr
            var temp = new int[2 * arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
            size = arr.Length;
        }

        public void Insert(int pos, int item)
        {
           if(pos >= 0 && pos <= currentFilledItems)
            {
                for(int i = currentFilledItems; i > pos; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[pos] = item;
                currentFilledItems++;
            }
        }

        public void Delete(int index)
        {
            for(int i = index; i < currentFilledItems; i++)
            {
                arr[i] = arr[i + 1];
            }
            currentFilledItems--;
        }

        // Can calulate running min max sum and average, by maintaing these values as when we insert delete an item
        public int GetMax()
        {
            int max = arr[0];
            for (int i = 0; i < currentFilledItems; i++)
            {
               if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public int GetMin()
        {
            int min = arr[0];
            for (int i = 0; i < currentFilledItems; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public int GetSum()
        {
            int sum = 0;
            for (int i = 0; i < currentFilledItems; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public int GetSumRecursive(int n)
        {
            if(n  < 0)
            {
                return 0;
            }
            else
            {
                return GetSumRecursive(n - 1) + arr[n];
            }
        }

        public double GetAverage()
        {
            int sum = 0;
            for (int i = 0; i < currentFilledItems; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }
    }
}
