//string text = "Tekstas";
//string newText = text.Insert(0, "X");

//Console.WriteLine(text[0]);

//char[] symbols = text.ToCharArray();
//symbols[0] = 'X';
//string changedText = new string(symbols);

//Console.WriteLine(changedText);

//char changedTextSymbol = changedText[3];
//Console.WriteLine(changedTextSymbol);


//string greeting = "Labas";

//string textWithChangedSymbol = greeting.Replace('a', 'x');

//Console.WriteLine(textWithChangedSymbol);

//string input = Console.ReadLine();

//if (string.IsNullOrWhiteSpace(input))
//{
//    Console.WriteLine("input is null or empty");
//}else
//{
//    Console.WriteLine("Input is not null or empty");
//}

//string text = "123A";

//if (int.TryParse(text, out int number))
//{
//    Console.WriteLine("Conversion successful: " + number);
//}
//else
//{
//    Console.WriteLine("Conversion unsuccessful: " + number);
//}

//string text = "111222333111";

//int count = text.Count(r => r == '1');
//Console.WriteLine(count);

//string sentence = "blah blah blah1. blah blah blah2. blah blah blah3. blah blah blah4.";
//string[] sentences = sentence.Split(".");

////Console.WriteLine(sentences[0]);
////Console.WriteLine(sentences[1]);
////Console.WriteLine(sentences[2]);
////Console.WriteLine(sentences[3]);

//string text2 = sentence.Substring(1, 5);
//string text3 = sentence.Substring(5);

//Console.WriteLine(text2);
//Console.WriteLine(text3);

//string input = Console.ReadLine();
//Console.WriteLine(input.Length);
//string trimedInput = input.Trim();
//Console.WriteLine(trimedInput.Length);

string x = "aa";
string y = "ab";

Console.WriteLine(x.CompareTo(y));