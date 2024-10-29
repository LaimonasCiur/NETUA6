using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text;

namespace _11_pamoka_debug_ir_stringbuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string input = null;
            //if (string.IsNullOrEmpty(input))
            //{
            //    PrintError("Įvesta tuščia reikšmė");
            //}

            string text = "";
            int iterations = 200000;

            // Pirmasis scenarijus: Tiesiogines "string" manipuliacijos
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < iterations; i++)
                text += "A";

            stopwatch.Stop();
            TimeSpan elapsedStringManipulation = stopwatch.Elapsed;

            // Antrasis scenarijus: "StringBuilder" naudojimas
            stopwatch.Reset();
            stopwatch.Start();

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < iterations; i++)
                stringBuilder.Append("A");

            string result = stringBuilder.ToString();
            
            stopwatch.Stop();
            TimeSpan elapsedStringBuilder = stopwatch.Elapsed;

            // Išvesti rezultatai
            Console.WriteLine("Tiesiogines 'string' manipuliacijos: " + elapsedStringManipulation);
            Console.WriteLine("Naudojant 'StringBuilder': " + elapsedStringBuilder);
        }

        public static string GetFullName(string firstName, string lastName)
        {
            Console.WriteLine("Registruotas naudotojas" + firstName + " " + lastName);
            return firstName.Trim() + " " + lastName.Trim();
        }

        public static void PrintError(string errorText)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(errorText);
            Console.ResetColor();
        }
    }
}
