using System.Globalization;

int day = 3;
string result2 = "";
switch (day) 
{
    case 1:
        result2 = "Case 1";
        Console.WriteLine("Pirmadienis");
        break;
    case 2:
        Console.WriteLine("Antradienis");
        break;
    case 3:
        Console.WriteLine("Trečiadienis");
        break;
    //Ir taip toliau....
    default:
        Console.WriteLine("Neteisinga diena");
        break;
}


int operation = 1;
string result = operation switch
{
    1 => "Case 1",
    2 => "Case 2",
    3 => "Case 3",
    _ => "Default case"
};

string operation1 = "+";
int num1 = 2;
int num2 = 5;
int result3 = operation1 switch
{
    "+" => num1 + num2,
    "-" => num1 - num2,
    _ => 0
};
Console.WriteLine(result);


int age = 21;
string status = age switch
{
    > 7 and < 18 => "Moksleivis",
    _ => "Niekas"
};

