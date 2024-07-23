// See https://aka.ms/new-console-template for more information
using NewApisDotNet8;
using System.Collections.Frozen;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

Console.WriteLine(  "-----------------------");

TimeOfDayService timeOfDayService = new TimeOfDayService(TimeProvider.System);

Console.WriteLine(  timeOfDayService.GetTimeOfDay());
Console.WriteLine(  "--------Random class-----------");

int[] arr = [1, 2, 3, 4, 5, 6];
Random .Shared.Shuffle (arr);
foreach (int i in arr)
{
    Console.WriteLine(  i);

}
Span<Product> allProducts = new[]
{
    new Product(1,"Laptop",400000),
    new Product(2,"Travel bag",3000),
    new Product(3,"Ear phones",2000),
    new Product(4,"Story book",450)
};
Random.Shared.Shuffle<Product> (allProducts);

foreach (Product product in allProducts)
{
    Console.WriteLine(product.Name);
}

Product[] selectedProds = Random.Shared.GetItems(allProducts.ToArray(), 3);
foreach (var item in selectedProds)
{
    Console.WriteLine(  item.Name);
}

int[] selectedInts = Random.Shared.GetItems(arr, 2);
foreach (int i in selectedInts)
{
    Console.WriteLine(i);
}

Console.WriteLine("-----------------");

var allChars = "abcdefghijklmnopqrstuvwxyz124567789";
var randomString = RandomNumberGenerator.GetString(allChars, 20);
Console.WriteLine(randomString);
//int items=12;

//FrozenSet<int> frozenDictionary = Enumerable.Range(0,items).ToFrozenSet();

