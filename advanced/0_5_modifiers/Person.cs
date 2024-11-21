namespace _0_5_modifiers
{
    public class Person
    {
        private string MyProperty = "s";

        internal string MyProperty2 { private get; set; }

        public string MyProperty3 { private get; set; }

        protected int Id { get; set; }

        public Person()
        {
            
        }
    }
}
