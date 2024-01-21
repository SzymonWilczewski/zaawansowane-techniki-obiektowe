using System;

namespace AbstractionDataTypes
{
    public class CustomStack
    {
        private int[] elements = new int[1024];
        private int counter = 0;

        public bool IsEmpty() => counter == 0;

        public void Push(int element)
        {
            if (counter == elements.Length) { throw new StackOverflowException(); }
            
            elements[counter] = element;
            counter++;
        }

        public int Pop()
        {
            if (this.IsEmpty()) { throw new InvalidOperationException(); }

            int poppedElement = elements[counter - 1];
            counter--;

            return poppedElement;
        }
    }
}
