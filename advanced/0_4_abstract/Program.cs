using _0_4_abstract;

//var animal = new Animal();
var dog = new Dog(50);
var cat = new Cat(10);

var animals = new List<Animal> 
{ 
    new Dog(50), 
    new Cat(10) 
};

foreach (var animal in animals) 
{
    Console.WriteLine(animal.Weight);
    animal.MakeNoise();
}