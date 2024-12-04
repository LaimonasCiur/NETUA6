namespace _5_extension_methods
{
    public static class Extensions
    {
        public static int Number { get; set; }

        // static method
        public static void Print() 
        {
            Console.WriteLine(Number);
        }

        //extension method
        public static int WordCount(this string input, bool isNotNull) 
        {
            if (isNotNull) 
            {
                return input.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            }

            return 0;
        }

        //extension method
        public static string WordCount2(this string input, string input2)
        {
            return string.Join(',', input.ToArray());
        }

        public static string WordCount3(this string input)
        {
            return string.Join(',', input.ToArray());
        }

        public static void WordCount4<T>(this T param) 
        {
            param.GetType();
        }
    }
}
