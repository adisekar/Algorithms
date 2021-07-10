using System;
using System.Text;

namespace DS.QueueADT
{
    public class CircularQueue
    {
        private Queue<int> queue;
        public CircularQueue(int size)
        {
            queue = new Queue<int>(size);
        }

        public void Enqueue(int num)
        {
            if (!queue.IsFull())
            {
                queue.rearPtr = (queue.rearPtr + 1) % queue.size;
                queue.arr[queue.rearPtr] = num;
            }
            else // queue is full. Now dequeue and add items. 
            {
                Dequeue();
                Enqueue(num);
            }
        }

        public int Dequeue()
        {
            int x = -1;
            if (!queue.IsEmpty())
            {
                queue.frontPtr = (queue.frontPtr + 1) % queue.size;
                x = queue.arr[queue.frontPtr];
            }
            else
            {
                Console.WriteLine("Queue is empty");
            }
            return x;
        }

        public void PrintItems()
        {
            int i = (queue.frontPtr + 1) % queue.size;
            while (i != (queue.rearPtr + 1) % queue.size)
            {
                Console.WriteLine(queue.arr[i]);
                i = (i + 1) % queue.size;
            }
        }
    }
}
