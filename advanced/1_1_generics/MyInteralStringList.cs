namespace _1_1_generics
{
    public class MyInteralStringList
    {
        private List<string> InternalList { get; set; } = new List<string>();

        public void AddItem(string item) 
        {
            InternalList.Add(item);
        }
    }
}
