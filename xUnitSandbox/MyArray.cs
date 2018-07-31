using System.Collections.Generic;

namespace xUnitSandbox
{
    public class MyArray
    {
        public int[] InternalArray{ get; }

        public MyArray(int[] internalArray)
        {
            InternalArray = internalArray;
        }

        public IEnumerable<int> Reverse()
        {
            for (int i = InternalArray.Length - 1; i >= 0; i--)
            {
                yield return InternalArray[i];
            }
        }
    }


}
