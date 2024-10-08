/// String kintamasis
string input = "Hello, World!";
Console.WriteLine(input);
Console.WriteLine("Hello, World!");

//Sukuriame 3cia kintamaji
string firstLine = "vienas";
string secondLine = "du";
string thirdLine = firstLine + secondLine;

Console.WriteLine(firstLine);

firstLine = firstLine + secondLine;
// firstLine += secondLine

Console.WriteLine(firstLine);
Console.WriteLine(thirdLine);

//cw => Console.WriteLine()
string myInput = "5";


///Indeksavimas
///////////////////////////////////////////////////////////////////////////////
string city = "Vilnius";
int wordLenght = "Vilnius".Length;
int wordLenght2 = city.Length;

Console.WriteLine(wordLenght);
Console.WriteLine(wordLenght2);

string myInput2 = "CodeAcademy";
char myChar = myInput2[0];
Console.WriteLine(myChar);

int lastIndex = myInput2.Length - 1;
char lastChar = myInput2[lastIndex];

Console.WriteLine(lastChar);
//char wrongChar = myInput2[myInput2.Length];

//Tuscios eilutes
////////////////////////////////////////////////////////////////////////////////////
string word1 = "";
string word2;
word2 = "dsdsd";

//Replace
string word3 = "mama";
string word4 = word3.Replace('m', 'p');

//string consoleOutput = Console.ReadLine();
//Console.WriteLine(consoleOutput.Length);

string myWord5 = "CodeAcademy";
string myWordSubstring = myWord5.Substring(2, 5);
string myWordSubstring2 = myWord5.Substring(2).Trim().Replace("a", "qwe");
Console.WriteLine(myWordSubstring2);
//CTRL + D => eilutes dublikavimas


//IndexOf
int index1 = myWord5.IndexOf('y');
int index2 = myWord5.IndexOf("Code");
Console.WriteLine(index1);
Console.WriteLine(index2);

//Trim
string myWord6 = "    Mano vardas Laimonas      ";
Console.WriteLine("Before trim");
Console.WriteLine(myWord6.Length);
Console.WriteLine("After trim");
Console.WriteLine(myWord6.Trim().Length);

//Apjungti eilutes
string word7 = "ap", word8 = "gal", word9 = "voti";
//string word8 = "gal";
//string word9 = "voti";
string result = "";
result += word7;
result += word8;
result += word9;

string result2 = string.Concat(word7, word8, word9);

Console.WriteLine(result);

//ToString()
int number = 987;
string numberString = number.ToString();
string numberString2 = Convert.ToString(number);
int convertedNumber = Convert.ToInt32(numberString);
string charString = numberString[0].ToString();
string upperCase = numberString.ToUpper();
string lowerCase = numberString.ToLower();
