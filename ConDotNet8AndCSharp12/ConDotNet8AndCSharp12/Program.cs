// See https://aka.ms/new-console-template for more information
using ConDotNet8AndCSharp12;


Console.WriteLine("Hello, World!");

Pie p1 = new Pie(1, "ChocoPie", 12.56, new List<string>() { "Choco", "Flour", "Sugar" });
Pie p2 = new Pie(2, "Cheese Pie", 13.45);

p1.DisplayIngredients();
Console.WriteLine( "---------Array Changes-----------" );
CollectionChanges changes = new CollectionChanges();
changes.MultiArray();
Console.WriteLine( "----------INTERCEPTORS----------------------");
PieOne one = new();
one.Display("Test");
one.Display("Test");
one.Display("Test");
one.Display("Test");
one.Display("Test");
one.Display("Test");



