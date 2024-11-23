namespace _1_1_generics
{
    internal class MySelftMadeList<T>
    {
        private T[] InternalArray { get; set; }
        private int Index = 0;
        private int Size = 10;

        public MySelftMadeList()
        {
            InternalArray = new T[Size];
        }

        public void Remove(T item)
        {
            int index = -1;
            for (int i = 0; i < Size; i++)
            {
                if (Equals(InternalArray[i], item))
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                for (int i = index; i < Size - 1; i++)
                {
                    InternalArray[i] = InternalArray[i + 1];
                }

                Index--;
            }
        }

        public void AddItem(T item) 
        {
            if (CheckIfFull()) 
            {
                InternalArray = IncreaseListSize();
            }

            if (item != null)
            {
                InternalArray[Index] = item;
                Index++;
            }
            else 
            {
                throw new ArgumentNullException($"Argument was null: {item}");
            }
        }

        private bool CheckIfFull() 
        {
            return Index == Size;
        }

        private T[] IncreaseListSize() 
        {
            Size += (Size / 2);
            var newArray = new T[Size];
            InternalArray.CopyTo(newArray, 0);
            return newArray;
        }
    }
}
