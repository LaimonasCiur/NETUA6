namespace _0_4_abstract
{
    internal class Dog : Animal
    {
        public Dog(double weight) : base(weight)
        {
        }

        //implementation
        public override string Sound => "Au Au!";

        //implementation
        public override void MakeNoise()
        {
            Console.WriteLine($"Dog says: {Sound}");
        }
    }
}
