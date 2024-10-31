int[] emptyArray = new int[10];
int[] arrayWithInitialValues = { 1, 2, 88, 105, 999 };

Console.WriteLine(emptyArray[5]);

arrayWithInitialValues[4] = 23;

string[] sentences = { "abc", "text", "random" };
for (int i = 0; i < sentences.Length; i++) 
{
    Console.WriteLine(sentences[i]);
}

for (int i = 0; i < emptyArray.Length; i++) 
{
    emptyArray[i] = i * i;
    Console.WriteLine(emptyArray[i]);
}


double avarage = Methods.CaculateAvg(new[] { 1, 5, 6, });


public static class Methods 
{
    public static double CaculateAvg(int[] numbers) 
    {
        double sum = 0;

        foreach (int number in numbers) 
        { 
            sum += number;
        }

        return sum / numbers.Length;
    }
}

