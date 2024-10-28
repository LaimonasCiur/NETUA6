using System.Xml;

namespace _9_pamoka_ref_ir_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int y = 10;
            //ChangeValue(ref y);
            //ChangeValueAgain(ref y);
            //Console.WriteLine(y);


            //GetDimensions(out int width, out int height);
            //Console.WriteLine("Plotis:" + width + ", aukstis: " + height);
            //Console.WriteLine($"Plotis: {width}, aukstis: {height}");


            // while continue example

            int x = -1;
            while(x <= 10)
            {
                x++;
                if(x % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(x);
            }
        }

        static void ChangeValue(ref int x)
        {
            x = 200;
        }

        static void ChangeValueAgain(ref int z)
        {
            int x = 0;
            while(x <= 3)
            {
                z += 5;
                x++;
            }
        }

        static void GetDimensions(out int width, out int height)
        {
            width = 1024;
            height = 764;
        }

        public static int GetUserSelectionOld()
        {
            while (true)
            {
                Console.WriteLine("Iveskite pasirinkima");
                if(!int.TryParse(Console.ReadLine(), out int input))
                {
                    Console.WriteLine("Ivestas blogas pasirinkimas");
                    continue;
                }
                return input;
            }
        }

        public static int GetUserSelection()
        {
            bool isValid = false;
            int input = 0;
            while (!isValid)
            {
                Console.WriteLine("Iveskite pasirinkima");
                string textInput = Console.ReadLine();
                if (!int.TryParse(textInput, out input))
                {
                    Console.WriteLine("Ivestas blogas pasirinkimas");
                    continue;
                }
                isValid = true;
            }
            return input;
        }
    }
}
