using _1_1_generics;

var genericMethods = new GenericMethods();
genericMethods.ShowItem<string>("string");
genericMethods.ShowItem<int>(1);
genericMethods.GetTypeName<GenericMethods>(new GenericMethods());

var myList = new MySelftMadeList<bool>();
myList.AddItem(true);
myList.AddItem(false);

var myListInt = new MySelftMadeList<int>();
myListInt.AddItem(1);
myListInt.AddItem(2);
myListInt.AddItem(3);
myListInt.Remove(2);
myListInt.AddItem(2);
//myListInt.Remove(2);