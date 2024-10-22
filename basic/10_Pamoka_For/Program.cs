for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 3; i <= 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 0; i <= 10; i += 3)
{
    Console.WriteLine(i);
}

string result = "mano vardas";
char r = result[0];
for (int i = 0; i < result.Length; i++) 
{
    if (i == 5) 
    {
        break;
    }

    if (i == 0)
    {
        char firstLetter = result[0];
        Console.WriteLine(firstLetter.ToString().ToUpper());
        continue;
    }

    Console.WriteLine(result[i]);
}

int num1 = Methods.GetNumberInput(true);
int num2 = Methods.GetNumberInput(false);

int num3 = Methods.GetNumberInput("firstNumber");
int num4 = Methods.GetNumberInput("secondNumber");

List<int> listas = new List<int>();
for (int i = 1; i < 10; i++)
{
    int num = Methods.GetNumberInput($"{i} number");
    listas.Add(num);
}

for (int i = 0; i < listas.Count; i++)
{
    int item = listas[i];
}

int num5 = Methods.GetNumberInput("thirdNumber");


public static class Methods 
{
    public static int GetNumberInput(bool isFirstNumber) 
    {
        string consoleText = isFirstNumber ? "firstNumber" : "secondNumber";
        Console.WriteLine($"Enter {consoleText}");
        string input = Console.ReadLine();
        return int.Parse(input);
    }

    public static int GetNumberInput(string consoleText)
    {
        Console.WriteLine($"Enter {consoleText}");
        string input = Console.ReadLine();
        return int.Parse(input);
    }
}
