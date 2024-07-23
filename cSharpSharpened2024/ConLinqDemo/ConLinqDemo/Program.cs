// See https://aka.ms/new-console-template for more information
Console.WriteLine("Working with LINQ using C#....");

int[] nums = { 3, 5, 6, 7, 8, 911, 22 };

//query syntax

var result = from number in nums
             where number % 2 == 0
             select number;

//Console.WriteLine(result);
foreach (var r in result)
{
    Console.WriteLine(r);
}


