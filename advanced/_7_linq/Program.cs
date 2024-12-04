Func<int, int> multiplyByFive = num => num * 5;
int result = multiplyByFive(5);

Func<int, int, int> add = (a, b) => a + b;
int addResult = add(5, 10);

Action<int> printExpression = num => Console.WriteLine(num);
Action<int> printLamdaStatement = num =>
{
    var t = "string";
    Console.WriteLine(t + num);
};

Predicate<int> predicate = num => num > 5;
bool predicateResult = predicate(10);

Func<string, string> selector = str => str.ToUpper().ToLower().ToLowerInvariant();
string[] words = { "a", "b", "name" };
var wordsResult = words.Select(selector);

var wordsResult2 = words.Select(x => x.ToUpper());
var wordsResult3 = words.Select(selector);
var wordsResult4 = words.Select(selector);
var wordsResult5 = words.Select(selector);

var t = words
    .Where(x => x == "t")
    .Select(x => x.ToUpper())
    .Where(x => x == "t");

foreach (var item in t)
{
    Console.WriteLine(item);
}

var t1 = words.SingleOrDefault(x => x == "");
var t2 = words.FirstOrDefault(x => x == "");
var t3 = words.First(x => x == "");
if (t1 == null) 
{
    Console.WriteLine("No records have been found!");
}


