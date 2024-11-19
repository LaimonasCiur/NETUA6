namespace _0_4_abstract
{
    internal class Cat : Animal
    {
        public bool IsDomestic { get; set; }

        public Cat(double weight) : base(weight)
        {

        }

        public Cat(double weight, bool isDomestic) : base(weight)
        {
            IsDomestic = isDomestic;
        }

        public override string Sound => "Miau Miau!";

        public override void MakeNoise()
        {
            Console.WriteLine($"Cat says: {Sound}");
        }
    }
}
