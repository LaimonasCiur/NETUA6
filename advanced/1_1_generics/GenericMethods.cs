namespace _1_1_generics
{
    internal class GenericMethods
    {
        public void ShowItem<T>(T item) 
        {
            Console.WriteLine(item);
        }

        public string GetTypeName<T>(T item) 
        {
            if (item != null) 
            {
                return item.GetType().FullName;
            }

            return string.Empty;
        }
    }
}
