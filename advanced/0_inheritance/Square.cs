namespace _0_inheritance
{
    public class Square : Polygon
    {
        public Square()
        {
            NumberOfAngles = 4;
        }

        public Square(double size) : this() //base
        {
            Size = size;
        }

        public double Size { get; set; }

        public void PrintSize() 
        {
            Console.WriteLine(Size);
        }

        public override double GetPerimater()
        {
            return NumberOfAngles * 4;
        }
    }
}
