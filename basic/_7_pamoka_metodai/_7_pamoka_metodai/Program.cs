namespace _7_pamoka_metodai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintMenu();
            //Console.WriteLine();
            //int userSelection = GetUserSelection();
            //if(userSelection != -1)
            //{
            //    ProcessSelection(userSelection);
            //}

            //Console.WriteLine(userSelection);

            DateTime input = new DateTime(2005, 6, 15);

            if (IsOfLegalAge(input)) 
            {
                Console.WriteLine("Ivestas legalus amzius");
            }
            else
            {
                Console.WriteLine("Ivestas nelegalus amzius");
            }

        }

        public static bool IsOfLegalAge(DateTime birthdate)
        {
            return CalculateAge(birthdate) >= 20;
        }

        public static int CalculateAge(DateTime birthDate)
        {
            return DateTime.Now.Year - birthDate.Year;
        }

        private static int ReturnNumber()
        {
            return 100;
        }

        private static void PrintMenu()
        {
            Console.WriteLine("1. Spausdinti prekes");
            Console.WriteLine("2. Žiūrėti krepšlį");
            Console.WriteLine("3. Išvalyti krepšelį");
            Console.WriteLine("4. Pirkti");
            Console.WriteLine("5. Išjungti programą");
        }

        private static int GetUserSelection()
        {
            Console.WriteLine("Įveskite pasirinkimą");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                if(int.TryParse(input, out int result) && (result >= 1 && result <= 5))
                {
                    return result;
                }

                Console.WriteLine("Įveskite skaičių tarp 1 ir 5.");
            }

            return -1;
        }

        private static void ProcessSelection(int selection)
        {
            switch (selection)
            {
                case 1:
                    Console.WriteLine("Pasirinkote spausdinti prekes");
                    break;
                case 2:
                    Console.WriteLine("Pasirinkote žiūrėti krepšelį");
                    break;
                case 3:
                    Console.WriteLine("Pasirinkote išvalyti krepšelį");
                    break;
                case 4:
                    Console.WriteLine("Pasirinkote pirkti");
                    break;
                case 5:
                    Console.WriteLine("Pasirinkote išjungti programą");
                    break;
            }
        }
    }
}
