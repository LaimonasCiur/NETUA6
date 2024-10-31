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
var t1 = playerPoints.Values;