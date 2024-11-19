namespace _0_4_abstract
{
    public abstract class Animal
    {
        public double Weight { get; set; }

        public abstract string Sound { get; }

        public Animal(double weight)
        {
            Weight = weight;
        }

        //definition
        public abstract void MakeNoise();
    }
}
