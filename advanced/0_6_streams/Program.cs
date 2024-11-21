using System.Reflection.PortableExecutable;

string path = "C:\\Users\\laimo\\OneDrive\\dokumentai\\GitHub\\NETUA6\\advanced\\0_6_streams\\file.txt";

string fileContent = File.ReadAllText(path);
string[] fileContentLines = File.ReadAllLines(path);

foreach (var line in fileContentLines) 
{
    Console.WriteLine(line);
}

var fileContentLinesFast = File.ReadLines(path);

foreach (var line in fileContentLinesFast) 
{
    Console.WriteLine(line + 1);
}

Console.WriteLine();

DirectoryInfo[] dirs = new DirectoryInfo(path).GetDirectories();

using (var writer = new StreamWriter(path)) 
{
    foreach (var dir in dirs)
    {
        writer.WriteLine(dir.Name);
    }
}

string line = "";
using (var reader = new StreamReader(path)) 
{
    while ((line = reader.ReadLine()) != null) 
    {
        Console.WriteLine(line);
    }
}

var reader1 = new StreamReader(path);
while ((line = reader1.ReadLine()) != null)
{
    Console.WriteLine(line);
}
reader1.Dispose();

var fileStream = new FileStream(path, FileMode.Open, FileAccess.Write, FileShare.None, 10);
fileStream.Dispose();

using (var fileStream2 = new FileStream(path, FileMode.Open, FileAccess.Write, FileShare.None, 10)) 
{
   

}
