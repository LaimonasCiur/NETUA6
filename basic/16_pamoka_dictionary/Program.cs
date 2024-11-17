Dictionary<string, int> cities = new Dictionary<string, int>();

var citiesWithValues = new Dictionary<string, int>
{
    { "Vilnius", 9 },
    { "Kaunas", 9},
    { "Klaipeda", 10 },
};

var playerPoints = new Dictionary<string, List<int>>();
var playerPointsWithValues = new Dictionary<string, List<int>>
{
    {"Tomas", new List<int> { 7, 8, 9 } }
};

foreach (var cityKeyValuePair in citiesWithValues)
{
    Console.WriteLine(cityKeyValuePair);
    Console.WriteLine(cityKeyValuePair.Key);
    Console.WriteLine(cityKeyValuePair.Value);
}

var isValue = playerPoints.TryGetValue("Tomas", out var points);
if (!isValue) 
{
    playerPoints.Add("Tomas", new List<int> {9});
    playerPoints.Add("Jonas", new List<int> {9});
}

var t = playerPoints.Values;
var t1 = playerPoints.Keys;

var t2 = Methods._myProperty;

var myList = new List<int>();
Methods.Test(myList);
Console.WriteLine();

public static class Methods 
{
    public static List<int> _myProperty { get; set; }

    public static void Test(List<int> myList) 
    {

        _myProperty.Add(9);
        myList.Add(1);
    }

    public static void Test2()
    {
        _myProperty.Add(9);

    }


    public static void Test3()
    {
        _myProperty.Add(9);

    }
}
