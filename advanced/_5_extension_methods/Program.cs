using _5_extension_methods;

//var extensions = new Extensions();
//Extensions.Number = 999;
//extensions.Print();

//var extensions2 = new Extensions();
//Console.WriteLine(Extensions.Number);
Extensions.Print();
var str = "Hello this is my first extension method";

var t = Extensions.WordCount(str, false);
Console.WriteLine(Extensions.WordCount(str, false));

var t1 = str.WordCount(false);
Console.WriteLine(str.WordCount(false));

str.WordCount2(str)
    .WordCount3()
    .WordCount(false);

str.WordCount4();
5.WordCount4();
true.WordCount4();

var testClass = new TestClass();
testClass.Test2();
TestClass.Test();


