using System;

namespace Csharp
{
    // int[] list = {1,4,6,9};
    // int item_needed = 6;
    // private void
    public class BinarySearch
    {
        public Object?[] list1;

        public BinarySearch(int num)
        {
            list1 = new Object?[num];
        }

        void LeftNode()
        {

        }

        void RightNode()
        {

        }
    }

    class HashTable
    {
        Object[] hashtab;

        public HashTable(int num)
        {
            hashtab = new Object[num];
        }

        void HashFunction()
        {

        }
    }

    class Alphabet : HashTable
    {
        public Alphabet() : base(26)
        {

        }
    }
}
