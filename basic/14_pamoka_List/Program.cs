List<int> numbers = new List<int>();

List<int> numberWithValues = new List<int> { 99, 101, 642, 1 };

var myVarNumbers = new List<int>();

var numberVarWithValues = new List<int> { 99, 101, 642 };
var myInt = 0;
var t = "";

numberWithValues.Add(753);

Console.WriteLine("Add");
foreach (var number in numberWithValues) 
{
    Console.WriteLine(number);
}

Console.WriteLine("Remove");
numberWithValues.Remove(99);
foreach (var number in numberWithValues)
{
    Console.WriteLine(number);
}

Console.WriteLine("Count");
int count = numberWithValues.Count;
Console.WriteLine(count);

Console.WriteLine("Sort");
numberWithValues.Sort();
foreach (var number in numberWithValues)
{
    Console.WriteLine(number);
}



List<object> myObjectList = new List<object>();
myObjectList.Add(1);
myObjectList.Add("myString");
myObjectList.Add('n');

var t2 = myObjectList[0];
Console.WriteLine();





