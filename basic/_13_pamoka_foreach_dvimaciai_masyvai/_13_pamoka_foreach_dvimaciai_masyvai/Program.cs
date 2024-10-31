namespace _13_pamoka_foreach_dvimaciai_masyvai
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "toyota", "bmw", "audi" };

            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}

            //foreach (string car in cars)
            //{
            //    Console.WriteLine(car);
            //}

            //for (int i = 0; i < cars.Length; i += 2)
            //{
            //    Console.WriteLine(cars[i]);
            //}

            //int[] numbers = { 3, 1, 2 };
            //for(int i = 0; i < numbers.Length - 1; i++)
            //{
            //    if (numbers[i] <= numbers[i + 1])
            //    {

            //    }
            //}


            //int rows = 3;
            //int columns = 5;
            //int[,] simpleMatrix = new int[rows, columns];

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        simpleMatrix[i, j] = i + j;
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(simpleMatrix[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //foreach (int number in simpleMatrix)
            //{
            //    Console.Write(number + "\t");
            //}

            string[,] table = new string[3, 3];
            table[0, 0] = "Name";
            table[0, 1] = "Age";
            table[0, 2] = "City";

            table[1, 0] = "John";
            table[1, 1] = "25";
            table[1, 2] = "New York";

            table[2, 0] = "Jane";
            table[2, 1] = "30";
            table[2, 2] = "London";

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j].PadRight(10));
                }
                Console.WriteLine();
            }

            string[,,] table3 = new string[3, 3, 4];
            Console.WriteLine(table3.GetLength(2));

        }
    }
}
