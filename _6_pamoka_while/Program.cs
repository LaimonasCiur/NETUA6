
int i = 1;
string result = "";

while (i <= 5) 
{
    string t = "t";
    Console.WriteLine(t);

    Console.WriteLine("Iveskite teksta:");
    string input = Console.ReadLine();

    result += " " + input;
    i++;
}
Console.WriteLine(result);

int x = 1;
int y = 1;
while (x <= 3) 
{
    int myInput = 5;
    Console.WriteLine("Outer scoope: " + x);

    while (y <= 3) 
    {
        int myOutput = 5;

        myInput++;
        Console.WriteLine("Inner scoope: " + y);
        y++;
    }

    //myOutput++;

    y = 1; //Nustatome vidinio ciklo skaitliuka i pradine reiksme
    x++;
}


int number;
bool isNumber = false;
do
{
    Console.WriteLine("Iveskite skaiciu: ");
    string input = Console.ReadLine();
    isNumber = int.TryParse(input, out number);
    if (isNumber) 
    {
        Console.WriteLine(isNumber);
    }
} while (!isNumber);