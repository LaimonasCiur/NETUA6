namespace _1_1_generics
{
    internal class MyInternalIntList
    {
        private List<int> InternalList { get; set; } = new List<int>();

        public void AddItem(int item)
        {
            InternalList.Add(item);
        }
    }
}
