using System;
using System.Collections.Generic;
using System.Text;

namespace DS.QueueADT
{
    public class Queue<T>
    {
        public T[] arr { get; set; }
        public int frontPtr { get; set; }
        public int rearPtr { get; set; }
        public int size { get; set; }

        // Insertion is done at rear end and deletion is done at front end
        public Queue(int size)
        {
            this.arr = new T[size + 1];
            this.frontPtr = 0;
            this.rearPtr = 0;
            this.size = size + 1;
        }

        // Rear should always not be equal to front. If it is equal, queue is empty
        public bool IsFull()
        {
            if ((this.rearPtr + 1) % this.size == this.frontPtr)
            {
                return true;
            }
            return false;
        }

        public bool IsEmpty()
        {
            if (this.rearPtr == this.frontPtr)
            {
                return true;
            }
            return false;
        }
    }
}
