namespace _0_inheritance
{
    public class Polygon
    {
        //ctor
        public Polygon()
        {
            NumberOfAngles = 0;
        }

        public Polygon(int numberOfAngles)
        {
            NumberOfAngles = numberOfAngles;
        }

        //prop
        public int NumberOfAngles { get; set; }

        public void PrintNumberOfAngles() 
        {
            Console.WriteLine(NumberOfAngles);
        }

        public virtual double GetPerimater() 
        {
            return 0;
        }
    }
}
