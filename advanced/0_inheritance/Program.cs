using _0_inheritance;

Polygon p = new Polygon(6);
Console.WriteLine(p.NumberOfAngles);
p.PrintNumberOfAngles();

Square s = new Square(6);
Console.WriteLine(s.Size);
Console.WriteLine(s.NumberOfAngles);
s.PrintNumberOfAngles();
s.PrintSize();

Employee e = new Employee();
